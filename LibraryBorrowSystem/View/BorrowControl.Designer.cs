namespace LibraryBorrowSystem.View
{
    partial class BorrowControl
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
            this.borrowerIdTB = new System.Windows.Forms.TextBox();
            this.itemIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.msgText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // borrowerIdTB
            // 
            this.borrowerIdTB.BackColor = System.Drawing.Color.LightGray;
            this.borrowerIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerIdTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerIdTB.Location = new System.Drawing.Point(192, 78);
            this.borrowerIdTB.Name = "borrowerIdTB";
            this.borrowerIdTB.Size = new System.Drawing.Size(179, 19);
            this.borrowerIdTB.TabIndex = 0;
            this.borrowerIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemIdTB
            // 
            this.itemIdTB.BackColor = System.Drawing.Color.LightGray;
            this.itemIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemIdTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdTB.Location = new System.Drawing.Point(192, 123);
            this.itemIdTB.Name = "itemIdTB";
            this.itemIdTB.Size = new System.Drawing.Size(179, 19);
            this.itemIdTB.TabIndex = 0;
            this.itemIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrower ID";
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.borrowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowBtn.FlatAppearance.BorderSize = 0;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.borrowBtn.Location = new System.Drawing.Point(283, 170);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(88, 44);
            this.borrowBtn.TabIndex = 3;
            this.borrowBtn.Text = "Borrow";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // msgText
            // 
            this.msgText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msgText.Location = new System.Drawing.Point(98, 220);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(273, 64);
            this.msgText.TabIndex = 4;
            this.msgText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BorrowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemIdTB);
            this.Controls.Add(this.borrowerIdTB);
            this.Name = "BorrowControl";
            this.Size = new System.Drawing.Size(869, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox borrowerIdTB;
        private System.Windows.Forms.TextBox itemIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Label msgText;
    }
}
