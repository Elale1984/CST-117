
namespace PP4_TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Spot1 = new System.Windows.Forms.Label();
            this.lb_Spot2 = new System.Windows.Forms.Label();
            this.lb_Spot3 = new System.Windows.Forms.Label();
            this.lb_Spot6 = new System.Windows.Forms.Label();
            this.lb_Spot5 = new System.Windows.Forms.Label();
            this.lb_Spot4 = new System.Windows.Forms.Label();
            this.lb_Spot9 = new System.Windows.Forms.Label();
            this.lb_Spot8 = new System.Windows.Forms.Label();
            this.lb_Spot7 = new System.Windows.Forms.Label();
            this.tb_Winner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(136, 580);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(112, 75);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(342, 580);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 75);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(73, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // lb_Spot1
            // 
            this.lb_Spot1.BackColor = System.Drawing.Color.White;
            this.lb_Spot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot1.Location = new System.Drawing.Point(120, 133);
            this.lb_Spot1.Name = "lb_Spot1";
            this.lb_Spot1.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot1.TabIndex = 3;
            this.lb_Spot1.Text = "_";
            this.lb_Spot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot1.Click += new System.EventHandler(this.lb_Spot1_Click);
            // 
            // lb_Spot2
            // 
            this.lb_Spot2.BackColor = System.Drawing.Color.White;
            this.lb_Spot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot2.Location = new System.Drawing.Point(251, 133);
            this.lb_Spot2.Name = "lb_Spot2";
            this.lb_Spot2.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot2.TabIndex = 4;
            this.lb_Spot2.Text = "_";
            this.lb_Spot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot2.Click += new System.EventHandler(this.lb_Spot2_Click);
            // 
            // lb_Spot3
            // 
            this.lb_Spot3.BackColor = System.Drawing.Color.White;
            this.lb_Spot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot3.Location = new System.Drawing.Point(389, 133);
            this.lb_Spot3.Name = "lb_Spot3";
            this.lb_Spot3.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot3.TabIndex = 5;
            this.lb_Spot3.Text = "_";
            this.lb_Spot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot3.Click += new System.EventHandler(this.lb_Spot3_Click);
            // 
            // lb_Spot6
            // 
            this.lb_Spot6.BackColor = System.Drawing.Color.White;
            this.lb_Spot6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot6.Location = new System.Drawing.Point(389, 258);
            this.lb_Spot6.Name = "lb_Spot6";
            this.lb_Spot6.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot6.TabIndex = 8;
            this.lb_Spot6.Text = "_";
            this.lb_Spot6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot6.Click += new System.EventHandler(this.lb_Spot6_Click);
            // 
            // lb_Spot5
            // 
            this.lb_Spot5.BackColor = System.Drawing.Color.White;
            this.lb_Spot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot5.Location = new System.Drawing.Point(251, 258);
            this.lb_Spot5.Name = "lb_Spot5";
            this.lb_Spot5.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot5.TabIndex = 7;
            this.lb_Spot5.Text = "_";
            this.lb_Spot5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot5.Click += new System.EventHandler(this.lb_Spot5_Click);
            // 
            // lb_Spot4
            // 
            this.lb_Spot4.BackColor = System.Drawing.Color.White;
            this.lb_Spot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot4.Location = new System.Drawing.Point(120, 258);
            this.lb_Spot4.Name = "lb_Spot4";
            this.lb_Spot4.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot4.TabIndex = 6;
            this.lb_Spot4.Text = "_";
            this.lb_Spot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot4.Click += new System.EventHandler(this.lb_Spot4_Click);
            // 
            // lb_Spot9
            // 
            this.lb_Spot9.BackColor = System.Drawing.Color.White;
            this.lb_Spot9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot9.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot9.Location = new System.Drawing.Point(389, 385);
            this.lb_Spot9.Name = "lb_Spot9";
            this.lb_Spot9.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot9.TabIndex = 11;
            this.lb_Spot9.Text = "_";
            this.lb_Spot9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot9.Click += new System.EventHandler(this.lb_Spot9_Click);
            // 
            // lb_Spot8
            // 
            this.lb_Spot8.BackColor = System.Drawing.Color.White;
            this.lb_Spot8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot8.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot8.Location = new System.Drawing.Point(251, 385);
            this.lb_Spot8.Name = "lb_Spot8";
            this.lb_Spot8.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot8.TabIndex = 10;
            this.lb_Spot8.Text = "_";
            this.lb_Spot8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot8.Click += new System.EventHandler(this.lb_Spot8_Click);
            // 
            // lb_Spot7
            // 
            this.lb_Spot7.BackColor = System.Drawing.Color.White;
            this.lb_Spot7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Spot7.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Spot7.Location = new System.Drawing.Point(120, 385);
            this.lb_Spot7.Name = "lb_Spot7";
            this.lb_Spot7.Size = new System.Drawing.Size(90, 110);
            this.lb_Spot7.TabIndex = 9;
            this.lb_Spot7.Text = "_";
            this.lb_Spot7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Spot7.Click += new System.EventHandler(this.lb_Spot7_Click);
            // 
            // tb_Winner
            // 
            this.tb_Winner.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_Winner.ForeColor = System.Drawing.Color.ForestGreen;
            this.tb_Winner.Location = new System.Drawing.Point(136, 526);
            this.tb_Winner.Name = "tb_Winner";
            this.tb_Winner.Size = new System.Drawing.Size(318, 31);
            this.tb_Winner.TabIndex = 12;
            this.tb_Winner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 670);
            this.Controls.Add(this.tb_Winner);
            this.Controls.Add(this.lb_Spot9);
            this.Controls.Add(this.lb_Spot8);
            this.Controls.Add(this.lb_Spot7);
            this.Controls.Add(this.lb_Spot6);
            this.Controls.Add(this.lb_Spot5);
            this.Controls.Add(this.lb_Spot4);
            this.Controls.Add(this.lb_Spot3);
            this.Controls.Add(this.lb_Spot2);
            this.Controls.Add(this.lb_Spot1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_NewGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac_Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Spot1;
        private System.Windows.Forms.Label lb_Spot2;
        private System.Windows.Forms.Label lb_Spot3;
        private System.Windows.Forms.Label lb_Spot6;
        private System.Windows.Forms.Label lb_Spot5;
        private System.Windows.Forms.Label lb_Spot4;
        private System.Windows.Forms.Label lb_Spot9;
        private System.Windows.Forms.Label lb_Spot8;
        private System.Windows.Forms.Label lb_Spot7;
        private System.Windows.Forms.TextBox tb_Winner;
    }
}

