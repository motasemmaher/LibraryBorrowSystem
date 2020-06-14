namespace LibraryBorrowSystem.View
{
    partial class RemoveItemControl
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
            this.removeBtn = new System.Windows.Forms.Button();
            this.itemIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgText
            // 
            this.msgText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msgText.Location = new System.Drawing.Point(98, 143);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(273, 64);
            this.msgText.TabIndex = 33;
            this.msgText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeBtn.Location = new System.Drawing.Point(283, 93);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(88, 44);
            this.removeBtn.TabIndex = 32;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // itemIdTB
            // 
            this.itemIdTB.BackColor = System.Drawing.Color.LightGray;
            this.itemIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemIdTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdTB.Location = new System.Drawing.Point(192, 48);
            this.itemIdTB.Name = "itemIdTB";
            this.itemIdTB.Size = new System.Drawing.Size(179, 19);
            this.itemIdTB.TabIndex = 31;
            this.itemIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Item ID";
            // 
            // RemoveItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.itemIdTB);
            this.Controls.Add(this.label1);
            this.Name = "RemoveItemControl";
            this.Size = new System.Drawing.Size(869, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox itemIdTB;
        private System.Windows.Forms.Label label1;
    }
}
