using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
        }

        /*
         * This button click event for the add button launches the add item form which allows the user to input the item 
         * details. I have used the f.ShowDialog() so that the next line of code will not execute until the user adds the item.
         * Then I have used a MessageBox.Show for now to show the list item details demonstrating that the item is stored to a 
         * list <>.
         */
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            f_Add f = new f_Add();
            
            f.ShowDialog();

            // The item is from the InventoryItemClass that I have created which creates an object for the item
            MessageBox.Show("SKU: " + list[0].item_SKU + "\n" + "Catagory: " + list[0].item_Type + 
                "\n" + "Name: " + list[0].item_Name + "\n" + "Stock: " + list[0].item_Quantity + "\n" + 
                "Purchase Price: " + list[0].item_Purchase_Price + "\n" + "List Price: " + list[0].item_List_Price + 
                "\n" + "List Date: " + list[0].item_List_Date + "\n" + "Description: " + list[0].item_Description);                        
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
            
        }

    }
}
