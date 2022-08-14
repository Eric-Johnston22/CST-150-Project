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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Item
        {
            public string itemName;
            public int qty;

            public Item(string a, int b)
            {
                itemName = a;
                qty = b;
            }
        }

        class Footwear : Item
        {
            public string type;
            public double size;

            public Footwear (string a, int b, string c, double d) : base (a, b)
            {
                type = c;
                size = d;
            }
        }

        class Softgoods : Item
        {
            public string type;
            public double size;

            public Softgoods (string a, int b, string c, double d) : base (a, b)
            {
                type = c;
                size = d;
            }
        }

        class Hardgoods : Item
        {
            public string type;
            public double size;

            public Hardgoods (string a, int b, string c, double d) : base (a, b)
            {
                type = c;
                size = d;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Footwear shoe = new Footwear("shoe", 16, "north face", 9.5);
            Footwear boot = new Footwear("boot", 13, "lowa", 10);
            Hardgoods tent = new Hardgoods("tent", 7, "3 season", 2);

            lstbx_inventory.Items.Add(shoe.itemName);
            lstbx_inventory.Items.Add(boot.itemName);
            lstbx_inventory.Items.Add(tent.type);

            List<string> inventoryList = new List<string>();
        }
    }
}
