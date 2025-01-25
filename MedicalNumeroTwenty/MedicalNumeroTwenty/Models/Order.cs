using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime Createdate { get; set; }

    public string Status { get; set; } = null!;

    public int Orderdays { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();
}
