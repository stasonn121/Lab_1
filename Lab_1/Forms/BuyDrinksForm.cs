using System;
using System.Windows.Forms;

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
