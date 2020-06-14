namespace LibraryBorrowSystem.View
{
    partial class AddItemControl
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
            this.msgText = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameTB = new System.Windows.Forms.TextBox();
            this.itemIdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookRB = new System.Windows.Forms.RadioButton();
            this.cdRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // msgText
            // 
            this.msgText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msgText.Location = new System.Drawing.Point(98, 248);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(273, 64);
            this.msgText.TabIndex = 20;
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
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Item ID";
            // 
            // itemNameTB
            // 
            this.itemNameTB.BackColor = System.Drawing.Color.LightGray;
            this.itemNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemNameTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTB.Location = new System.Drawing.Point(192, 82);
            this.itemNameTB.Name = "itemNameTB";
            this.itemNameTB.Size = new System.Drawing.Size(179, 19);
            this.itemNameTB.TabIndex = 16;
            this.itemNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemIdTB
            // 
            this.itemIdTB.BackColor = System.Drawing.Color.LightGray;
            this.itemIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemIdTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdTB.Location = new System.Drawing.Point(192, 48);
            this.itemIdTB.Name = "itemIdTB";
            this.itemIdTB.Size = new System.Drawing.Size(179, 19);
            this.itemIdTB.TabIndex = 17;
            this.itemIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Item name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Item category";
            // 
            // bookRB
            // 
            this.bookRB.AutoSize = true;
            this.bookRB.Checked = true;
            this.bookRB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRB.Location = new System.Drawing.Point(222, 116);
            this.bookRB.Name = "bookRB";
            this.bookRB.Size = new System.Drawing.Size(56, 20);
            this.bookRB.TabIndex = 21;
            this.bookRB.TabStop = true;
            this.bookRB.Text = "Book";
            this.bookRB.UseVisualStyleBackColor = true;
            // 
            // cdRB
            // 
            this.cdRB.AutoSize = true;
            this.cdRB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdRB.Location = new System.Drawing.Point(284, 116);
            this.cdRB.Name = "cdRB";
            this.cdRB.Size = new System.Drawing.Size(44, 20);
            this.cdRB.TabIndex = 21;
            this.cdRB.Text = "CD";
            this.cdRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Item price";
            // 
            // priceNumeric
            // 
            this.priceNumeric.BackColor = System.Drawing.Color.LightGray;
            this.priceNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceNumeric.DecimalPlaces = 2;
            this.priceNumeric.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumeric.Location = new System.Drawing.Point(192, 153);
            this.priceNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(179, 18);
            this.priceNumeric.TabIndex = 22;
            this.priceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceNumeric.ThousandsSeparator = true;
            // 
            // AddItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.cdRB);
            this.Controls.Add(this.bookRB);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNameTB);
            this.Controls.Add(this.itemIdTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "AddItemControl";
            this.Size = new System.Drawing.Size(869, 444);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNameTB;
        private System.Windows.Forms.TextBox itemIdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton bookRB;
        private System.Windows.Forms.RadioButton cdRB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown priceNumeric;
    }
}
