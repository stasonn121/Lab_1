using Lab_1.Model;
using Lab_1.Constants;
using Lab_1.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Lab_1
{
    public partial class MainMenuForm : Form
    {
        private static BuyDrinksForm _buyDrinksForm = new BuyDrinksForm();
        private static PaymentForm _paymentForm = new PaymentForm();
        public MainMenuForm()
        {
            InitializeComponent();

        }

        private void OpenBuyDrinks(object sender, EventArgs e)
        {
            _buyDrinksForm.ShowDialog();

            if (_buyDrinksForm.DialogResult == DialogResult.OK)
            {
                string output = string.Empty;
                foreach (var item in Consts.selectedDrinks)
                {
                    if(item.Value != 0)
                    output += $"{item.Value.ToString()} x {item.Key.ToString()} \n";  
                }
                selectedItems.Text = output;
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            string body = string.Empty;
            var title = "Price list";
            var boxButtons = MessageBoxButtons.OK;
            foreach (KeyValuePair<string, int> keyValue in Consts.drinkPrice)
            {
                body += $"{keyValue.Key} : {keyValue.Value} UAN\n";
            }

            MessageBox.Show(body, title, boxButtons);

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            _paymentForm.ShowDialog();
            if (_paymentForm.DialogResult == DialogResult.OK) 
            {
                lblCash.Text = $"Cash: {CoffeeMachine.Cash} UAN";
            }

        }

    }
}
