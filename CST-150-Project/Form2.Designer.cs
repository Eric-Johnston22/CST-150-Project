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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_ItemName = new System.Windows.Forms.TextBox();
            this.lbl_order = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Size
            // 
            this.tbx_Size.Location = new System.Drawing.Point(196, 141);
            this.tbx_Size.Name = "tbx_Size";
            this.tbx_Size.Size = new System.Drawing.Size(130, 20);
            this.tbx_Size.TabIndex = 27;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(92, 141);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(46, 24);
            this.lbl_Size.TabIndex = 26;
            this.lbl_Size.Text = "Size";
            // 
            // btn2_Add
            // 
            this.btn2_Add.Location = new System.Drawing.Point(196, 176);
            this.btn2_Add.Name = "btn2_Add";
            this.btn2_Add.Size = new System.Drawing.Size(130, 47);
            this.btn2_Add.TabIndex = 25;
            this.btn2_Add.Text = "Add Item";
            this.btn2_Add.UseVisualStyleBackColor = true;
            this.btn2_Add.Click += new System.EventHandler(this.btn2_Add_Click);
            // 
            // lbl_Add_Qty
            // 
            this.lbl_Add_Qty.AutoSize = true;
            this.lbl_Add_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Qty.Location = new System.Drawing.Point(92, 111);
            this.lbl_Add_Qty.Name = "lbl_Add_Qty";
            this.lbl_Add_Qty.Size = new System.Drawing.Size(78, 24);
            this.lbl_Add_Qty.TabIndex = 23;
            this.lbl_Add_Qty.Text = "Quantity";
            // 
            // tbx_Qty
            // 
            this.tbx_Qty.Location = new System.Drawing.Point(196, 115);
            this.tbx_Qty.Name = "tbx_Qty";
            this.tbx_Qty.Size = new System.Drawing.Size(130, 20);
            this.tbx_Qty.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item name";
            // 
            // tbx_ItemName
            // 
            this.tbx_ItemName.Location = new System.Drawing.Point(196, 89);
            this.tbx_ItemName.Name = "tbx_ItemName";
            this.tbx_ItemName.Size = new System.Drawing.Size(130, 20);
            this.tbx_ItemName.TabIndex = 19;
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order.Location = new System.Drawing.Point(132, 24);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(230, 36);
            this.lbl_order.TabIndex = 28;
            this.lbl_order.Text = "Order new items";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 303);
            this.Controls.Add(this.lbl_order);
            this.Controls.Add(this.tbx_Size);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.btn2_Add);
            this.Controls.Add(this.lbl_Add_Qty);
            this.Controls.Add(this.tbx_Qty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_ItemName);
            this.Name = "Form2";
            this.Text = "Orders";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_ItemName;
        private System.Windows.Forms.Label lbl_order;
    }
}