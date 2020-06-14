namespace LibraryBorrowSystem.View
{
    partial class EditTimeoutsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notretNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.overdueNumeric = new System.Windows.Forms.NumericUpDown();
            this.msgText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notretNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // resNumeric
            // 
            this.resNumeric.BackColor = System.Drawing.Color.LightGray;
            this.resNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resNumeric.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resNumeric.Location = new System.Drawing.Point(232, 60);
            this.resNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.resNumeric.Name = "resNumeric";
            this.resNumeric.Size = new System.Drawing.Size(112, 22);
            this.resNumeric.TabIndex = 25;
            this.resNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resNumeric.ThousandsSeparator = true;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveBtn.Location = new System.Drawing.Point(308, 231);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 44);
            this.saveBtn.TabIndex = 24;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reservation timeout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Not returned timeout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "hours";
            // 
            // notretNumeric
            // 
            this.notretNumeric.BackColor = System.Drawing.Color.LightGray;
            this.notretNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notretNumeric.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notretNumeric.Location = new System.Drawing.Point(232, 110);
            this.notretNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.notretNumeric.Name = "notretNumeric";
            this.notretNumeric.Size = new System.Drawing.Size(112, 22);
            this.notretNumeric.TabIndex = 25;
            this.notretNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notretNumeric.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Overdue timeout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "hours";
            // 
            // overdueNumeric
            // 
            this.overdueNumeric.BackColor = System.Drawing.Color.LightGray;
            this.overdueNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overdueNumeric.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueNumeric.Location = new System.Drawing.Point(232, 160);
            this.overdueNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.overdueNumeric.Name = "overdueNumeric";
            this.overdueNumeric.Size = new System.Drawing.Size(112, 22);
            this.overdueNumeric.TabIndex = 25;
            this.overdueNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.overdueNumeric.ThousandsSeparator = true;
            // 
            // msgText
            // 
            this.msgText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msgText.Location = new System.Drawing.Point(123, 281);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(273, 64);
            this.msgText.TabIndex = 30;
            this.msgText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditTimeoutsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.overdueNumeric);
            this.Controls.Add(this.notretNumeric);
            this.Controls.Add(this.resNumeric);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "EditTimeoutsControl";
            this.Size = new System.Drawing.Size(869, 444);
            ((System.ComponentModel.ISupportInitialize)(this.resNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notretNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown resNumeric;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown notretNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown overdueNumeric;
        private System.Windows.Forms.Label msgText;
    }
}
