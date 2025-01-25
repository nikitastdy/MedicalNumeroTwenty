using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class Action
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public string Code { get; set; } = null!;

    public DateTime Datedebt { get; set; }

    public string Middledrift { get; set; } = null!;

    public int Orderid { get; set; }

    public string Orderstatus { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
