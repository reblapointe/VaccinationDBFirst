using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDBFirst.Modeles
{
    public partial class Immunisation
    {
        public override string ToString()
        {
            return $"Immunisation ID: {ImmunisationId}, Date: {Date:yyyy-MM-dd}, Patient: {Nampatient}, " +
              $"Discriminator: {Discriminator}, Variant: {NomVariant ?? "N/A"}, Severe: {(EstSevere.HasValue ? EstSevere.Value.ToString() : "N/A")}, " +
              $"Vaccin ID: {(VaccinId.HasValue ? VaccinId.Value.ToString() : "N/A")}";
        }
    }
}
