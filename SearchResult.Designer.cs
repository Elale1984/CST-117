
namespace Inventory_Manager
{
    partial class SearchResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_sku = new System.Windows.Forms.ColumnHeader();
            this.ch_name = new System.Windows.Forms.ColumnHeader();
            this.ch_listPrice = new System.Windows.Forms.ColumnHeader();
            this.ch_PPrice = new System.Windows.Forms.ColumnHeader();
            this.ch_Quantity = new System.Windows.Forms.ColumnHeader();
            this.ch_PDate = new System.Windows.Forms.ColumnHeader();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Results";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_sku,
            this.ch_name,
            this.ch_listPrice,
            this.ch_PPrice,
            this.ch_Quantity,
            this.ch_PDate});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(845, 174);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ch_sku
            // 
            this.ch_sku.Text = "SKU";
            this.ch_sku.Width = 80;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Product Name";
            this.ch_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_name.Width = 200;
            // 
            // ch_listPrice
            // 
            this.ch_listPrice.Text = "List Price";
            this.ch_listPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_listPrice.Width = 150;
            // 
            // ch_PPrice
            // 
            this.ch_PPrice.Text = "Purchase Price";
            this.ch_PPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_PPrice.Width = 150;
            // 
            // ch_Quantity
            // 
            this.ch_Quantity.Text = "In Stock";
            this.ch_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_Quantity.Width = 100;
            // 
            // ch_PDate
            // 
            this.ch_PDate.Text = "Date Added";
            this.ch_PDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_PDate.Width = 150;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Search.Location = new System.Drawing.Point(738, 387);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 80);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Edit Item";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Location = new System.Drawing.Point(58, 387);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 80);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Delete Item";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 479);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "SearchResult";
            this.Text = "SearchResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch_sku;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_listPrice;
        private System.Windows.Forms.ColumnHeader ch_PPrice;
        private System.Windows.Forms.ColumnHeader ch_Quantity;
        private System.Windows.Forms.ColumnHeader ch_PDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add;
    }
}