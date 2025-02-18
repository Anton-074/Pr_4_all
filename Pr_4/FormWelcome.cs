using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void buttonTypePartner_Click(object sender, EventArgs e)
        {
            FormTypesPartner form = new();
            form.ShowDialog();
        }

        private void buttonTypeProduct_Click(object sender, EventArgs e)
        {
            FormTypesProduct form = new();
            form.ShowDialog();
        }

        private void buttonPartners_Click(object sender, EventArgs e)
        {
            FormPartners form = new();
            form.ShowDialog();
        }
    }
}
