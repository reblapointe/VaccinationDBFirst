using System;
using System.Collections.Generic;

namespace VaccinationDBFirst.Modeles;

public partial class Vaccin
{
    public int VaccinId { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Dose> Doses { get; set; } = new List<Dose>();
}
