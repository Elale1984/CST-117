using System;

/*
 * The inventory item class is a stand alone class that can be implemented in projects that it is needed. The purpose of this class 
 * is to create inventory item objects needed for use in an inventory application. 
 */
namespace InventoryItemClass
{
    public class InventoryItem
    {
        //Properties
        public String item_SKU { get; set; }
        public String item_Type { get; set; }
        public String item_Name { get; set; }
        public int item_Quantity { get; set; }
        public double item_Purchase_Price { get; set; }
        public double item_List_Price { get; set; }
        public String item_Description { get; set; }
        public DateTime item_List_Date { get; set; }

        //Constructor
        public InventoryItem(string item_SKU, string item_Type, string item_Name, int item_Quantity, double item_Purchase_Price, 
            double item_List_Price, string item_Description, DateTime item_List_Date)
        {
            this.item_SKU = item_SKU;
            this.item_Type = item_Type;
            this.item_Name = item_Name;
            this.item_Quantity = item_Quantity;
            this.item_Purchase_Price = item_Purchase_Price;
            this.item_List_Price = item_List_Price;
            this.item_Description = item_Description;
            this.item_List_Date = item_List_Date;
        }        
    }
}
