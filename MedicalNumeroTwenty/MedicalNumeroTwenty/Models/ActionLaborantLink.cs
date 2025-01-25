using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class ActionLaborantLink
{
    public int Id { get; set; }

    public int Actionid { get; set; }

    public int Laborantid { get; set; }
}
