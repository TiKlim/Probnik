using System;
using System.Collections.Generic;

namespace Probnik.Models;

public partial class Manufacture
{
    public int Id { get; set; }

    public string? ManufacturName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
