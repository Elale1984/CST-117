using System;

using System.Windows.Forms;
using InventoryItemClass;


namespace Inventory_Manager
{
    public partial class f_Add : Form
    {
        public f_Add()
        {
            InitializeComponent();

        }

        /*
         * Add Button click event for the f_Add form. This creates an InventoryItem taking the text from text boxes. 
         * The click event also add the item to the global list.
         */
        private void btn_Add_Click(object sender, EventArgs e)
        {
            String item_SKU = tb_SKU.Text;
            String item_Cat = tb_Cat.Text;
            String item_Name = tb_itemName.Text;
            int item_Quantity = int.Parse(tb_itemQuant.Text);
            double item_PPrice = double.Parse(tb_itemPPrice.Text);
            double item_LPrice = double.Parse(tb_itemLPrice.Text);
            DateTime item_ListDate = DateTime.Today;


            InventoryItem item = new InventoryItem(item_SKU, item_Cat, item_Name,item_Quantity,item_PPrice,item_LPrice, item_ListDate);
            
            InventoryManagerMain.list.Add(item);

           

            f_Add.ActiveForm.Close();
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

       
    } 
}
