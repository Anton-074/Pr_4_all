using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Pr_4.Models;
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
    public partial class FormPartners : Form
    {
        private SubsystemPartnersContext? db;
        public FormPartners()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new SubsystemPartnersContext();
            this.db.Partners.Load();
            this.dataGridViewType.DataSource = this.db.Partners.Local
                .OrderBy(o => o.NamePartner).ToList();

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

            dataGridViewType.Columns["Id"].Visible = false;


        }

        private void FormPartners_Load(object sender, EventArgs e)
        {
            this.db = new SubsystemPartnersContext();
            this.db.TypePartners.Load();
            foreach (TypePartner type in db.TypePartners.Local.OrderBy(o => o.TypeOfPartner).ToList())
            {

                comboBox1.Items.Add(type.TypeOfPartner.ToString());
            }
            comboBox1.DataSource = db.TypePartners.Local.OrderBy(o => o.TypeOfPartner).ToList();
        }

        private void buttonAdd_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
