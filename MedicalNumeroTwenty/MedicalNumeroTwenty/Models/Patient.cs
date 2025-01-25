using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class Patient
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public DateTime Birth { get; set; }

    public int Passportserial { get; set; }

    public int Passportcode { get; set; }

    public string Phone { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public int Polyscode { get; set; }

    public string Polystype { get; set; } = null!;

    public int Afraidcompanyid { get; set; }

    public virtual AfraidCompany Afraidcompany { get; set; } = null!;
}
