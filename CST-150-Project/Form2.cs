using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Project
{
    using static Form1;
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

            Form1 form = (Form1)this.Owner;

            form.DisplayInventory();
        }

        private void btn2_Add_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.Owner;
            form.inventoryManager.AddItem(tbx_ItemName.Text, int.Parse(tbx_Qty.Text), tbx_Size.Text);
            form.DisplayInventory();
        }
    }
}
