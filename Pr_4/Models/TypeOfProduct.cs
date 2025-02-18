using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class TypeOfProduct
{
    public int Id { get; set; }

    public string TypeOfProduct1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
