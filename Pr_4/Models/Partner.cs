using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class Partner
{
    public int Id { get; set; }

    public short IdTypePartner { get; set; }

    public string NamePartner { get; set; } = null!;

    public string LegalAddress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string DirectorFullName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public float Rating { get; set; }


    public virtual TypePartner IdTypePartnerNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
