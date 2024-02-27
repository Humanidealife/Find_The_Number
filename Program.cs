// See https://aka.ms/new-console-template for more information
using System;

namespace Find_The_Number // Remplacez MonNamespace par le nom de votre namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Jeu du nombre mystère";
            Random random = new Random();
                int nombreMystere = random.Next(1, 101);
                int nombreEssais = 0;
                int monNombre = 0;

                while (monNombre!=nombreMystere)
                {
                  Console.WriteLine("Entrez un nombre entre 1 et 100: ");
                  try
                  {
                    monNombre = int.Parse(Console.ReadLine());
                    if(monNombre > nombreMystere)
                    {
                      Console.WriteLine($"{monNombre} est trop grand que le nombre mystère");
                      nombreEssais++;
                    }
                    else if (monNombre < nombreMystere)
                    {
                      Console.WriteLine($"{monNombre} est trop petit que le bombre mystère");
                      nombreEssais++;
                    }
                  }
                  catch
                  {
                    Console.WriteLine("Vous n'avez pas entré un nomre valide, veillez réessayer.");
                  }
                }
                nombreEssais++;
                Console.WriteLine($"Bravo, vous avez trouvé le nombre mystère en {nombreEssais} fois !");
                
            Console.ReadKey();
        }
    }
}
