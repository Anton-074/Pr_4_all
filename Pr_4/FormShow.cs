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
    public partial class FormShow : Form
    {
        private SubsystemPartnersContext? db;
        private int partnerId;
        public FormShow(int partnerId)
        {
            InitializeComponent();
            this.partnerId = partnerId;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new SubsystemPartnersContext();



            /*this.dataGridViewRealisation.DataSource = db.Partners
                    .Join(db.PartnersProducts,
                          partner => partner.Id,
                          partnerProduct => partnerProduct.IdPartner,
                          (partner, partnerProduct) => new { Partner = partner, PartnerProduct = partnerProduct })
                    .Where(x => x.PartnerProduct.IdPartner == partnerId);*/

            var partners = db.PartnersProducts
                .Include(i => i.Product)
                .ThenInclude(i=>i.TypeOfProduct)
                .Where(w => w.IdPartner == partnerId)
                .Select(s => new 
                {
                    s.IdPartner,
                    s.Partner.NamePartner,
                    s.Product.TypeOfProduct.TypeOfProduct1,
                    s.IdProduct,
                    s.Product.NameProduct,
                    s.Product.Article,
                    s.Product.MinCostForPartner,
                    s.Count,
                    s.DateOfSale
                }).ToList();
            this.dataGridViewRealisation.DataSource = partners;
            this.dataGridViewRealisation.Columns["IdPartner"].Visible = false;
            this.dataGridViewRealisation.Columns["IdProduct"].Visible = false;

        }

    }
}
