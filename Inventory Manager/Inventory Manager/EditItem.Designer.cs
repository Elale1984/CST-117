
namespace Inventory_Manager
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.tb_Cat = new System.Windows.Forms.TextBox();
            this.tb_SKU = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_itemLPrice = new System.Windows.Forms.TextBox();
            this.tb_itemPPrice = new System.Windows.Forms.TextBox();
            this.tb_itemQuant = new System.Windows.Forms.TextBox();
            this.tb_itemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Cat
            // 
            this.tb_Cat.Location = new System.Drawing.Point(181, 152);
            this.tb_Cat.Name = "tb_Cat";
            this.tb_Cat.Size = new System.Drawing.Size(150, 31);
            this.tb_Cat.TabIndex = 2;
            this.tb_Cat.TextChanged += new System.EventHandler(this.tb_Cat_TextChanged);
            // 
            // tb_SKU
            // 
            this.tb_SKU.Location = new System.Drawing.Point(181, 96);
            this.tb_SKU.Name = "tb_SKU";
            this.tb_SKU.Size = new System.Drawing.Size(150, 31);
            this.tb_SKU.TabIndex = 1;
            this.tb_SKU.TextChanged += new System.EventHandler(this.tb_SKU_TextChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Cancel.Location = new System.Drawing.Point(219, 421);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 45);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Olive;
            this.btn_Save.Location = new System.Drawing.Point(46, 421);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 45);
            this.btn_Save.TabIndex = 31;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_itemLPrice
            // 
            this.tb_itemLPrice.Location = new System.Drawing.Point(181, 366);
            this.tb_itemLPrice.Name = "tb_itemLPrice";
            this.tb_itemLPrice.Size = new System.Drawing.Size(150, 31);
            this.tb_itemLPrice.TabIndex = 6;
            this.tb_itemLPrice.TextChanged += new System.EventHandler(this.tb_itemLPrice_TextChanged);
            // 
            // tb_itemPPrice
            // 
            this.tb_itemPPrice.Location = new System.Drawing.Point(181, 311);
            this.tb_itemPPrice.Name = "tb_itemPPrice";
            this.tb_itemPPrice.Size = new System.Drawing.Size(150, 31);
            this.tb_itemPPrice.TabIndex = 5;
            this.tb_itemPPrice.TextChanged += new System.EventHandler(this.tb_itemPPrice_TextChanged);
            // 
            // tb_itemQuant
            // 
            this.tb_itemQuant.Location = new System.Drawing.Point(181, 258);
            this.tb_itemQuant.Name = "tb_itemQuant";
            this.tb_itemQuant.Size = new System.Drawing.Size(150, 31);
            this.tb_itemQuant.TabIndex = 4;
            this.tb_itemQuant.TextChanged += new System.EventHandler(this.tb_itemQuant_TextChanged);
            // 
            // tb_itemName
            // 
            this.tb_itemName.Location = new System.Drawing.Point(181, 207);
            this.tb_itemName.Name = "tb_itemName";
            this.tb_itemName.Size = new System.Drawing.Size(150, 31);
            this.tb_itemName.TabIndex = 3;
            this.tb_itemName.TextChanged += new System.EventHandler(this.tb_itemName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(106, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "SKU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(63, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Catagory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(65, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "List Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(17, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Purchase Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(66, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(19, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Edit Item";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_Manager.Properties.Resources.imagesdbacg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 495);
            this.Controls.Add(this.tb_Cat);
            this.Controls.Add(this.tb_SKU);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_itemLPrice);
            this.Controls.Add(this.tb_itemPPrice);
            this.Controls.Add(this.tb_itemQuant);
            this.Controls.Add(this.tb_itemName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditItem_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Cat;
        private System.Windows.Forms.TextBox tb_SKU;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_itemLPrice;
        private System.Windows.Forms.TextBox tb_itemPPrice;
        private System.Windows.Forms.TextBox tb_itemQuant;
        private System.Windows.Forms.TextBox tb_itemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}