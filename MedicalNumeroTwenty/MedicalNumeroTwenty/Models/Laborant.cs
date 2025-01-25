using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class Laborant
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public DateTime Logindate { get; set; }
}
