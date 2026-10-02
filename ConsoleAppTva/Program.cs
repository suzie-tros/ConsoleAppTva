using System.Runtime.CompilerServices;

namespace ConsoleAppTva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal prixHorsTaxes = 1m;
            const decimal Tva = 0.20m;

            while (prixHorsTaxes != 0)
            {
                Console.WriteLine("Saisie du prix hors taxes :");
                prixHorsTaxes = decimal.Parse(Console.ReadLine());
                decimal prixTTC = prixHorsTaxes * (1 + Tva);
                
                Console.WriteLine($"Le prix TTC est : {prixTTC}");
                Console.WriteLine($"La TVA est de : {prixHorsTaxes * Tva}");
            }
            
        }
    }
}
