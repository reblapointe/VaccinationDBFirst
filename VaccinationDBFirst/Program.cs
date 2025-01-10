

using VaccinationDBFirst.Modeles;

namespace VaccinationDBFirst
{
    internal class Program
    {
        static void Main(string[] _)
        {
            // Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=VaccinationDefi;Trusted_Connection=True;"  Microsoft.EntityFrameworkCore.SqlServer   -OutputDir Modeles
            VaccinationDefiContext context = new();

            Console.WriteLine("Les types de vaccin.");
            foreach (Vaccin type in context.Vaccins)
                Console.WriteLine($"{type.VaccinId}. {type.Nom}");

            Console.WriteLine();
            Console.WriteLine("Les doses.");
            foreach (Immunisation i in context.Immunisations)
                Console.WriteLine(i);
            
        }

    }
}
