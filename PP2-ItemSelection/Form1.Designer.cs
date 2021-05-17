
namespace PP2_ItemSelection
{
    partial class Form1
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
            this.gb_Action = new System.Windows.Forms.GroupBox();
            this.rb_defend = new System.Windows.Forms.RadioButton();
            this.rb_Attack = new System.Windows.Forms.RadioButton();
            this.lb_Country = new System.Windows.Forms.ListBox();
            this.cb_Public = new System.Windows.Forms.CheckBox();
            this.cb_Press = new System.Windows.Forms.CheckBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.gb_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Your Options";
            // 
            // gb_Action
            // 
            this.gb_Action.Controls.Add(this.rb_defend);
            this.gb_Action.Controls.Add(this.rb_Attack);
            this.gb_Action.Location = new System.Drawing.Point(336, 164);
            this.gb_Action.Name = "gb_Action";
            this.gb_Action.Size = new System.Drawing.Size(181, 99);
            this.gb_Action.TabIndex = 1;
            this.gb_Action.TabStop = false;
            this.gb_Action.Text = "Choose an Action";
            // 
            // rb_defend
            // 
            this.rb_defend.AutoSize = true;
            this.rb_defend.Location = new System.Drawing.Point(6, 65);
            this.rb_defend.Name = "rb_defend";
            this.rb_defend.Size = new System.Drawing.Size(95, 29);
            this.rb_defend.TabIndex = 3;
            this.rb_defend.Text = "Defend";
            this.rb_defend.UseVisualStyleBackColor = true;
            // 
            // rb_Attack
            // 
            this.rb_Attack.AutoSize = true;
            this.rb_Attack.Location = new System.Drawing.Point(6, 30);
            this.rb_Attack.Name = "rb_Attack";
            this.rb_Attack.Size = new System.Drawing.Size(87, 29);
            this.rb_Attack.TabIndex = 2;
            this.rb_Attack.Text = "Attack";
            this.rb_Attack.UseVisualStyleBackColor = true;
            // 
            // lb_Country
            // 
            this.lb_Country.FormattingEnabled = true;
            this.lb_Country.ItemHeight = 25;
            this.lb_Country.Items.AddRange(new object[] {
            "Russia",
            "China",
            "North Korea"});
            this.lb_Country.Location = new System.Drawing.Point(101, 134);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(180, 129);
            this.lb_Country.TabIndex = 2;
            // 
            // cb_Public
            // 
            this.cb_Public.AutoSize = true;
            this.cb_Public.Location = new System.Drawing.Point(555, 195);
            this.cb_Public.Name = "cb_Public";
            this.cb_Public.Size = new System.Drawing.Size(139, 29);
            this.cb_Public.TabIndex = 3;
            this.cb_Public.Text = "Notify Public";
            this.cb_Public.UseVisualStyleBackColor = true;
            // 
            // cb_Press
            // 
            this.cb_Press.AutoSize = true;
            this.cb_Press.Location = new System.Drawing.Point(555, 230);
            this.cb_Press.Name = "cb_Press";
            this.cb_Press.Size = new System.Drawing.Size(133, 29);
            this.cb_Press.TabIndex = 4;
            this.cb_Press.Text = "Notify Press";
            this.cb_Press.UseVisualStyleBackColor = true;
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(342, 310);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(175, 80);
            this.btn_Execute.TabIndex = 5;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.cb_Press);
            this.Controls.Add(this.cb_Public);
            this.Controls.Add(this.lb_Country);
            this.Controls.Add(this.gb_Action);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Action.ResumeLayout(false);
            this.gb_Action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Action;
        private System.Windows.Forms.RadioButton rb_defend;
        private System.Windows.Forms.RadioButton rb_Attack;
        private System.Windows.Forms.ListBox lb_Country;
        private System.Windows.Forms.CheckBox cb_Public;
        private System.Windows.Forms.CheckBox cb_Press;
        private System.Windows.Forms.Button btn_Execute;
    }
}

