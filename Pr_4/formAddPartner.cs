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
    public partial class formAdd : Form
    {
        string msgError = "Поле не может быть пустым";
        public formAdd()
        {
            InitializeComponent();
        }

        private void textBoxTypePartner_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypes.Text))
            {
                errorProvider.SetError(textBoxTypes, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxTypePartner_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypes.Text))
            {
                errorProvider.SetError(textBoxTypes, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
    
}
