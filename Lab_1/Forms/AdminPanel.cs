using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            AddResourceForm addMilk = new AddResourceForm("Add milk", "Add milk:");
            addMilk.ShowDialog();
        }

        private void BtnAddCoffee_Click(object sender, EventArgs e)
        {
            AddResourceForm addCoffee = new AddResourceForm("Add coffee", "Add coffee:");
            addCoffee.ShowDialog();
        }

        private void BtnAddWater_Click(object sender, EventArgs e)
        {
            AddResourceForm addWater = new AddResourceForm("Add water", "Add water:");
            addWater.ShowDialog();
        }

        private void BtnAddSugar_Click(object sender, EventArgs e)
        {
            AddResourceForm addSugar = new AddResourceForm("Add sugar", "Add sugar:");
            addSugar.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
