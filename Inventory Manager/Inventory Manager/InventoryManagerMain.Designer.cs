
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lv_Inventory = new System.Windows.Forms.ListView();
            this.ch_SKU = new System.Windows.Forms.ColumnHeader();
            this.ch_Name = new System.Windows.Forms.ColumnHeader();
            this.ch_Cat = new System.Windows.Forms.ColumnHeader();
            this.ch_Quant = new System.Windows.Forms.ColumnHeader();
            this.ch_PPrice = new System.Windows.Forms.ColumnHeader();
            this.ch_LPrice = new System.Windows.Forms.ColumnHeader();
            this.ch_PDate = new System.Windows.Forms.ColumnHeader();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Manager";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Location = new System.Drawing.Point(444, 591);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 80);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Search.Location = new System.Drawing.Point(814, 591);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 80);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lv_Inventory
            // 
            this.lv_Inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_SKU,
            this.ch_Name,
            this.ch_Cat,
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
            // ch_Name
            // 
            this.ch_Name.Text = "Item Name";
            this.ch_Name.Width = 150;
            // 
            // ch_Cat
            // 
            this.ch_Cat.Text = "Catagory";
            this.ch_Cat.Width = 150;
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
            this.btn_Remove.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Remove.Location = new System.Drawing.Point(628, 591);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(165, 80);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove Item";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // InventoryManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1128, 841);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.lv_Inventory);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "InventoryManagerMain";
            this.Text = "Add Item";
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
    }
}

