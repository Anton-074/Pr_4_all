using Microsoft.EntityFrameworkCore;
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
    public partial class FormTypesProduct : Form
    {
        private SubsystemPartnersContext? db;
        public FormTypesProduct()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new SubsystemPartnersContext();
            this.db.TypeOfProducts.Load();
            this.dataGridViewType.DataSource = this.db.TypeOfProducts.Local
                .OrderBy(o => o.TypeOfProduct1).ToList();

            dataGridViewType.Columns["Id"].Visible = false;
            dataGridViewType.Columns["Products"].Visible = false;
            dataGridViewType.Columns["TypeOfProduct1"].HeaderText = "Тип продукта";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formAdd formAddProduct = new();
            formAddProduct.label.Text = "Тип продукции";
            DialogResult result = formAddProduct.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            TypeOfProduct typeProduct = new TypeOfProduct
            {
                TypeOfProduct1 = formAddProduct.textBoxTypes.Text
            };

            db.TypeOfProducts.Add(typeProduct);
            db.SaveChanges();
            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewType.DataSource = this.db.TypeOfProducts.Local
                .OrderBy(o => o.TypeOfProduct1).ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewType.SelectedRows.Count == 0)
                return;

            int index = dataGridViewType.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewType[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypeOfProduct typeProduct = db.TypeOfProducts.Find(id);

            formAdd formAddProduct = new();

            formAddProduct.textBoxTypes.Text = typeProduct.TypeOfProduct1;

            DialogResult result = formAddProduct.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            typeProduct.TypeOfProduct1 = formAddProduct.textBoxTypes.Text;

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
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewType[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypeOfProduct typeProduct = db.TypeOfProducts.Find(id);

            db.TypeOfProducts.Remove(typeProduct);

            db.SaveChanges();
            MessageBox.Show("Объект удален");
            this.dataGridViewType.DataSource = this.db.TypeOfProducts.Local
                .OrderBy(o => o.TypeOfProduct1).ToList();
        }
    }

}
