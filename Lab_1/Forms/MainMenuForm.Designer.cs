namespace Lab_1
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
            this.btnBuyDrink = new System.Windows.Forms.Button();
            this.btnMoreDrinks = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
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
            // btnBuyDrink
            // 
            this.btnBuyDrink.Location = new System.Drawing.Point(80, 156);
            this.btnBuyDrink.Name = "btnBuyDrink";
            this.btnBuyDrink.Size = new System.Drawing.Size(155, 50);
            this.btnBuyDrink.TabIndex = 3;
            this.btnBuyDrink.Text = "Buy one drink";
            this.btnBuyDrink.UseVisualStyleBackColor = true;
            // 
            // btnMoreDrinks
            // 
            this.btnMoreDrinks.Location = new System.Drawing.Point(80, 212);
            this.btnMoreDrinks.Name = "btnMoreDrinks";
            this.btnMoreDrinks.Size = new System.Drawing.Size(155, 50);
            this.btnMoreDrinks.TabIndex = 4;
            this.btnMoreDrinks.Text = "Buy drinks";
            this.btnMoreDrinks.UseVisualStyleBackColor = true;
            this.btnMoreDrinks.Click += new System.EventHandler(this.OpenBuyDrinks);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(80, 308);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(155, 50);
            this.btnAdminPanel.TabIndex = 5;
            this.btnAdminPanel.Text = "Admin panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(25, 9);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(84, 16);
            this.lblCash.TabIndex = 6;
            this.lblCash.Text = "Cash: 0 UAN";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 398);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnMoreDrinks);
            this.Controls.Add(this.btnBuyDrink);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPrice);
            this.Name = "MainMenuForm";
            this.Text = "Coffee Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnBuyDrink;
        private System.Windows.Forms.Button btnMoreDrinks;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Label lblCash;
    }
}

