using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class Utilisateur
{
    public int Id { get; set; }

    public string Info { get; set; } = null!;
}
