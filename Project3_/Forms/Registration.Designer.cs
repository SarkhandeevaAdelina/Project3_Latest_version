namespace Project3_
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswod = new System.Windows.Forms.TextBox();
            this.textBoxSecondPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.buttonRegestration = new System.Windows.Forms.Button();
            this.linkLabelAutorization = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 119);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(23, 135);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxEmail.MaxLength = 30;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(279, 30);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.Location = new System.Drawing.Point(23, 194);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxLogin.MaxLength = 30;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(279, 30);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Логин";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPasswod
            // 
            this.textBoxPasswod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPasswod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPasswod.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswod.Location = new System.Drawing.Point(23, 254);
            this.textBoxPasswod.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxPasswod.MaxLength = 30;
            this.textBoxPasswod.Name = "textBoxPasswod";
            this.textBoxPasswod.Size = new System.Drawing.Size(279, 30);
            this.textBoxPasswod.TabIndex = 2;
            this.textBoxPasswod.Text = "Пароль";
            this.textBoxPasswod.Enter += new System.EventHandler(this.textBoxPasswod_Enter);
            this.textBoxPasswod.Leave += new System.EventHandler(this.textBoxPasswod_Leave);
            // 
            // textBoxSecondPassword
            // 
            this.textBoxSecondPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSecondPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSecondPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSecondPassword.Location = new System.Drawing.Point(23, 313);
            this.textBoxSecondPassword.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxSecondPassword.MaxLength = 30;
            this.textBoxSecondPassword.Name = "textBoxSecondPassword";
            this.textBoxSecondPassword.Size = new System.Drawing.Size(279, 30);
            this.textBoxSecondPassword.TabIndex = 3;
            this.textBoxSecondPassword.Text = "Повторите пароль";
            this.textBoxSecondPassword.Enter += new System.EventHandler(this.textBoxSecondPassword_Enter);
            this.textBoxSecondPassword.Leave += new System.EventHandler(this.textBoxSecondPassword_Leave);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstName.Location = new System.Drawing.Point(23, 431);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxFirstName.MaxLength = 30;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(279, 30);
            this.textBoxFirstName.TabIndex = 5;
            this.textBoxFirstName.Text = "Имя";
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSecondName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSecondName.Location = new System.Drawing.Point(23, 372);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxSecondName.MaxLength = 30;
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(279, 30);
            this.textBoxSecondName.TabIndex = 4;
            this.textBoxSecondName.Text = "Фамилия";
            this.textBoxSecondName.Enter += new System.EventHandler(this.textBoxSurename_Enter);
            this.textBoxSecondName.Leave += new System.EventHandler(this.textBoxSurename_Leave);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPatronymic.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPatronymic.Location = new System.Drawing.Point(23, 490);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxPatronymic.MaxLength = 30;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(279, 30);
            this.textBoxPatronymic.TabIndex = 6;
            this.textBoxPatronymic.Text = "Отчество (если есть)";
            this.textBoxPatronymic.Enter += new System.EventHandler(this.textBoxFathername_Enter);
            this.textBoxPatronymic.Leave += new System.EventHandler(this.textBoxFathername_Leave);
            // 
            // buttonRegestration
            // 
            this.buttonRegestration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegestration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.buttonRegestration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegestration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegestration.Location = new System.Drawing.Point(23, 549);
            this.buttonRegestration.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.buttonRegestration.Name = "buttonRegestration";
            this.buttonRegestration.Size = new System.Drawing.Size(280, 39);
            this.buttonRegestration.TabIndex = 7;
            this.buttonRegestration.Text = "Зарегистрироваться";
            this.buttonRegestration.UseVisualStyleBackColor = false;
            this.buttonRegestration.Click += new System.EventHandler(this.buttonRegestration_Click);
            // 
            // linkLabelAutorization
            // 
            this.linkLabelAutorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelAutorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabelAutorization.Location = new System.Drawing.Point(19, 604);
            this.linkLabelAutorization.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linkLabelAutorization.Name = "linkLabelAutorization";
            this.linkLabelAutorization.Size = new System.Drawing.Size(288, 28);
            this.linkLabelAutorization.TabIndex = 8;
            this.linkLabelAutorization.TabStop = true;
            this.linkLabelAutorization.Text = "Войти";
            this.linkLabelAutorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelAutorization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAutorization_LinkClicked);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(325, 649);
            this.Controls.Add(this.linkLabelAutorization);
            this.Controls.Add(this.buttonRegestration);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSecondPassword);
            this.Controls.Add(this.textBoxPasswod);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(341, 686);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPasswod;
        private System.Windows.Forms.TextBox textBoxSecondPassword;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Button buttonRegestration;
        private System.Windows.Forms.LinkLabel linkLabelAutorization;
    }
}