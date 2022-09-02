namespace CST_150_Project
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstbx_inventory = new System.Windows.Forms.ListBox();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.lbl_current_stock = new System.Windows.Forms.Label();
            this.btn_delete_item = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_change_form = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbx_inventory
            // 
            this.lstbx_inventory.FormattingEnabled = true;
            this.lstbx_inventory.Location = new System.Drawing.Point(275, 123);
            this.lstbx_inventory.Name = "lstbx_inventory";
            this.lstbx_inventory.Size = new System.Drawing.Size(238, 277);
            this.lstbx_inventory.TabIndex = 1;
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(346, 88);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(100, 20);
            this.tbx_search.TabIndex = 2;
            // 
            // lbl_current_stock
            // 
            this.lbl_current_stock.Location = new System.Drawing.Point(292, 403);
            this.lbl_current_stock.Name = "lbl_current_stock";
            this.lbl_current_stock.Size = new System.Drawing.Size(76, 19);
            this.lbl_current_stock.TabIndex = 9;
            this.lbl_current_stock.Text = "Current stock: ";
            // 
            // btn_delete_item
            // 
            this.btn_delete_item.Location = new System.Drawing.Point(528, 248);
            this.btn_delete_item.Name = "btn_delete_item";
            this.btn_delete_item.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_item.TabIndex = 13;
            this.btn_delete_item.Text = "Delete item";
            this.btn_delete_item.UseVisualStyleBackColor = true;
            this.btn_delete_item.Click += new System.EventHandler(this.btn_delete_item_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(341, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(109, 29);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "Inventory";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Search.Location = new System.Drawing.Point(326, 72);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(136, 13);
            this.lbl_Search.TabIndex = 18;
            this.lbl_Search.Text = "Search by name or quantity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(374, 403);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_change_form
            // 
            this.btn_change_form.Location = new System.Drawing.Point(322, 461);
            this.btn_change_form.Name = "btn_change_form";
            this.btn_change_form.Size = new System.Drawing.Size(140, 55);
            this.btn_change_form.TabIndex = 20;
            this.btn_change_form.Text = "Order Form";
            this.btn_change_form.UseVisualStyleBackColor = true;
            this.btn_change_form.Click += new System.EventHandler(this.btn_change_form_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btn_change_form);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_delete_item);
            this.Controls.Add(this.lbl_current_stock);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.lstbx_inventory);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox lstbx_inventory;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Label lbl_current_stock;
        private System.Windows.Forms.Button btn_delete_item;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_change_form;
    }
}

