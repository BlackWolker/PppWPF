using System;
using System.Collections.Generic;

namespace PPE.DBLib.Class;

public partial class Reservation
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int PackId { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public int Quantity { get; set; }

    public bool? Renew { get; set; }

    public virtual User Customer { get; set; } = null!;

    public virtual Pack Pack { get; set; } = null!;

    public virtual ICollection<Unite> Unites { get; set; } = new List<Unite>();
}
