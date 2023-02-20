using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] dirs;
        Stopwatch stopwatch = new Stopwatch();
        int filesCounter = 0;
        static int saltSize;
        byte[] password;
        public Form1()
        {
            InitializeComponent();
            groupBox4.Enabled = groupBox3.Enabled = groupBox2.Enabled = buttonEncrypt.Enabled = buttonDecrypt.Enabled = false;           
        }
        private void resetToDefault()
        {
            button3.Enabled = true;
            progressBar1.Value = 0;
            labelCompleted.Text = "";
            labelBarValue.Text = "0%";
            labelTime.Text = "Time:";
            groupBox4.Enabled = groupBox2.Enabled = groupBox3.Enabled = buttonEncrypt.Enabled = buttonDecrypt.Enabled = false;
            filesCounter = 0;
            labelCountFiles.Text = "0/0 files";
        }
        
        private void resetAfterFinish()
        {
            button3.Enabled = true;
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format(" {0:00}m:{1:00}s.{2:00}ms", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            labelTime.Text += elapsedTime;
            labelCompleted.Text = "Completed!";
            stopwatch.Reset();
            dirs = null;
            pathText.Text = null;
            foundlab.ForeColor = Color.Black;
            countlab.ForeColor = Color.Black;
            countlab.Text = "0";
            passwordBox.Text = null;
            filesCounter = 0;
        }

       private static byte[] generateRandomSalt()
        {
            byte[] data = new byte[saltSize];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(data);
            }
            return data;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog path = new FolderBrowserDialog();

            if (path.ShowDialog() == DialogResult.OK)
            {
                pathText.Text = path.SelectedPath;
            }
            else
            {
                return;
            }
            
            string[] ext = new[] { ".ppm", ".png", ".aes", ".lua", ".spr", ".otps", ".otui", ".otfont", ".otml", ".otmod", ".rsa" };
            dirs = Directory.GetFiles(pathText.Text, "*.*", SearchOption.AllDirectories)
               .Where(file => ext.Any(file.ToLower().EndsWith))
               .ToArray();         
            countlab.Text = Convert.ToString(dirs.Length);
            if (dirs.Length > 0)
            {
                if(progressBar1.Value > 0)
                {
                    resetToDefault();
                }
                countlab.ForeColor = Color.Green;
                foundlab.ForeColor = Color.Green;
                groupBox4.Enabled = groupBox3.Enabled = groupBox2.Enabled = buttonEncrypt.Enabled = buttonDecrypt.Enabled = true;
            }
            else
            {
                countlab.ForeColor = Color.Red;
                foundlab.ForeColor = Color.Red;
            }
        }       
        public string GetKeyString(RSAParameters privateKey)
        {
            var stringWriter = new StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, privateKey);
            return stringWriter.ToString();
        }
        private async void buttonEncrypt_Click(object sender, EventArgs e)
        {
            IProgress<int> percentage = new Progress<int>(percent =>
            {
                progressBar1.Value = percent * 100 / dirs.Length;
                labelBarValue.Text = percent * 100 / dirs.Length + "%";
                labelCountFiles.Text = percent + "/" + dirs.Length + " files";
            });
            if (tabPage1.Focus())
            {
                if (passwordBox.TextLength <= 0)
                {
                    //some error when fields empty
                    errorProvider1.SetError(passwordBox, "Fill up the field!");
                    return;
                }
                else
                    errorProvider1.Clear();

                Aes aes = Aes.Create();
                //aes.Mode = CipherMode.CBC;           the default mode as we need
                //aes.Padding = PaddingMode.PKCS7;     the default padding as recommended
                //aes.BlockSize = 128;                 the default block size as recommended
                aes.KeySize = Convert.ToInt32(keySize.Text);
                saltSize = aes.KeySize / 8;
                password = Encoding.UTF8.GetBytes(passwordBox.Text);

                byte[] salt = generateRandomSalt();
                var key = new Rfc2898DeriveBytes(password, salt, 10000);
                aes.Key = key.GetBytes(saltSize);
                aes.GenerateIV();
                byte[] IV = new byte[aes.IV.Length];
                aes.IV = IV;
                ICryptoTransform transform = aes.CreateEncryptor();

                try
                {                   
                    button3.Enabled = buttonEncrypt.Enabled = buttonDecrypt.Enabled = false;
                    labelCountFiles.Text = "0/" + dirs.Length + " files";
                    labelCompleted.Text = "Please wait...";
                    stopwatch.Start();
                    await Task.Run(() =>
                    {
                        foreach (string fileList in dirs)
                        {
                            string outFile = Path.Combine(fileList, Path.ChangeExtension(fileList, Path.GetExtension(fileList) + ".aes"));
                            using (var outFs = new FileStream(outFile, FileMode.Create))
                            {
                                outFs.Write(salt, 0, salt.Length);

                                using (var outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                                {

                                    int blockSizeBytes = aes.BlockSize / 8;
                                    byte[] data = new byte[blockSizeBytes];
                                    int count = 0;

                                    using (var inFs = new FileStream(fileList, FileMode.Open))
                                    {
                                        filesCounter++;
                                        while ((count = inFs.Read(data, 0, data.Length)) != 0)
                                        {
                                            outStreamEncrypted.Write(data, 0, count);
                                        }                                
                                        percentage.Report(filesCounter);
                                    }
                                    outStreamEncrypted.FlushFinalBlock();
                                }
                            }
                            File.Delete(fileList);
                        }
                    });
                    resetAfterFinish();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.GetType().ToString() + " " + exception.Message);
                    stopwatch.Reset();
                    resetToDefault();
                    dirs = null;
                    pathText.Text = null;
                    foundlab.ForeColor = Color.Black;
                    countlab.ForeColor = Color.Black;
                    countlab.Text = "0";
                    passwordBox.Text = null;
                    filesCounter = 0;
                }
            }
            else
            {
                if(tabPage2.Focus())
                {                               
                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Convert.ToInt32(keySizeRSA.Text));
                    var privKey = rsa.ExportParameters(true);
                    var pubKey = rsa.ExportParameters(false);

                    string privKeyString = GetKeyString(privKey);
                    
                    try
                    {
                        button3.Enabled = buttonEncrypt.Enabled = buttonDecrypt.Enabled = false;
                        labelCountFiles.Text = "0/" + dirs.Length + " files";
                        labelCompleted.Text = "Please wait...";
                        stopwatch.Start();
                        await Task.Run(() =>
                        {
                            foreach (string fileList in dirs)
                            {
                                string outFile = Path.Combine(fileList, Path.ChangeExtension(fileList, Path.GetExtension(fileList) + ".rsa"));
                                using (var outFs = new FileStream(outFile, FileMode.Create))
                                {
									int lengthData = ((rsa.KeySize - 384) / 8) + 6;
                                    byte[] data = new byte[lengthData];
                                    //max data length - remove padding, for PKCS1 ((rsa.KeySize - 384) / 8) + 37, for OAEP ((rsa.KeySize - 384) / 8) + 6
                                    long count = 0;
                                    byte[] encrypted;
                                    long file_size;   
                                    
                                    using (var inFs = new FileStream(fileList, FileMode.Open))
                                    {
                                        file_size = inFs.Length;
                                        filesCounter++;
                                        while (count <= file_size)
                                        {
                                            inFs.Read(data, 0, data.Length);
                                            encrypted = rsa.Encrypt(data, true);       
                                            outFs.Write(encrypted, 0, encrypted.Length);
                                            count += lengthData;
                                        }
                                        percentage.Report(filesCounter);
                                    }
                                }
                                File.Delete(fileList);
                            }
                            File.WriteAllText(@"private_key.txt", privKeyString);
                        });
                        resetAfterFinish();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.GetType().ToString() + " " + exception.Message);
                        stopwatch.Reset();
                        resetToDefault();
                        dirs = null;
                        pathText.Text = null;
                        foundlab.ForeColor = Color.Black;
                        countlab.ForeColor = Color.Black;
                        countlab.Text = "0";
                        passwordBox.Text = null;
                        filesCounter = 0;
                    }
                }
            }
        }

        private async void buttonDecrypt_Click(object sender, EventArgs e)
        {
            IProgress<int> percentage = new Progress<int>(percent =>
            {
                progressBar1.Value = percent * 100 / dirs.Length;
                labelBarValue.Text = percent * 100 / dirs.Length + "%";
                labelCountFiles.Text = percent + "/" + dirs.Length + " files";
            });
            if (tabPage1.Focus())
            {
                if (passwordBox.TextLength <= 0)
                {
                    //some error when fields empty
                    errorProvider1.SetError(passwordBox, "Fill up the field!");
                    return;
                }
                else
                    errorProvider1.Clear();

                Aes aes = Aes.Create();
                //aes.Mode = CipherMode.CBC;           the default mode as we need
                //aes.Padding = PaddingMode.PKCS7;     the default padding as recommended
                //aes.BlockSize = 128;                 the default block size as recommended
                aes.KeySize = Convert.ToInt32(keySize.Text);
                saltSize = aes.KeySize / 8;
                byte[] salt = new byte[saltSize];
                password = Encoding.UTF8.GetBytes(passwordBox.Text);
                int blockSizeBytes = aes.BlockSize / 8;              
                try
                {
                    button3.Enabled = buttonEncrypt.Enabled = buttonDecrypt.Enabled = false;
                    labelCountFiles.Text = "0/" + dirs.Length + " files";
                    labelCompleted.Text = "Please wait...";
                    stopwatch.Start();
                    await Task.Run(() =>
                    {
                        foreach (string fileList in dirs)
                        {
                            string outFile = Path.ChangeExtension(fileList, Path.GetExtension(fileList).Replace(".aes", ""));
                            using (var inFs = new FileStream(fileList, FileMode.Open))
                            {
                                inFs.Read(salt, 0, salt.Length);
                                var key = new Rfc2898DeriveBytes(password, salt, 10000);
                                aes.Key = key.GetBytes(saltSize);
                                aes.IV = new byte[blockSizeBytes];

                                ICryptoTransform transform = aes.CreateDecryptor();

                                using (var outFs = new FileStream(outFile, FileMode.Create))
                                {
                                    byte[] data = new byte[blockSizeBytes];
                                    int count = 0;

                                    using (var outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                                    {
                                        filesCounter++;
                                        while ((count = inFs.Read(data, 0, blockSizeBytes)) != 0)
                                        {
                                            outStreamDecrypted.Write(data, 0, count);
                                        }                                 
                                        outStreamDecrypted.FlushFinalBlock();
                                        percentage.Report(filesCounter);                                       
                                    }
                                }
                            }
                            File.Delete(fileList);
                        }
                    });
                    resetAfterFinish();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.GetType().ToString() + " " + exception.Message);
                    stopwatch.Reset();
                    resetToDefault();
                    dirs = null;
                    pathText.Text = null;
                    foundlab.ForeColor = Color.Black;
                    countlab.ForeColor = Color.Black;
                    countlab.Text = "0";
                    passwordBox.Text = null;
                    filesCounter = 0;
                }
            }
            else
            {
                if (tabPage2.Focus())
                {
                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

                    string privKeyString = File.ReadAllText(@"private_key.txt");

                    var stringReader = new StringReader(privKeyString);
                    var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                    RSAParameters privKey = (RSAParameters)xs.Deserialize(stringReader);

                    rsa.ImportParameters(privKey);
                    try
                    {
                        button3.Enabled = buttonEncrypt.Enabled = buttonDecrypt.Enabled = false;
                        labelCountFiles.Text = "0/" + dirs.Length + " files";
                        labelCompleted.Text = "Please wait...";
                        stopwatch.Start();
                        await Task.Run(() =>
                        {
                            foreach (string fileList in dirs)
                            {
                                string outFile = Path.Combine(fileList, Path.ChangeExtension(fileList, Path.GetExtension(fileList).Replace(".rsa", "")));
                                using (var inFs = new FileStream(fileList, FileMode.Open))
                                {
                                    byte[] data = new byte[rsa.KeySize / 8];
                                    long count = 0;
                                    byte[] decrypted;
                                    long file_size = inFs.Length;
                    
                                    using (var outFs = new FileStream(outFile, FileMode.Create))
                                    {                                  
                                        filesCounter++;

                                        while (count <= file_size)
                                        {
                                            inFs.Read(data, 0, data.Length);
                                            decrypted = rsa.Decrypt(data, true);
                                            outFs.Write(decrypted, 0, decrypted.Length);
                                            count += (rsa.KeySize / 8);
                                        }
                                        percentage.Report(filesCounter);
                                    }
                                }
                                File.Delete(fileList);
                            }
                        });
                        resetAfterFinish();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.GetType().ToString() + " " + exception.Message);
                        stopwatch.Reset();
                        resetToDefault();
                        dirs = null;
                        pathText.Text = null;
                        foundlab.ForeColor = Color.Black;
                        countlab.ForeColor = Color.Black;
                        countlab.Text = "0";
                        passwordBox.Text = null;
                        filesCounter = 0;
                    }
                }
            }
        }
    }
}
