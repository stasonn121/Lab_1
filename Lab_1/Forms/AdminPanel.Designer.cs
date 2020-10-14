namespace Lab_1.Forms
{
    partial class AdminPanel
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
            this.btnAddMilk = new System.Windows.Forms.Button();
            this.btnAddCoffee = new System.Windows.Forms.Button();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.btnAddSugar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMilk
            // 
            this.btnAddMilk.Location = new System.Drawing.Point(70, 24);
            this.btnAddMilk.Name = "btnAddMilk";
            this.btnAddMilk.Size = new System.Drawing.Size(171, 47);
            this.btnAddMilk.TabIndex = 0;
            this.btnAddMilk.Text = "Add milk";
            this.btnAddMilk.UseVisualStyleBackColor = true;
            this.btnAddMilk.Click += new System.EventHandler(this.BtnAddMilk_Click);
            // 
            // btnAddCoffee
            // 
            this.btnAddCoffee.Location = new System.Drawing.Point(70, 86);
            this.btnAddCoffee.Name = "btnAddCoffee";
            this.btnAddCoffee.Size = new System.Drawing.Size(171, 47);
            this.btnAddCoffee.TabIndex = 1;
            this.btnAddCoffee.Text = "Add coffee";
            this.btnAddCoffee.UseVisualStyleBackColor = true;
            this.btnAddCoffee.Click += new System.EventHandler(this.BtnAddCoffee_Click);
            // 
            // btnAddWater
            // 
            this.btnAddWater.Location = new System.Drawing.Point(70, 149);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(171, 47);
            this.btnAddWater.TabIndex = 2;
            this.btnAddWater.Text = "Add water";
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Click += new System.EventHandler(this.BtnAddWater_Click);
            // 
            // btnAddSugar
            // 
            this.btnAddSugar.Location = new System.Drawing.Point(70, 213);
            this.btnAddSugar.Name = "btnAddSugar";
            this.btnAddSugar.Size = new System.Drawing.Size(171, 47);
            this.btnAddSugar.TabIndex = 3;
            this.btnAddSugar.Text = "Add sugar";
            this.btnAddSugar.UseVisualStyleBackColor = true;
            this.btnAddSugar.Click += new System.EventHandler(this.BtnAddSugar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(70, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 373);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddSugar);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.btnAddCoffee);
            this.Controls.Add(this.btnAddMilk);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMilk;
        private System.Windows.Forms.Button btnAddCoffee;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.Button btnAddSugar;
        private System.Windows.Forms.Button btnExit;
    }
}