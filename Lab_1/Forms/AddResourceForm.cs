using System;
using System.Windows.Forms;
using Lab_1.Constants;
using Lab_1.Model;

namespace Lab_1.Forms
{
    public partial class AddResourceForm : Form
    {
        public AddResourceForm(Resource resource)
        {
            this.Name = resource.ToString();
            InitializeComponent();
            numAddResouce.Maximum = CoffeeMachine.Remainder(resource);
            this.lblResource.Text = $"Add {resource}:";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
