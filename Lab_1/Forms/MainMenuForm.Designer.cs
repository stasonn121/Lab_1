﻿namespace Lab_1
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnBuyDrink = new System.Windows.Forms.Button();
            this.btnMoreDrinks = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
            this.selectedItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(337, 42);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(155, 50);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnBuyDrink
            // 
            this.btnBuyDrink.Location = new System.Drawing.Point(337, 98);
            this.btnBuyDrink.Name = "btnBuyDrink";
            this.btnBuyDrink.Size = new System.Drawing.Size(155, 50);
            this.btnBuyDrink.TabIndex = 3;
            this.btnBuyDrink.Text = "Buy one drink";
            this.btnBuyDrink.UseVisualStyleBackColor = true;
            // 
            // btnMoreDrinks
            // 
            this.btnMoreDrinks.Location = new System.Drawing.Point(337, 154);
            this.btnMoreDrinks.Name = "btnMoreDrinks";
            this.btnMoreDrinks.Size = new System.Drawing.Size(155, 50);
            this.btnMoreDrinks.TabIndex = 4;
            this.btnMoreDrinks.Text = "Buy drinks";
            this.btnMoreDrinks.UseVisualStyleBackColor = true;
            this.btnMoreDrinks.Click += new System.EventHandler(this.OpenBuyDrinks);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(337, 318);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(155, 50);
            this.btnAdminPanel.TabIndex = 5;
            this.btnAdminPanel.Text = "Admin panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(44, 59);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(84, 16);
            this.lblCash.TabIndex = 6;
            this.lblCash.Text = "Cash: 0 UAN";
            // 
            // selectedItems
            // 
            this.selectedItems.AutoSize = true;
            this.selectedItems.Location = new System.Drawing.Point(44, 244);
            this.selectedItems.Name = "selectedItems";
            this.selectedItems.Size = new System.Drawing.Size(0, 16);
            this.selectedItems.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 96);
            this.label1.TabIndex = 8;
            this.label1.Text = "Americano : 15 UAN\r\nEspresso : 15 UAN\r\nLatte : 25 UAN\r\nTea : 10 UAN\r\nCappuccino :" +
    " 25 UAN\r\nTeaLatte : 20 UAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your choise: ";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedItems);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnMoreDrinks);
            this.Controls.Add(this.btnBuyDrink);
            this.Controls.Add(this.btnPayment);
            this.Name = "MainMenuForm";
            this.Text = "Coffee Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnBuyDrink;
        private System.Windows.Forms.Button btnMoreDrinks;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label selectedItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

