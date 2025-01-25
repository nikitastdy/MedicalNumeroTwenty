using System;
using System.Collections.Generic;

namespace MedicalNumeroTwenty.Models;

public partial class Administrator
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
