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
    public partial class FormAddPanelPartner : Form
    {
        string msgError = "Поле не может быть пустым";
        public FormAddPanelPartner()
        {
            InitializeComponent();
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

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAdress.Text))
            {
                errorProvider.SetError(textBoxAdress, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxINN_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxINN.Text))
            {
                errorProvider.SetError(textBoxINN, msgError);
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

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                errorProvider.SetError(textBoxEmail, msgError);
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

        private void textBoxAdress_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAdress.Text))
            {
                errorProvider.SetError(textBoxAdress, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxINN_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxINN.Text))
            {
                errorProvider.SetError(textBoxINN, msgError);
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

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                errorProvider.SetError(textBoxEmail, msgError);
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
