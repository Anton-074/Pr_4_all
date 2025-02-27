using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class PartnersProduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Count { get; set; }

    public DateTime DateOfSale { get; set; }


    public virtual Partner Partner { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
