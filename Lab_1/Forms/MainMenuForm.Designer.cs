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
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnBuyDrink = new System.Windows.Forms.Button();
            this.btnMoreDrinks = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(80, 44);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(155, 50);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "Price List";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(80, 100);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(155, 50);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(80, 156);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(155, 50);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "Your cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnBuyDrink
            // 
            this.btnBuyDrink.Location = new System.Drawing.Point(80, 212);
            this.btnBuyDrink.Name = "btnBuyDrink";
            this.btnBuyDrink.Size = new System.Drawing.Size(155, 50);
            this.btnBuyDrink.TabIndex = 3;
            this.btnBuyDrink.Text = "Buy one drink";
            this.btnBuyDrink.UseVisualStyleBackColor = true;
            // 
            // btnMoreDrinks
            // 
            this.btnMoreDrinks.Location = new System.Drawing.Point(80, 268);
            this.btnMoreDrinks.Name = "btnMoreDrinks";
            this.btnMoreDrinks.Size = new System.Drawing.Size(155, 50);
            this.btnMoreDrinks.TabIndex = 4;
            this.btnMoreDrinks.Text = "Buy drinks";
            this.btnMoreDrinks.UseVisualStyleBackColor = true;
            this.btnMoreDrinks.Click += new System.EventHandler(this.OpenBuyDrinks);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(80, 364);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(155, 50);
            this.btnAdminPanel.TabIndex = 5;
            this.btnAdminPanel.Text = "Admin panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 466);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnMoreDrinks);
            this.Controls.Add(this.btnBuyDrink);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPrice);
            this.Name = "MainMenuForm";
            this.Text = "Coffee Machine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnBuyDrink;
        private System.Windows.Forms.Button btnMoreDrinks;
        private System.Windows.Forms.Button btnAdminPanel;
    }
}

