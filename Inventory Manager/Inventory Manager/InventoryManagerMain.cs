using InventoryItemClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class InventoryManagerMain : Form
    {
        public static List<InventoryItemClass.InventoryItem> list;


        public InventoryManagerMain()
        {
            //This list will store InventoryItem objects from the InventoryItemClass I have created
            list = new List<InventoryItemClass.InventoryItem>();

            InitializeComponent();


            //I have added these instances of InventoryItem class for test purposes so we can test all functionality without
            //having to add in items manually. This will not be in the final project.

            InventoryItem i1 = new InventoryItem("1", "Shirt1", "Polo1", 10, 6.00, 8.00, "Hi", DateTime.Today);
            list.Add(i1);
            InventoryItem i2 = new InventoryItem("2", "Shirt2", "Polo2", 12, 6.00, 8.00, "Hi", DateTime.Today);
            list.Add(i2);
            InventoryItem i3 = new InventoryItem("3", "Shirt3", "Polo3", 15, 6.00, 8.00, "Hi", DateTime.Today);
            list.Add(i3);

            PopulateInventory(list);
        }

        /*
         * This button click event for the add button launches the add item form which allows the user to input the item 
         * details. I have used the f.ShowDialog() so that the next line of code will not execute until the user adds the item.
         * After user adds the the item to inventory, the inventory list will update.
         */
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            f_Add f = new f_Add();
            f.ShowDialog();

            PopulateInventory(list);

        }      

       
        /*
         * This method removes the selected item in the listview from the List<> list and then updates the inventory list effectivly
         * removing the selected item from the entire application.
         */
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            list.RemoveAt(lv_Inventory.SelectedIndices.Count);

            PopulateInventory(list);
          

        }

       
        /*
         * This method updates the lv_Inventory listview with all items found in the list. It is used for many situations like adding,
         * removing, and initial population of the items in the list to the listview lv_Inventory
         */
        private void PopulateInventory(List<InventoryItem> list)
        {
            lv_Inventory.Items.Clear();
            int itemCnt = 0;
            foreach (InventoryItem iI in list)
            {

                ListViewItem lvi = new ListViewItem(list[itemCnt].item_SKU);
                lvi.SubItems.Add(list[itemCnt].item_Type);
                lvi.SubItems.Add(list[itemCnt].item_Name);
                lvi.SubItems.Add(list[itemCnt].item_Quantity.ToString());
                lvi.SubItems.Add(list[itemCnt].item_Purchase_Price.ToString("C", CultureInfo.CurrentCulture));
                lvi.SubItems.Add(list[itemCnt].item_List_Price.ToString("C", CultureInfo.CurrentCulture));
                lvi.SubItems.Add(list[itemCnt].item_List_Date.ToString("d"));

                lv_Inventory.Items.Add(lvi);
                itemCnt++;

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchResult searchResult = new SearchResult();
            searchResult.ShowDialog();

        }
    }
}
