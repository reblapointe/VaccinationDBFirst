using System;
using System.Collections.Generic;

namespace VaccinationDBFirst.Modeles;

public partial class Dose
{
    public int DoseId { get; set; }

    public DateTime Date { get; set; }

    public string Nampatient { get; set; } = null!;

    public int? VaccinId { get; set; }

    public virtual Vaccin? Vaccin { get; set; }
}
