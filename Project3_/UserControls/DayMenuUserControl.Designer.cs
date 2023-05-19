namespace Project3_.UserControls
{
    partial class DayMenuUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDayWeek = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDinner = new System.Windows.Forms.Label();
            this.labelLunch = new System.Windows.Forms.Label();
            this.labelBreakfast = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelDayWeek, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // labelDayWeek
            // 
            this.labelDayWeek.AutoSize = true;
            this.labelDayWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDayWeek.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.labelDayWeek.Location = new System.Drawing.Point(12, 6);
            this.labelDayWeek.Margin = new System.Windows.Forms.Padding(12, 6, 12, 2);
            this.labelDayWeek.Name = "labelDayWeek";
            this.labelDayWeek.Size = new System.Drawing.Size(436, 22);
            this.labelDayWeek.TabIndex = 0;
            this.labelDayWeek.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelDinner, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelLunch, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelBreakfast, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelKal, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 114);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // labelDinner
            // 
            this.labelDinner.AutoSize = true;
            this.labelDinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDinner.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.labelDinner.Location = new System.Drawing.Point(123, 56);
            this.labelDinner.Name = "labelDinner";
            this.labelDinner.Size = new System.Drawing.Size(328, 28);
            this.labelDinner.TabIndex = 5;
            this.labelDinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDinner.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // labelLunch
            // 
            this.labelLunch.AutoSize = true;
            this.labelLunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLunch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.labelLunch.Location = new System.Drawing.Point(123, 28);
            this.labelLunch.Name = "labelLunch";
            this.labelLunch.Size = new System.Drawing.Size(328, 28);
            this.labelLunch.TabIndex = 4;
            this.labelLunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLunch.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // labelBreakfast
            // 
            this.labelBreakfast.AutoSize = true;
            this.labelBreakfast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBreakfast.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBreakfast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.labelBreakfast.Location = new System.Drawing.Point(123, 0);
            this.labelBreakfast.Name = "labelBreakfast";
            this.labelBreakfast.Size = new System.Drawing.Size(328, 28);
            this.labelBreakfast.TabIndex = 3;
            this.labelBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBreakfast.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ужин";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Обед";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Завтрак";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // labelKal
            // 
            this.labelKal.AutoSize = true;
            this.labelKal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKal.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.labelKal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.labelKal.Location = new System.Drawing.Point(123, 84);
            this.labelKal.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.labelKal.Name = "labelKal";
            this.labelKal.Size = new System.Drawing.Size(311, 30);
            this.labelKal.TabIndex = 6;
            this.labelKal.Text = "Калории";
            this.labelKal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKal.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 154);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.OpenDayMenuInfo_Click);
            // 
            // DayMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "DayMenuUserControl";
            this.Size = new System.Drawing.Size(480, 170);
            this.Load += new System.EventHandler(this.DayMenuUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDayWeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelDinner;
        private System.Windows.Forms.Label labelLunch;
        private System.Windows.Forms.Label labelBreakfast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKal;
        private System.Windows.Forms.Panel panel1;
    }
}
