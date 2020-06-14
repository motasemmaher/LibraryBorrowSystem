namespace LibraryBorrowSystem.View
{
    partial class AddBorrowerControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.teacherRB = new System.Windows.Forms.RadioButton();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.msgText = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.borrowerNameTB = new System.Windows.Forms.TextBox();
            this.borrowerIdTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowerEmailTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Borrower ID";
            // 
            // teacherRB
            // 
            this.teacherRB.AutoSize = true;
            this.teacherRB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRB.Location = new System.Drawing.Point(299, 114);
            this.teacherRB.Name = "teacherRB";
            this.teacherRB.Size = new System.Drawing.Size(71, 20);
            this.teacherRB.TabIndex = 30;
            this.teacherRB.Text = "Teacher";
            this.teacherRB.UseVisualStyleBackColor = true;
            // 
            // studentRB
            // 
            this.studentRB.AutoSize = true;
            this.studentRB.Checked = true;
            this.studentRB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRB.Location = new System.Drawing.Point(222, 114);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(71, 20);
            this.studentRB.TabIndex = 31;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "Student";
            this.studentRB.UseVisualStyleBackColor = true;
            // 
            // msgText
            // 
            this.msgText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msgText.Location = new System.Drawing.Point(98, 248);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(273, 64);
            this.msgText.TabIndex = 29;
            this.msgText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addBtn.Location = new System.Drawing.Point(283, 198);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 44);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // borrowerNameTB
            // 
            this.borrowerNameTB.BackColor = System.Drawing.Color.LightGray;
            this.borrowerNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerNameTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerNameTB.Location = new System.Drawing.Point(192, 83);
            this.borrowerNameTB.Name = "borrowerNameTB";
            this.borrowerNameTB.Size = new System.Drawing.Size(179, 19);
            this.borrowerNameTB.TabIndex = 26;
            this.borrowerNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // borrowerIdTB
            // 
            this.borrowerIdTB.BackColor = System.Drawing.Color.LightGray;
            this.borrowerIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerIdTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerIdTB.Location = new System.Drawing.Point(192, 48);
            this.borrowerIdTB.Name = "borrowerIdTB";
            this.borrowerIdTB.Size = new System.Drawing.Size(179, 19);
            this.borrowerIdTB.TabIndex = 27;
            this.borrowerIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Borrower type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Borrower name";
            // 
            // borrowerEmailTB
            // 
            this.borrowerEmailTB.BackColor = System.Drawing.Color.LightGray;
            this.borrowerEmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerEmailTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerEmailTB.Location = new System.Drawing.Point(192, 150);
            this.borrowerEmailTB.Name = "borrowerEmailTB";
            this.borrowerEmailTB.Size = new System.Drawing.Size(179, 19);
            this.borrowerEmailTB.TabIndex = 26;
            this.borrowerEmailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddBorrowerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teacherRB);
            this.Controls.Add(this.studentRB);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.borrowerEmailTB);
            this.Controls.Add(this.borrowerNameTB);
            this.Controls.Add(this.borrowerIdTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBorrowerControl";
            this.Size = new System.Drawing.Size(869, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton teacherRB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox borrowerNameTB;
        private System.Windows.Forms.TextBox borrowerIdTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox borrowerEmailTB;
    }
}
