namespace PasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRequireSpace = new System.Windows.Forms.CheckBox();
            this.chkRequireUnderscore = new System.Windows.Forms.CheckBox();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.chkRequireSpecial = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkRequireNumber = new System.Windows.Forms.CheckBox();
            this.txtMinLength = new System.Windows.Forms.TextBox();
            this.chkRequireUppercase = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkRequireLowercase = new System.Windows.Forms.CheckBox();
            this.chkAllowSpace = new System.Windows.Forms.CheckBox();
            this.chkAllowUnderscore = new System.Windows.Forms.CheckBox();
            this.chkAllowSpecial = new System.Windows.Forms.CheckBox();
            this.chkAllowNumber = new System.Windows.Forms.CheckBox();
            this.chkAllowUppercase = new System.Windows.Forms.CheckBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.chkAllowLowercase = new System.Windows.Forms.CheckBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(6, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(305, 23);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(196, 67);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 47);
            this.btnGenerate.TabIndex = 26;
            this.btnGenerate.Text = "Generate and copy";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnGenerate);
            this.GroupBox1.Controls.Add(this.chkRequireSpace);
            this.GroupBox1.Controls.Add(this.chkRequireUnderscore);
            this.GroupBox1.Controls.Add(this.txtMaxLength);
            this.GroupBox1.Controls.Add(this.chkRequireSpecial);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.chkRequireNumber);
            this.GroupBox1.Controls.Add(this.txtMinLength);
            this.GroupBox1.Controls.Add(this.chkRequireUppercase);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.chkRequireLowercase);
            this.GroupBox1.Controls.Add(this.chkAllowSpace);
            this.GroupBox1.Controls.Add(this.chkAllowUnderscore);
            this.GroupBox1.Controls.Add(this.chkAllowSpecial);
            this.GroupBox1.Controls.Add(this.chkAllowNumber);
            this.GroupBox1.Controls.Add(this.chkAllowUppercase);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.chkAllowLowercase);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(6, 1);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(305, 123);
            this.GroupBox1.TabIndex = 22;
            this.GroupBox1.TabStop = false;
            // 
            // chkRequireSpace
            // 
            this.chkRequireSpace.AutoSize = true;
            this.chkRequireSpace.Location = new System.Drawing.Point(160, 101);
            this.chkRequireSpace.Name = "chkRequireSpace";
            this.chkRequireSpace.Size = new System.Drawing.Size(15, 14);
            this.chkRequireSpace.TabIndex = 11;
            this.chkRequireSpace.UseVisualStyleBackColor = true;
            this.chkRequireSpace.CheckedChanged += new System.EventHandler(this.ChkRequireSpace_CheckedChanged);
            // 
            // chkRequireUnderscore
            // 
            this.chkRequireUnderscore.AutoSize = true;
            this.chkRequireUnderscore.Location = new System.Drawing.Point(160, 87);
            this.chkRequireUnderscore.Name = "chkRequireUnderscore";
            this.chkRequireUnderscore.Size = new System.Drawing.Size(15, 14);
            this.chkRequireUnderscore.TabIndex = 9;
            this.chkRequireUnderscore.UseVisualStyleBackColor = true;
            this.chkRequireUnderscore.CheckedChanged += new System.EventHandler(this.ChkRequireUnderscore_CheckedChanged);
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Location = new System.Drawing.Point(265, 37);
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(32, 20);
            this.txtMaxLength.TabIndex = 24;
            this.txtMaxLength.Text = "25";
            this.txtMaxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxLength.TextChanged += new System.EventHandler(this.TxtMaxLength_TextChanged);
            // 
            // chkRequireSpecial
            // 
            this.chkRequireSpecial.AutoSize = true;
            this.chkRequireSpecial.Checked = true;
            this.chkRequireSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequireSpecial.Location = new System.Drawing.Point(160, 73);
            this.chkRequireSpecial.Name = "chkRequireSpecial";
            this.chkRequireSpecial.Size = new System.Drawing.Size(15, 14);
            this.chkRequireSpecial.TabIndex = 7;
            this.chkRequireSpecial.UseVisualStyleBackColor = true;
            this.chkRequireSpecial.CheckedChanged += new System.EventHandler(this.ChkRequireSpecial_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(193, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 13);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Max. length:";
            // 
            // chkRequireNumber
            // 
            this.chkRequireNumber.AutoSize = true;
            this.chkRequireNumber.Checked = true;
            this.chkRequireNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequireNumber.Location = new System.Drawing.Point(160, 59);
            this.chkRequireNumber.Name = "chkRequireNumber";
            this.chkRequireNumber.Size = new System.Drawing.Size(15, 14);
            this.chkRequireNumber.TabIndex = 5;
            this.chkRequireNumber.UseVisualStyleBackColor = true;
            this.chkRequireNumber.CheckedChanged += new System.EventHandler(this.ChkRequireNumber_CheckedChanged);
            // 
            // txtMinLength
            // 
            this.txtMinLength.Location = new System.Drawing.Point(265, 13);
            this.txtMinLength.Name = "txtMinLength";
            this.txtMinLength.Size = new System.Drawing.Size(32, 20);
            this.txtMinLength.TabIndex = 23;
            this.txtMinLength.Text = "16";
            this.txtMinLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinLength.TextChanged += new System.EventHandler(this.TxtMinLength_TextChanged);
            // 
            // chkRequireUppercase
            // 
            this.chkRequireUppercase.AutoSize = true;
            this.chkRequireUppercase.Checked = true;
            this.chkRequireUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequireUppercase.Location = new System.Drawing.Point(160, 45);
            this.chkRequireUppercase.Name = "chkRequireUppercase";
            this.chkRequireUppercase.Size = new System.Drawing.Size(15, 14);
            this.chkRequireUppercase.TabIndex = 3;
            this.chkRequireUppercase.UseVisualStyleBackColor = true;
            this.chkRequireUppercase.CheckedChanged += new System.EventHandler(this.ChkRequireUppercase_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(193, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Min. length:";
            // 
            // chkRequireLowercase
            // 
            this.chkRequireLowercase.AutoSize = true;
            this.chkRequireLowercase.Checked = true;
            this.chkRequireLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequireLowercase.Location = new System.Drawing.Point(160, 31);
            this.chkRequireLowercase.Name = "chkRequireLowercase";
            this.chkRequireLowercase.Size = new System.Drawing.Size(15, 14);
            this.chkRequireLowercase.TabIndex = 1;
            this.chkRequireLowercase.UseVisualStyleBackColor = true;
            this.chkRequireLowercase.CheckedChanged += new System.EventHandler(this.ChkRequireLowercase_CheckedChanged);
            // 
            // chkAllowSpace
            // 
            this.chkAllowSpace.AutoSize = true;
            this.chkAllowSpace.Location = new System.Drawing.Point(117, 101);
            this.chkAllowSpace.Name = "chkAllowSpace";
            this.chkAllowSpace.Size = new System.Drawing.Size(15, 14);
            this.chkAllowSpace.TabIndex = 10;
            this.chkAllowSpace.UseVisualStyleBackColor = true;
            this.chkAllowSpace.CheckedChanged += new System.EventHandler(this.ChkAllowSpace_CheckedChanged);
            // 
            // chkAllowUnderscore
            // 
            this.chkAllowUnderscore.AutoSize = true;
            this.chkAllowUnderscore.Location = new System.Drawing.Point(117, 87);
            this.chkAllowUnderscore.Name = "chkAllowUnderscore";
            this.chkAllowUnderscore.Size = new System.Drawing.Size(15, 14);
            this.chkAllowUnderscore.TabIndex = 8;
            this.chkAllowUnderscore.UseVisualStyleBackColor = true;
            this.chkAllowUnderscore.CheckedChanged += new System.EventHandler(this.ChkAllowUnderscore_CheckedChanged);
            // 
            // chkAllowSpecial
            // 
            this.chkAllowSpecial.AutoSize = true;
            this.chkAllowSpecial.Checked = true;
            this.chkAllowSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowSpecial.Location = new System.Drawing.Point(117, 73);
            this.chkAllowSpecial.Name = "chkAllowSpecial";
            this.chkAllowSpecial.Size = new System.Drawing.Size(15, 14);
            this.chkAllowSpecial.TabIndex = 6;
            this.chkAllowSpecial.UseVisualStyleBackColor = true;
            this.chkAllowSpecial.CheckedChanged += new System.EventHandler(this.ChkAllowSpecial_CheckedChanged);
            // 
            // chkAllowNumber
            // 
            this.chkAllowNumber.AutoSize = true;
            this.chkAllowNumber.Checked = true;
            this.chkAllowNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowNumber.Location = new System.Drawing.Point(117, 59);
            this.chkAllowNumber.Name = "chkAllowNumber";
            this.chkAllowNumber.Size = new System.Drawing.Size(15, 14);
            this.chkAllowNumber.TabIndex = 4;
            this.chkAllowNumber.UseVisualStyleBackColor = true;
            this.chkAllowNumber.CheckedChanged += new System.EventHandler(this.ChkAllowNumber_CheckedChanged);
            // 
            // chkAllowUppercase
            // 
            this.chkAllowUppercase.AutoSize = true;
            this.chkAllowUppercase.Checked = true;
            this.chkAllowUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowUppercase.Location = new System.Drawing.Point(117, 45);
            this.chkAllowUppercase.Name = "chkAllowUppercase";
            this.chkAllowUppercase.Size = new System.Drawing.Size(15, 14);
            this.chkAllowUppercase.TabIndex = 2;
            this.chkAllowUppercase.UseVisualStyleBackColor = true;
            this.chkAllowUppercase.CheckedChanged += new System.EventHandler(this.ChkAllowUppercase_CheckedChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(145, 13);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(45, 13);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "Needed";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(105, 13);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(44, 13);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Allowed";
            // 
            // chkAllowLowercase
            // 
            this.chkAllowLowercase.AutoSize = true;
            this.chkAllowLowercase.Checked = true;
            this.chkAllowLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowLowercase.Location = new System.Drawing.Point(117, 31);
            this.chkAllowLowercase.Name = "chkAllowLowercase";
            this.chkAllowLowercase.Size = new System.Drawing.Size(15, 14);
            this.chkAllowLowercase.TabIndex = 0;
            this.chkAllowLowercase.UseVisualStyleBackColor = true;
            this.chkAllowLowercase.CheckedChanged += new System.EventHandler(this.ChkAllowLowercase_CheckedChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(8, 101);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 13);
            this.Label8.TabIndex = 5;
            this.Label8.Text = "Speces ( )";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(8, 87);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 13);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Underscore (_)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(8, 73);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(94, 13);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Special sign ($%#)";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 59);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Numbers (123)";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 45);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(89, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Uppercase (ABC)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Lowercase (abc)";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 162);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Button btnGenerate;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkRequireSpace;
        internal System.Windows.Forms.CheckBox chkRequireUnderscore;
        internal System.Windows.Forms.CheckBox chkRequireSpecial;
        internal System.Windows.Forms.CheckBox chkRequireNumber;
        internal System.Windows.Forms.CheckBox chkRequireUppercase;
        internal System.Windows.Forms.CheckBox chkRequireLowercase;
        internal System.Windows.Forms.CheckBox chkAllowSpace;
        internal System.Windows.Forms.CheckBox chkAllowUnderscore;
        internal System.Windows.Forms.CheckBox chkAllowSpecial;
        internal System.Windows.Forms.CheckBox chkAllowNumber;
        internal System.Windows.Forms.CheckBox chkAllowUppercase;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.CheckBox chkAllowLowercase;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtMaxLength;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtMinLength;
        internal System.Windows.Forms.Label Label1;
    }
}

