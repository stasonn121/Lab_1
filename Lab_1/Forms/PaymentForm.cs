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
            CoffeeMachine.Cash += (int)numCash.Value;
            numCash.Value = 0;
            DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            numCash.Value = 0;
        }


    }
}
