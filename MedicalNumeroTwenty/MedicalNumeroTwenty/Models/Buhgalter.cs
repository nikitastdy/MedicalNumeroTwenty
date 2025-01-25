using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class Buhgalter
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime Logindate { get; set; }

    public virtual ICollection<AfraidCompany> AfraidCompanies { get; set; } = new List<AfraidCompany>();
}
