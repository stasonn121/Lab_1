using System;
using System.Windows.Forms;
using Lab_1.Constants;
using Lab_1.Model;

namespace Lab_1.Forms
{
    public partial class BuyDrinksForm : Form
    {
        public BuyDrinksForm()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            {
               Consts.selectedDrinks["Americano"] = (int)americanoNum.Value;
               Consts.selectedDrinks["Cappuccino"] = (int)cappuccinoNum.Value;
               Consts.selectedDrinks["Espresso"] = (int)espressoNum.Value;
               Consts.selectedDrinks["Tea"] = (int)teaNum.Value;
               Consts.selectedDrinks["LatteTea"] = (int)latteTeaNum.Value;
            }          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
