using System;
using Lab_1.Model;
using System.Windows.Forms;

namespace Lab_1.Forms
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool isPaymentPassed = CoffeeMachine.ReplenishmentAndPayment((int)numAddSomething.Value);
            numAddSomething.Value = 0;
            if (isPaymentPassed) 
            {

                DialogResult = DialogResult.OK;
            }
            else
            { 
                DialogResult = DialogResult.No;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            numAddSomething.Value = 0;
        }


    }
}
