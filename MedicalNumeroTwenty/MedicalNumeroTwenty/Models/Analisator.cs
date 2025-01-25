using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class Analisator
{
    public int Id { get; set; }

    public DateTime Orderdate { get; set; }

    public DateTime Workdate { get; set; }

    public int WorkSeconds { get; set; }
}
