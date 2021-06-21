
namespace Inventory_Manager
{
    partial class InventoryManagerMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagerMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lv_Inventory = new System.Windows.Forms.ListView();
            this.ch_SKU = new System.Windows.Forms.ColumnHeader();
            this.ch_Cat = new System.Windows.Forms.ColumnHeader();
            this.ch_Name = new System.Windows.Forms.ColumnHeader();
            this.ch_Quant = new System.Windows.Forms.ColumnHeader();
            this.ch_PPrice = new System.Windows.Forms.ColumnHeader();
            this.ch_LPrice = new System.Windows.Forms.ColumnHeader();
            this.ch_PDate = new System.Windows.Forms.ColumnHeader();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Restock = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Manager";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Olive;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Location = new System.Drawing.Point(472, 591);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 80);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Search.Location = new System.Drawing.Point(848, 591);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 80);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lv_Inventory
            // 
            this.lv_Inventory.BackColor = System.Drawing.SystemColors.Info;
            this.lv_Inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_SKU,
            this.ch_Cat,
            this.ch_Name,
            this.ch_Quant,
            this.ch_PPrice,
            this.ch_LPrice,
            this.ch_PDate});
            this.lv_Inventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Inventory.FullRowSelect = true;
            this.lv_Inventory.GridLines = true;
            this.lv_Inventory.HideSelection = false;
            this.lv_Inventory.Location = new System.Drawing.Point(99, 170);
            this.lv_Inventory.Name = "lv_Inventory";
            this.lv_Inventory.Size = new System.Drawing.Size(914, 375);
            this.lv_Inventory.TabIndex = 4;
            this.lv_Inventory.UseCompatibleStateImageBehavior = false;
            this.lv_Inventory.View = System.Windows.Forms.View.Details;
            // 
            // ch_SKU
            // 
            this.ch_SKU.Text = "SKU";
            this.ch_SKU.Width = 100;
            // 
            // ch_Cat
            // 
            this.ch_Cat.DisplayIndex = 2;
            this.ch_Cat.Text = "Catagory";
            this.ch_Cat.Width = 150;
            // 
            // ch_Name
            // 
            this.ch_Name.DisplayIndex = 1;
            this.ch_Name.Text = "Item Name";
            this.ch_Name.Width = 150;
            // 
            // ch_Quant
            // 
            this.ch_Quant.Text = "Stock";
            // 
            // ch_PPrice
            // 
            this.ch_PPrice.Text = "Purchase Price";
            this.ch_PPrice.Width = 150;
            // 
            // ch_LPrice
            // 
            this.ch_LPrice.Text = "List Price";
            this.ch_LPrice.Width = 150;
            // 
            // ch_PDate
            // 
            this.ch_PDate.Text = "Purchase Date";
            this.ch_PDate.Width = 150;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Plum;
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Remove.Location = new System.Drawing.Point(660, 591);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(165, 80);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove Item";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Location = new System.Drawing.Point(283, 591);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(165, 80);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Edit Item";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Restock
            // 
            this.btn_Restock.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Restock.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Restock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Restock.Location = new System.Drawing.Point(99, 591);
            this.btn_Restock.Name = "btn_Restock";
            this.btn_Restock.Size = new System.Drawing.Size(165, 80);
            this.btn_Restock.TabIndex = 7;
            this.btn_Restock.Text = "Restock";
            this.btn_Restock.UseVisualStyleBackColor = false;
            this.btn_Restock.Click += new System.EventHandler(this.btn_Restock_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Exit.Location = new System.Drawing.Point(660, 711);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(353, 78);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Sell
            // 
            this.btn_Sell.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Sell.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sell.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Sell.Location = new System.Drawing.Point(99, 711);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(349, 78);
            this.btn_Sell.TabIndex = 10;
            this.btn_Sell.Text = "Sell An Item";
            this.btn_Sell.UseVisualStyleBackColor = false;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // InventoryManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1128, 841);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Restock);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.lv_Inventory);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryManagerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListView lv_Inventory;
        private System.Windows.Forms.ColumnHeader ch_SKU;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_Cat;
        private System.Windows.Forms.ColumnHeader ch_Quant;
        private System.Windows.Forms.ColumnHeader ch_PPrice;
        private System.Windows.Forms.ColumnHeader ch_LPrice;
        private System.Windows.Forms.ColumnHeader ch_PDate;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Restock;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Sell;
    }
}

