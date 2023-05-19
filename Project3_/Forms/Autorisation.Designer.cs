namespace Project3_
{
    partial class Autorisation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorisation));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEntrance = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelRegistration = new System.Windows.Forms.LinkLabel();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(392, 119);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.BackColor = System.Drawing.Color.White;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.Location = new System.Drawing.Point(36, 135);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(279, 30);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Логин";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(278, 30);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Text = "Пароль";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // buttonEntrance
            // 
            this.buttonEntrance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEntrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.buttonEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEntrance.Location = new System.Drawing.Point(36, 254);
            this.buttonEntrance.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.buttonEntrance.Name = "buttonEntrance";
            this.buttonEntrance.Size = new System.Drawing.Size(280, 39);
            this.buttonEntrance.TabIndex = 2;
            this.buttonEntrance.Text = "Войти";
            this.buttonEntrance.UseVisualStyleBackColor = false;
            this.buttonEntrance.Click += new System.EventHandler(this.buttonEntrance_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxHide, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 194);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // linkLabelRegistration
            // 
            this.linkLabelRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabelRegistration.Location = new System.Drawing.Point(32, 309);
            this.linkLabelRegistration.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linkLabelRegistration.Name = "linkLabelRegistration";
            this.linkLabelRegistration.Size = new System.Drawing.Size(288, 25);
            this.linkLabelRegistration.TabIndex = 3;
            this.linkLabelRegistration.TabStop = true;
            this.linkLabelRegistration.Text = "Зарегистрироваться";
            this.linkLabelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistration_LinkClicked);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxHide.Image = global::Project3_.Properties.Resources.eye_112470;
            this.pictureBoxHide.Location = new System.Drawing.Point(281, 2);
            this.pictureBoxHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(35, 34);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHide.TabIndex = 11;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 351);
            this.Controls.Add(this.linkLabelRegistration);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonEntrance);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(341, 388);
            this.Name = "Autorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Autorisation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEntrance;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabelRegistration;
    }
}

