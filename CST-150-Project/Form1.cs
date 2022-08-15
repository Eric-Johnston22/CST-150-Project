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

        // Parent item class
        abstract class Item
        {
            public string itemName;
            public int qty;

            // Return item type
            public abstract string getType();
            
            // Constructor with parameters
            public Item(string itemName, int qty)
            {
                this.itemName = itemName;
                this.qty = qty;
            }
        }

        class Footwear : Item
        {
            public string type;
            public double size;


            // Constructor with parameters
            public Footwear (string itemName, int qty, string type, double size) : base (itemName, qty)
            {
                this.type = type;
                this.size = size;
            }

            // Return item type
            public override string getType()
            {
                return type;
            }
        }

        class Softgoods : Item
        {
            public string type;
            public string size;

            // Constructor with parameters
            public Softgoods (string itemName, int qty, string type, string size) : base(itemName, qty)
            {
                this.type = type;
                this.size = size;
            }

            // Return item type
            public override string getType()
            {
                return type;
            }
        }

        class Hardgoods : Item
        {
            public string type;
            public double size;

            // Constructor with parameters
            public Hardgoods (string itemName, int qty, string type, double size) : base(itemName, qty)
            {
                this.type = type;
                this.size = size;
            }

            // Return item type
            public override string getType()
            {
                return type;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create list of items
            List<Item> ItemList = new List<Item>();

            // Create item objects and add to list
            ItemList.Add(new Footwear("Hiking shoe", 3, "shoe", 9));
            ItemList.Add(new Footwear("Hiking boot", 2, "boot", 10));
            ItemList.Add(new Softgoods("Shirt", 8, "shirt", "medium"));
            ItemList.Add(new Softgoods("Pants", 5, "pants", "large"));
            ItemList.Add(new Hardgoods("Tent", 3, "3 season", 2));
            
            // Display item names to list box
            for (int i = 0; i < ItemList.Count; i++)
            {
                lstbx_inventory.Items.Add(ItemList[i].itemName);
            }
        }
    }
}
