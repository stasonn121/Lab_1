using Lab_1.Constants;
using Lab_1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class MainMenuForm : Form
    {
        private static BuyDrinksForm _buyDrinksForm = new BuyDrinksForm();
        public MainMenuForm()
        {
            InitializeComponent();

        }

        private void OpenBuyDrinks(object sender, EventArgs e)
        {
            _buyDrinksForm.ShowDialog();
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
            ShowDialog(new PaymentForm());
        }
    }
}
