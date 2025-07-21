using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string? RegionName { get; set; }

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
