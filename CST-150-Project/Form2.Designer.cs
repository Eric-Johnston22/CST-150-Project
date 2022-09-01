namespace CST_150_Project
{
    partial class Form2
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
        public void InitializeComponent()
        {
            this.tbx_Size = new System.Windows.Forms.TextBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.btn2_Add = new System.Windows.Forms.Button();
            this.lbl_Add_Qty = new System.Windows.Forms.Label();
            this.tbx_Qty = new System.Windows.Forms.TextBox();
            this.lbl_current_stock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_ItemName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_Size
            // 
            this.tbx_Size.Location = new System.Drawing.Point(344, 340);
            this.tbx_Size.Name = "tbx_Size";
            this.tbx_Size.Size = new System.Drawing.Size(100, 20);
            this.tbx_Size.TabIndex = 27;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Location = new System.Drawing.Point(282, 340);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(27, 13);
            this.lbl_Size.TabIndex = 26;
            this.lbl_Size.Text = "Size";
            // 
            // btn2_Add
            // 
            this.btn2_Add.Location = new System.Drawing.Point(344, 366);
            this.btn2_Add.Name = "btn2_Add";
            this.btn2_Add.Size = new System.Drawing.Size(100, 23);
            this.btn2_Add.TabIndex = 25;
            this.btn2_Add.Text = "Add Item";
            this.btn2_Add.UseVisualStyleBackColor = true;
            this.btn2_Add.Click += new System.EventHandler(this.btn2_Add_Click);
            // 
            // lbl_Add_Qty
            // 
            this.lbl_Add_Qty.AutoSize = true;
            this.lbl_Add_Qty.Location = new System.Drawing.Point(282, 315);
            this.lbl_Add_Qty.Name = "lbl_Add_Qty";
            this.lbl_Add_Qty.Size = new System.Drawing.Size(46, 13);
            this.lbl_Add_Qty.TabIndex = 23;
            this.lbl_Add_Qty.Text = "Quantity";
            // 
            // tbx_Qty
            // 
            this.tbx_Qty.Location = new System.Drawing.Point(344, 315);
            this.tbx_Qty.Name = "tbx_Qty";
            this.tbx_Qty.Size = new System.Drawing.Size(100, 20);
            this.tbx_Qty.TabIndex = 22;
            // 
            // lbl_current_stock
            // 
            this.lbl_current_stock.AutoSize = true;
            this.lbl_current_stock.Location = new System.Drawing.Point(354, 263);
            this.lbl_current_stock.Name = "lbl_current_stock";
            this.lbl_current_stock.Size = new System.Drawing.Size(76, 13);
            this.lbl_current_stock.TabIndex = 21;
            this.lbl_current_stock.Text = "Current stock: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item name";
            // 
            // tbx_ItemName
            // 
            this.tbx_ItemName.Location = new System.Drawing.Point(344, 289);
            this.tbx_ItemName.Name = "tbx_ItemName";
            this.tbx_ItemName.Size = new System.Drawing.Size(100, 20);
            this.tbx_ItemName.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_Size);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.btn2_Add);
            this.Controls.Add(this.lbl_Add_Qty);
            this.Controls.Add(this.tbx_Qty);
            this.Controls.Add(this.lbl_current_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_ItemName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Size;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Button btn2_Add;
        private System.Windows.Forms.Label lbl_Add_Qty;
        private System.Windows.Forms.TextBox tbx_Qty;
        private System.Windows.Forms.Label lbl_current_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_ItemName;
    }
}