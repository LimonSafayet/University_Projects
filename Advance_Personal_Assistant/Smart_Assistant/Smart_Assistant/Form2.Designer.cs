﻿namespace Smart_Assistant
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.textEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textRPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backup = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DOB = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.White;
            this.textEmail.HintForeColor = System.Drawing.Color.White;
            this.textEmail.HintText = "Email";
            this.textEmail.isPassword = false;
            this.textEmail.LineFocusedColor = System.Drawing.Color.White;
            this.textEmail.LineIdleColor = System.Drawing.Color.White;
            this.textEmail.LineMouseHoverColor = System.Drawing.Color.White;
            this.textEmail.LineThickness = 3;
            this.textEmail.Location = new System.Drawing.Point(254, 212);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(431, 51);
            this.textEmail.TabIndex = 1;
            this.textEmail.TabStop = false;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textEmail.OnValueChanged += new System.EventHandler(this.textEmail_OnValueChanged);
            this.textEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEmail_KeyDown);
            // 
            // textPassword
            // 
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.White;
            this.textPassword.HintForeColor = System.Drawing.Color.White;
            this.textPassword.HintText = "Password";
            this.textPassword.isPassword = false;
            this.textPassword.LineFocusedColor = System.Drawing.Color.White;
            this.textPassword.LineIdleColor = System.Drawing.Color.White;
            this.textPassword.LineMouseHoverColor = System.Drawing.Color.White;
            this.textPassword.LineThickness = 3;
            this.textPassword.Location = new System.Drawing.Point(254, 271);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(431, 51);
            this.textPassword.TabIndex = 2;
            this.textPassword.TabStop = false;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassword_KeyDown);
            // 
            // textName
            // 
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.HintForeColor = System.Drawing.Color.White;
            this.textName.HintText = "User Name";
            this.textName.isPassword = false;
            this.textName.LineFocusedColor = System.Drawing.Color.White;
            this.textName.LineIdleColor = System.Drawing.Color.White;
            this.textName.LineMouseHoverColor = System.Drawing.Color.White;
            this.textName.LineThickness = 3;
            this.textName.Location = new System.Drawing.Point(254, 153);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(431, 51);
            this.textName.TabIndex = 0;
            this.textName.TabStop = false;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textName.OnValueChanged += new System.EventHandler(this.textName_OnValueChanged);
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textRPassword
            // 
            this.textRPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRPassword.ForeColor = System.Drawing.Color.White;
            this.textRPassword.HintForeColor = System.Drawing.Color.White;
            this.textRPassword.HintText = "Re-Enter Password";
            this.textRPassword.isPassword = false;
            this.textRPassword.LineFocusedColor = System.Drawing.Color.White;
            this.textRPassword.LineIdleColor = System.Drawing.Color.White;
            this.textRPassword.LineMouseHoverColor = System.Drawing.Color.White;
            this.textRPassword.LineThickness = 3;
            this.textRPassword.Location = new System.Drawing.Point(254, 330);
            this.textRPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textRPassword.Name = "textRPassword";
            this.textRPassword.Size = new System.Drawing.Size(431, 51);
            this.textRPassword.TabIndex = 3;
            this.textRPassword.TabStop = false;
            this.textRPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textRPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            this.textRPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textRPassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(952, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(920, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "_";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(390, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "SignUp";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(306, 535);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(340, 58);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(346, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "LogIn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(505, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cancel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backup
            // 
            this.backup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.backup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup.ForeColor = System.Drawing.Color.White;
            this.backup.HintForeColor = System.Drawing.Color.White;
            this.backup.HintText = "Backup Pin";
            this.backup.isPassword = false;
            this.backup.LineFocusedColor = System.Drawing.Color.White;
            this.backup.LineIdleColor = System.Drawing.Color.White;
            this.backup.LineMouseHoverColor = System.Drawing.Color.White;
            this.backup.LineThickness = 3;
            this.backup.Location = new System.Drawing.Point(254, 389);
            this.backup.Margin = new System.Windows.Forms.Padding(4);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(431, 51);
            this.backup.TabIndex = 4;
            this.backup.TabStop = false;
            this.backup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backup.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(256, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of Birth";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(414, 502);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 26);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Show Rules";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(694, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(290, 370);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "1. User name must contain at least 6 character.\n\n2. Email will be like [email@exa" +
    "mple.com]\n\n3. Password must contain at least 8 character.\n\n4. Backup pin must co" +
    "ntain 6 number.";
            this.richTextBox1.Visible = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // DOB
            // 
            this.DOB.BackColor = System.Drawing.Color.Crimson;
            this.DOB.BorderRadius = 0;
            this.DOB.ForeColor = System.Drawing.Color.White;
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.FormatCustom = null;
            this.DOB.Location = new System.Drawing.Point(433, 455);
            this.DOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(252, 29);
            this.DOB.TabIndex = 5;
            this.DOB.Value = new System.DateTime(2018, 4, 28, 12, 30, 38, 879);
            this.DOB.onValueChanged += new System.EventHandler(this.DOB_onValueChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(996, 686);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox textEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textRPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox backup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuDatepicker DOB;


    }
}