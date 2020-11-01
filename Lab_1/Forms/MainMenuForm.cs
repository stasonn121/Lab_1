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
        private static AdminPanel _adminPanel = new AdminPanel();
        public MainMenuForm()
        {
            InitializeComponent();
            InitChoiseLabel();
        }

        private void OpenBuyDrinks(object sender, EventArgs e)
        {
            _buyDrinksForm.ShowDialog();

            if (_buyDrinksForm.DialogResult == DialogResult.OK)
            {
                CoffeeMachine.OrderAmount = 0;
                InitChoiseLabel();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            _paymentForm.ShowDialog();
            var title = "Payment";
            var boxButton = MessageBoxButtons.OK;

            if (_paymentForm.DialogResult == DialogResult.OK) 
            {
                lblSelectedItems.Text = string.Empty;
                lblToPay.Text = $"Amount to pay: {CoffeeMachine.OrderAmount}";
                lblCash.Text = $"Money deposited: {CoffeeMachine.DeposedMoney} UAN";
                MessageBox.Show("Your order is ready", title, boxButton);
                InitChoiseLabel();
            }

            if (_paymentForm.DialogResult == DialogResult.No)
            {
                lblCash.Text = $"Money deposited: {CoffeeMachine.DeposedMoney} UAN";
                MessageBox.Show("Payment was failed", title, boxButton);
            }

        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            _adminPanel.ShowDialog();
        }

        private void InitChoiseLabel ()
        {
            string output = string.Empty;
            //int totalAmount = 0; 
            foreach (var item in Consts.selectedDrinks)
            {
               output += $"{item.Value} x {item.Key} \n";
               CoffeeMachine.OrderAmount += Consts.drinkPrice[item.Key] * item.Value;
            }
            lblSelectedItems.Text = output;
            lblToPay.Text = $"Amount to pay: {CoffeeMachine.OrderAmount}";
        }
    }
}
