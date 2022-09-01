using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Project
{
    public class InventoryManager
    {
        public void AddItem(string itemName, int qty, string size)
        {
            Form1.ItemList.Add(new Item(itemName, qty, size));
        }

        public void DeleteItem(string name)
        {
            for (int i = 0; i < Form1.ItemList.Count; i++)
            {
                if (Form1.ItemList[i].itemName == name)
                {
                    Form1.ItemList.Remove(Form1.ItemList[i]);
                }
            }
        }

        public void ChangeItemStock(Form1 form, int qty)
        {
            string selectedItem = form.lstbx_inventory.SelectedItem.ToString();
            int index = form.lstbx_inventory.FindString(form.lstbx_inventory.SelectedItem.ToString());

            Form1.ItemList[index].qty = qty;
        }

        public void ItemSearchName(Form1 form, string name)
        {
            for (int i = 0; i < Form1.ItemList.Count; i++)
            {
                if (Form1.ItemList[i].itemName == name)
                {
                    int index = form.lstbx_inventory.FindString(Form1.ItemList[i].itemName);
                    form.lstbx_inventory.SetSelected(index, true);
                }
                else if (Form1.ItemList[i].qty.ToString() == name)
                {
                    int index = form.lstbx_inventory.FindString(Form1.ItemList[i].itemName);
                    form.lstbx_inventory.SetSelected(index, true);
                }
            }
        }

    }
}
