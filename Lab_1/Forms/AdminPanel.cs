using System;
using System.Windows.Forms;
using Lab_1.Constants;

namespace Lab_1.Forms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void BtnAddMilk_Click(object sender, EventArgs e)
        {
            AddResourceForm addMilk = new AddResourceForm(Resource.milk);
            addMilk.ShowDialog();
        }

        private void BtnAddCoffee_Click(object sender, EventArgs e)
        {
            AddResourceForm addCoffee = new AddResourceForm(Resource.coffee);
            addCoffee.ShowDialog();
        }

        private void BtnAddWater_Click(object sender, EventArgs e)
        {
            AddResourceForm addWater = new AddResourceForm(Resource.water);
            addWater.ShowDialog();
        }

        private void BtnAddSugar_Click(object sender, EventArgs e)
        {
            AddResourceForm addSugar = new AddResourceForm(Resource.sugar);
            addSugar.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
