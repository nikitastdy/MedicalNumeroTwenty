using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class AfraidCompany
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string Rs { get; set; } = null!;

    public string Bik { get; set; } = null!;

    public int Buhgalterid { get; set; }

    public virtual Buhgalter Buhgalter { get; set; } = null!;

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
