using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Pr_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4
{
    public partial class FormMain : Form
    {
        private SubsystemPartnersContext? db;
       
        public FormMain()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)//
        {
            base.OnLoad(e);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            GeneratePanel();
        }
        private void GeneratePanel()
        {
            this.db = new SubsystemPartnersContext();
            var partners = db.Partners.OrderBy(o => o.Id).ToList();
            var type = db.TypePartners.ToList();


            int yOffset = 30;
            foreach (Partner u in partners)
            {
                var typePartner = db.TypePartners.Where(w => w.Id == u.IdTypePartner).FirstOrDefault();

                var partnersCount = db.PartnersProducts.Select(s => new { s.IdPartner, s.Count })
                    .Where(w => w.IdPartner == u.Id).Sum(s => s.Count);
                int discount = 0;

                if (partnersCount <= 10000)
                {
                    discount = 0;
                }
                else if (partnersCount > 10000 && partnersCount <= 50000)
                {
                    discount = 5;
                }
                else if (partnersCount > 50000 && partnersCount <= 300000)
                {
                    discount = 10;
                }
                else if (partnersCount > 300000)
                {
                    discount = 15;
                }

                Panel partnerPanel = new Panel
                {
                    Size = new System.Drawing.Size(750, 65),
                    Location = new System.Drawing.Point(15, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = $"{u.Id},{typePartner.Id}"
                };
                partnerPanel.MouseDown += panelLabel_MouseDown;

                Label partnerLabel = new Label
                {
                    AutoSize = true,
                    Text = $"{typePartner.TypeOfPartner} | {u.NamePartner}\n{u.DirectorFullName}\n{u.Phone}\nРейтинг: {u.Rating}"
                };

                Label DiscountPartner = new Label
                {
                    Dock = DockStyle.Right,
                    Text = $"{discount}%",
                    AutoSize = false,
                    Size = new System.Drawing.Size(100, 70),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                partnerPanel.Controls.Add(partnerLabel);
                partnerPanel.Controls.Add(DiscountPartner);
                this.Controls.Add(partnerPanel);
                yOffset += partnerLabel.Height + 20;
            }
        }
        private void panelLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Panel clickedPanel = sender as Panel;
                if (clickedPanel != null) {
                    int index=-1;
                    short indexType=-1;
                    int count = 0;

                    var type = db.TypePartners.Local.OrderBy(o=>o.TypeOfPartner).ToList();
                    string splits = (string)clickedPanel.Tag;
                    string[] Ids = splits.Split(",", StringSplitOptions.RemoveEmptyEntries);
                    int partnerId = Int32.Parse(Ids[0]);
                    short typePartnerId = short.Parse(Ids[1]);

                    TypePartner typePartner = db.TypePartners.Find(typePartnerId);
                    Partner partner = db.Partners.Find(partnerId);


                    
                    FormEditMain form = new();
                    
                    form.textBoxNamePartner.Text = partner.NamePartner;
                    form.textBoxNameDirector.Text = partner.DirectorFullName;
                    form.textBoxPhone.Text = partner.Phone;
                    form.textBoxRating.Text = $"{partner.Rating}";
                    foreach(TypePartner u in type)
                    {
                        form.comboBoxType.Items.Add(u.TypeOfPartner);
                       
                        if (u.TypeOfPartner == typePartner.TypeOfPartner)
                        {
                            index = count;
                            indexType = u.Id;
                        }
                        count++;
                    }
                    form.comboBoxType.SelectedIndex =index;

                    DialogResult result = form.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    foreach (TypePartner u in type)
                    {
                        form.comboBoxType.Items.Add(u.TypeOfPartner);
                        if (u.TypeOfPartner == form.comboBoxType.Text)
                        {
                            indexType = u.Id;
                        }
                    }
                    partner.IdTypePartner = indexType;
                    partner.NamePartner = form.textBoxNamePartner.Text;
                    partner.DirectorFullName = form.textBoxNameDirector.Text;
                    partner.Phone = form.textBoxPhone.Text;
                    partner.Rating = Int32.Parse(form.textBoxRating.Text);

                    db.SaveChanges();
                    this.Hide();
                    FormMain main = new FormMain();
                    main.Show();

                    FormMain_Load(sender, e);
                }
            }
        }
    }
}
