using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Pr_4.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pr_4
{
    public partial class FormTypesPartner : Form
    {
        private SubsystemPartnersContext? db;
        public FormTypesPartner()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            /* using(SubsystemPartnersContext db = new SubsystemPartnersContext())
             {
                 *//*var partners = db.Partners.Include(u => u.IdTypePartnerNavigation)*//*.ThenInclude(c => c.IdPartnerNavigation)*//*.ToList();
                 int yOffset = 10;
                 foreach (Partner u in partners)
                 {
                     Panel panel = new Panel
                     {
                         Width = 500,
                         Height = 70,
                         BackColor = Color.LightGray,
                         Location = new System.Drawing.Point(15, yOffset)

                     };

                     Label lb1 = new Label
                     {
                         Text = $"{u.IdTypePartnerNavigation.TypeOfPartner} | " +
                         $"{u.NamePartner}\n" +
                         $"{u.DirectorFullName}\n" +
                         $"{u.Phone}\n" +
                         $"Рейтинг: {u.Rating}",
                         AutoSize = true

                     };
                     Label lb2 = new Label
                     {
                         Dock = DockStyle.Right,
                         Width = 100,
                         TextAlign = ContentAlignment.MiddleCenter,
                         Text = "10%"
                     };

                     panel.Controls.Add(lb1);
                     panel.Controls.Add(lb2);
                     panelFill.Controls.Add(panel);

                     yOffset += panel.Height + 10;
                 }*//*
             }*/


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new SubsystemPartnersContext();
            this.db.TypePartners.Load();
            this.dataGridViewType.DataSource = this.db.TypePartners.Local
                .OrderBy(o => o.TypeOfPartner).ToList();

            dataGridViewType.Columns["Id"].Visible = false;
            dataGridViewType.Columns["Partners"].Visible = false;
            dataGridViewType.Columns["TypeOfPartner"].HeaderText = "Тип партнера";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formAdd formAddPartner = new();
            formAddPartner.label.Text = "Тип партнера";
            DialogResult result = formAddPartner.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            TypePartner typePartner = new TypePartner
            {
                TypeOfPartner = formAddPartner.textBoxTypes.Text
            };

            db.TypePartners.Add(typePartner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewType.DataSource = this.db.TypePartners.Local
                .OrderBy(o => o.TypeOfPartner).ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewType.SelectedRows.Count == 0)
                return;

            int index = dataGridViewType.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewType[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypePartner typePartner = db.TypePartners.Find(id);

            formAdd formAddPartner = new();

            formAddPartner.textBoxTypes.Text = typePartner.TypeOfPartner;

            DialogResult result = formAddPartner.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            typePartner.TypeOfPartner = formAddPartner.textBoxTypes.Text;

            db.SaveChanges();
            MessageBox.Show("Объект обновлен");
            this.dataGridViewType.DataSource = this.db.TypePartners.Local
                .OrderBy(o => o.TypeOfPartner).ToList();


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewType.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewType.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewType[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypePartner typePartner = db.TypePartners.Find(id);

            db.TypePartners.Remove(typePartner);

            db.SaveChanges();
            MessageBox.Show("Объект удален");
            this.dataGridViewType.DataSource = this.db.TypePartners.Local
                .OrderBy(o => o.TypeOfPartner).ToList();
        }
    }
}
