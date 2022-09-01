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

        public static List<Item> ItemList = new List<Item>();
        public InventoryManager inventoryManager = new InventoryManager();

        // Display items in inventory
        public void DisplayInventory()
        {
            lstbx_inventory.Items.Clear();
            for (int i = 0; i < ItemList.Count; i++)
            {
                lstbx_inventory.Items.Add(ItemList[i].itemName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Starting inventory
            inventoryManager.AddItem("Hiking shoe", 7, "9");
            inventoryManager.AddItem("Tent", 3, "2 person");
            inventoryManager.AddItem("Pants", 5, "large");
            inventoryManager.AddItem("Backpack", 12, "medium");

            // Display item names to list box
            DisplayInventory();

            lstbx_inventory.SelectedIndexChanged += new System.EventHandler(lstbx_inventory_SelectedIndexChanged);
            tbx_search.TextChanged += new System.EventHandler(tbx_search_TextChangedName);
        }

        private void btn_delete_item_Click(object sender, EventArgs e)
        {
            inventoryManager.DeleteItem(lstbx_inventory.SelectedItem.ToString());

            DisplayInventory();
        }

        private void lstbx_inventory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedItem = lstbx_inventory.SelectedItem.ToString();
            int index = lstbx_inventory.FindString(selectedItem);

            // Display selected item's current stock
            numericUpDown1.Value = ItemList[index].qty;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            inventoryManager.ChangeItemStock(this, count);

        }

        void tbx_search_TextChangedName(object sender, System.EventArgs e)
        {
            string text = tbx_search.Text;
            inventoryManager.ItemSearchName(this, text);
        }

        private void btn_change_form_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show(this);
            // When results form is closed, show Form1
            form2 = null;
            this.Show();
        }
    }
}
