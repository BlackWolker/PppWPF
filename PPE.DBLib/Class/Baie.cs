using System;
using System.Collections.Generic;

namespace PPE.DBLib.Class;

public partial class Baie
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int NbSpot { get; set; }

    public virtual ICollection<Unite> Unites { get; set; } = new List<Unite>();
}
