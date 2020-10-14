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
    public partial class AddResourceForm : Form
    {
        public AddResourceForm(string nameForm, string lblResourceText)
        {
            InitializeComponent();
            this.Name = nameForm;
            this.lblResource.Text = lblResourceText;
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
