using InventoryItemClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;


namespace Inventory_Manager
{
    public partial class EditItem : Form
    {
        public static InventoryItem edited_Item;
        public EditItem()
        {
            InitializeComponent();

            //The details from the edit item from InventoryManagerMain will show in the textboxes in this for for editing.
            tb_SKU.Text = InventoryManagerMain.editSelectedItem.item_SKU;
            tb_SKU.ForeColor = Color.Red;
            tb_itemName.Text = InventoryManagerMain.editSelectedItem.item_Name;
            tb_itemName.ForeColor = Color.Red;
            tb_Cat.Text = InventoryManagerMain.editSelectedItem.item_Type;
            tb_Cat.ForeColor = Color.Red;
            tb_itemQuant.Text = InventoryManagerMain.editSelectedItem.item_Quantity.ToString();
            tb_itemQuant.ForeColor = Color.Red;
            tb_itemPPrice.Text = InventoryManagerMain.editSelectedItem.item_Purchase_Price.ToString();
            tb_itemPPrice.ForeColor = Color.Red;
            tb_itemLPrice.Text = InventoryManagerMain.editSelectedItem.item_List_Price.ToString();
            tb_itemLPrice.ForeColor = Color.Red;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                String item_SKU = tb_SKU.Text;
                String item_Cat = tb_Cat.Text;
                String item_Name = tb_itemName.Text;
                int item_Quantity = int.Parse(tb_itemQuant.Text);
                double item_PPrice = double.Parse(tb_itemPPrice.Text);
                double item_LPrice = double.Parse(tb_itemLPrice.Text);
                DateTime item_ListDate = DateTime.Today;

                edited_Item = new InventoryItem(item_SKU, item_Cat, item_Name, item_Quantity, item_PPrice, item_LPrice, item_ListDate);
                ActiveForm.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Please fill out the form correctly");
            }

            
        }

      
        //The following TextChanged methods will change the color of the text to black when new text is inserted.
        private void tb_SKU_TextChanged(object sender, EventArgs e)
        {
            tb_SKU.ForeColor = Color.Black;

        }

        private void tb_Cat_TextChanged(object sender, EventArgs e)
        {
            tb_Cat.ForeColor = Color.Black;
        }

        private void tb_itemName_TextChanged(object sender, EventArgs e)
        {
            tb_itemName.ForeColor = Color.Black;
        }

        private void tb_itemQuant_TextChanged(object sender, EventArgs e)
        {
            tb_itemQuant.ForeColor = Color.Black;
        }

        private void tb_itemPPrice_TextChanged(object sender, EventArgs e)
        {
            tb_itemPPrice.ForeColor = Color.Black;
        }

        private void tb_itemLPrice_TextChanged(object sender, EventArgs e)
        {
            tb_itemLPrice.ForeColor = Color.Black;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void EditItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
               "You are about to change this item's details. \nAre you sure you want to do this.?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }
    }
}
