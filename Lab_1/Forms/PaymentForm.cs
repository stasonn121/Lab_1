using System;
using Lab_1.Model;
using Lab_1.Constants;
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




                if (CoffeeMachine.IsResourseEnough())
                {

                    CoffeeMachine.MakeDrinks();
                    DialogResult = DialogResult.OK;
                    Consts.selectedDrinks["Americano"] = 0;
                    Consts.selectedDrinks["Cappuccino"] = 0;
                    Consts.selectedDrinks["Latte"] = 0;
                    Consts.selectedDrinks["Espresso"] = 0;
                    Consts.selectedDrinks["Tea"] = 0;
                    Consts.selectedDrinks["LatteTea"] = 0;

                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }


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
