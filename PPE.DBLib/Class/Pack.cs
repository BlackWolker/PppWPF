using System;
using System.Collections.Generic;

namespace PPE.DBLib.Class;

public partial class Pack
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Price { get; set; }

    public string? PicturePath { get; set; }

    public int NbSlot { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
