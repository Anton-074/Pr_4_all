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
    public partial class FormEditMain : Form
    {
        string msgError = "Поле не может быть пустым";
        public FormEditMain()
        {
            InitializeComponent();
        }

        private void textBoxTypes_TextChanged(object sender, EventArgs e)
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

        private void textBoxTypes_Validating(object sender, CancelEventArgs e)
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

        private void textBoxNamePartner_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNamePartner.Text))
            {
                errorProvider.SetError(textBoxNamePartner, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxNamePartner_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNamePartner.Text))
            {
                errorProvider.SetError(textBoxNamePartner, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxNameDirector_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNameDirector.Text))
            {
                errorProvider.SetError(textBoxNameDirector, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxNameDirector_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNameDirector.Text))
            {
                errorProvider.SetError(textBoxNameDirector, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPhone.Text))
            {
                errorProvider.SetError(textBoxPhone, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPhone.Text))
            {
                errorProvider.SetError(textBoxPhone, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRating.Text))
            {
                errorProvider.SetError(textBoxRating, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxRating_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRating.Text))
            {
                errorProvider.SetError(textBoxRating, msgError);
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
