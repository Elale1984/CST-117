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
        public static List<InventoryItem> list;
        public static List<InventoryItem> soldList;

        public static InventoryItem soldItem;
        public static InventoryItem editSelectedItem;
        public static int restockAMT = 0;

        public InventoryManagerMain()
        {
            //This list will store InventoryItem objects from the InventoryItemClass I have created
            list = new List<InventoryItemClass.InventoryItem>();

            InitializeComponent();


            //I have added these instances of InventoryItem class for test purposes so we can test all functionality without
            //having to add in items manually. This will not be in the final project.

            InventoryItem i1 = new InventoryItem("1", "Shirt", "Polo", 10, 12.00, 55.00, DateTime.Today);
            list.Add(i1);
            InventoryItem i2 = new InventoryItem("2", "Vest", "Pol", 12, 6.00, 20.00, DateTime.Today);
            list.Add(i2);
            InventoryItem i3 = new InventoryItem("3", "Socks", "TWood", 15, 3.00, 40.00, DateTime.Today);
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
            
            try
            {
               
                const string message = "Are you sure that you would like to remove this item?";
                const string caption = "Item Remover";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    list.RemoveAt(lv_Inventory.SelectedIndices[0]);
                    PopulateInventory(list);

                } 
            }
            catch (Exception)
            {

                MessageBox.Show("You did not select an item to Remove. Please select an item from the list, and then click the Remove button");
            }

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

        /*
         *  This is the search btn click event. It brings up the search form for a user to search for a specific inventory item
         */
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            PopulateInventory(list);
        }

        
        /*This is the edit button click event. When the user clciks this button after selecting an item from the lsit view,
         *A new enventory item is created with the selected inventory item's details from the list. This object is edited in the 
         * EditItem form which is opened at this point using the show dialog() call so that when returned to this form, we can
         * continue in the process of editing the item. The returned item them replaces the selected item effecutally editing the 
         * item.
        */
        private void btn_Edit_Click(object sender, EventArgs e)
        {

            try
            {
                CreateSelectedItem();
                EditItem editForm = new EditItem();
                editForm.ShowDialog();
                
                list[lv_Inventory.SelectedIndices[0]].item_SKU = EditItem.edited_Item.item_SKU;
                list[lv_Inventory.SelectedIndices[0]].item_Type = EditItem.edited_Item.item_Type;
                list[lv_Inventory.SelectedIndices[0]].item_Name = EditItem.edited_Item.item_Name;
                list[lv_Inventory.SelectedIndices[0]].item_Quantity = EditItem.edited_Item.item_Quantity;
                list[lv_Inventory.SelectedIndices[0]].item_Purchase_Price = EditItem.edited_Item.item_Purchase_Price;
                list[lv_Inventory.SelectedIndices[0]].item_List_Price = EditItem.edited_Item.item_List_Price;
                PopulateInventory(list); // updating the listview with the edited list.

            }
            catch (Exception)
            {

                MessageBox.Show("You must select an item from the list first then click edit.");
            }

        }

        private InventoryItem CreateSelectedItem()
        {
            String editSKU = list[lv_Inventory.SelectedIndices[0]].item_SKU;
            String editName = list[lv_Inventory.SelectedIndices[0]].item_Name;
            String editCat = list[lv_Inventory.SelectedIndices[0]].item_Type;
            int editQuant = list[lv_Inventory.SelectedIndices[0]].item_Quantity;
            double editPP = list[lv_Inventory.SelectedIndices[0]].item_Purchase_Price;
            double editLP = list[lv_Inventory.SelectedIndices[0]].item_List_Price;
            DateTime itemDateTime = list[lv_Inventory.SelectedIndices[0]].item_List_Date;

            editSelectedItem = new InventoryItem(editSKU, editCat, editName, editQuant, editPP, editLP, itemDateTime);

            return editSelectedItem;
        }

        /*
         * This button click event will restock the selected item from the listview. The Restock Form will show and user can
         * enter the amount that they would like to restock too. This updates the list and the method PopulateInventroy() is 
         * called to show the new amount in stock.
         */
        private void btn_Restock_Click(object sender, EventArgs e)
        {

            try
            {
                Restock restock = new Restock();
                restock.ShowDialog();
                list[lv_Inventory.SelectedIndices[0]].item_Quantity = Restock.restockAmt; // changes the selected item's quantity to the restockAmt from Restock form

                PopulateInventory(list);//repopulates the list after restocking
            }
            catch (Exception)
            {

                MessageBox.Show("You did not select an item to Restock. \nPlease select an item from the list, and then click the Remove button");
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Here we are opening the sold item form. This method creates an item by calling createSelectedItem() menthod creates item out of selected row in listview. 
        private void btn_Sell_Click(object sender, EventArgs e)
        {
            CreateSelectedItem();
            
            SoldItemTracker sit = new SoldItemTracker();
            sit.ShowDialog();


        }
    }

}
