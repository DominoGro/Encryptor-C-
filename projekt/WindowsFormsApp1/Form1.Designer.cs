
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.keySize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pathText = new System.Windows.Forms.TextBox();
            this.countlab = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.foundlab = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.errorPswd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelBarValue = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.labelCountFiles = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.keySizeRSA = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // keySize
            // 
            this.keySize.FormattingEnabled = true;
            this.keySize.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.keySize.Location = new System.Drawing.Point(15, 19);
            this.keySize.Name = "keySize";
            this.keySize.Size = new System.Drawing.Size(121, 23);
            this.keySize.TabIndex = 2;
            this.keySize.Text = "128";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encrypt your files to protect them";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(564, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pathText);
            this.groupBox1.Controls.Add(this.countlab);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.foundlab);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(57, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the folder with files";
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(270, 24);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(231, 25);
            this.pathText.TabIndex = 10;
            // 
            // countlab
            // 
            this.countlab.AutoSize = true;
            this.countlab.Location = new System.Drawing.Point(425, 52);
            this.countlab.Name = "countlab";
            this.countlab.Size = new System.Drawing.Size(15, 17);
            this.countlab.TabIndex = 9;
            this.countlab.Text = "0";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources.sbutton_search;
            this.button3.Location = new System.Drawing.Point(15, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // foundlab
            // 
            this.foundlab.AutoSize = true;
            this.foundlab.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.foundlab.Location = new System.Drawing.Point(328, 53);
            this.foundlab.Name = "foundlab";
            this.foundlab.Size = new System.Drawing.Size(70, 15);
            this.foundlab.TabIndex = 8;
            this.foundlab.Text = "Found files:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(6, 21);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(351, 22);
            this.passwordBox.TabIndex = 8;
            // 
            // errorPswd
            // 
            this.errorPswd.AutoSize = true;
            this.errorPswd.Location = new System.Drawing.Point(385, 214);
            this.errorPswd.Name = "errorPswd";
            this.errorPswd.Size = new System.Drawing.Size(0, 13);
            this.errorPswd.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.keySize);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 55);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "The key\'s length";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.passwordBox);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(183, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 55);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type your password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(332, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Advanced Encryption Standard (AES) | RSA";
            // 
            // labelCompleted
            // 
            this.labelCompleted.AutoSize = true;
            this.labelCompleted.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCompleted.Location = new System.Drawing.Point(240, 22);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(0, 19);
            this.labelCompleted.TabIndex = 15;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(402, 22);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(41, 19);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "Time:";
            // 
            // labelBarValue
            // 
            this.labelBarValue.AutoSize = true;
            this.labelBarValue.BackColor = System.Drawing.Color.Transparent;
            this.labelBarValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarValue.Location = new System.Drawing.Point(32, 22);
            this.labelBarValue.Name = "labelBarValue";
            this.labelBarValue.Size = new System.Drawing.Size(30, 19);
            this.labelBarValue.TabIndex = 17;
            this.labelBarValue.Text = "0%";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.buttonDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDecrypt.FlatAppearance.BorderSize = 0;
            this.buttonDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDecrypt.Image = global::WindowsFormsApp1.Properties.Resources.sbutton_red;
            this.buttonDecrypt.Location = new System.Drawing.Point(388, 282);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(140, 33);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.buttonEncrypt.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEncrypt.FlatAppearance.BorderSize = 0;
            this.buttonEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEncrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEncrypt.Image = global::WindowsFormsApp1.Properties.Resources.sbutton_green;
            this.buttonEncrypt.Location = new System.Drawing.Point(72, 282);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(139, 33);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // labelCountFiles
            // 
            this.labelCountFiles.AutoSize = true;
            this.labelCountFiles.BackColor = System.Drawing.Color.Transparent;
            this.labelCountFiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountFiles.Location = new System.Drawing.Point(139, 22);
            this.labelCountFiles.Name = "labelCountFiles";
            this.labelCountFiles.Size = new System.Drawing.Size(56, 19);
            this.labelCountFiles.TabIndex = 18;
            this.labelCountFiles.Text = "0/0 files";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(39, 154);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 112);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 77);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 77);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RSA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note: Your private key will be saved in a file private_key.txt ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.keySizeRSA);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(11, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 57);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "The key\'s length";
            // 
            // keySizeRSA
            // 
            this.keySizeRSA.FormattingEnabled = true;
            this.keySizeRSA.Items.AddRange(new object[] {
            "2048",
            "4096"});
            this.keySizeRSA.Location = new System.Drawing.Point(6, 21);
            this.keySizeRSA.Name = "keySizeRSA";
            this.keySizeRSA.Size = new System.Drawing.Size(121, 23);
            this.keySizeRSA.TabIndex = 0;
            this.keySizeRSA.Text = "2048";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.progressBar1);
            this.groupBox6.Controls.Add(this.labelBarValue);
            this.groupBox6.Controls.Add(this.labelTime);
            this.groupBox6.Controls.Add(this.labelCountFiles);
            this.groupBox6.Controls.Add(this.labelCompleted);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.Location = new System.Drawing.Point(39, 330);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(585, 87);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Progress Bar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 425);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorPswd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Encryptor\'n\'Decryptor 2022";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.ComboBox keySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label foundlab;
        private System.Windows.Forms.Label countlab;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Label errorPswd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelBarValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelCountFiles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox keySizeRSA;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

