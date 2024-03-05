using System;
using System.Collections.Generic;

namespace PPE.DBLib.Class;

public partial class Unite
{
    public int Id { get; set; }

    public int ReservationIdId { get; set; }

    public int BaieIdId { get; set; }

    public int? NameSpot { get; set; }

    public bool Status { get; set; }

    public virtual Baie BaieId { get; set; } = null!;

    public virtual Reservation ReservationId { get; set; } = null!;
}
