
using VaccinationDBFirst.Modeles;

namespace VaccinationDBFirst
{
    internal class Program
    {
        static void Main(string[] _)
        {
            VaccinationContext context = new();

            Console.WriteLine("Les types de vaccin.");
            foreach (Vaccin type in context.Vaccins)
                Console.WriteLine($"{type.VaccinId}. {type.Nom}");

            Console.WriteLine();
            Console.WriteLine("Les doses.");
            foreach (Dose dose in context.Doses)
                Console.WriteLine($"{dose.DoseId}. Patient : {dose.Nampatient}. Date : {dose.Date}. Type : {dose.Vaccin?.Nom}");
        }

    }
}
