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
            this.db = new SubsystemPartnersContext();
            this.db.Partners.Load();
            this.labelName.Text = this.db.Partners.Local.OrderBy(o => o.Id).Select(s=>s.NamePartner).ElementAt(0);

            
        }
    }
}
