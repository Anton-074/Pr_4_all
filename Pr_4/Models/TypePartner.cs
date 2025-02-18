using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class TypePartner
{
    public short Id { get; set; }

    public string TypeOfPartner { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
