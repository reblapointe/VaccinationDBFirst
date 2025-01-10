using System;
using System.Collections.Generic;

namespace VaccinationDBFirst.Modeles;

public partial class Immunisation
{
    public int ImmunisationId { get; set; }

    public DateTime Date { get; set; }

    public string Nampatient { get; set; } = null!;

    public string Discriminator { get; set; } = null!;

    public string? NomVariant { get; set; }

    public bool? EstSevere { get; set; }

    public int? VaccinId { get; set; }

    public virtual Vaccin? Vaccin { get; set; }
}
