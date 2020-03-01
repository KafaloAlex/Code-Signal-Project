//Ce programme demande à l'utilisateur d'entrer une date comprise entre 1 et 2005 puis à quel siècle correspond cette année
using System;

namespace century
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entrez une année comprise entre 1 et 2005 :");
                int year = Convert.ToInt32(Console.ReadLine());

                if (year < 1 && year > 2005)
                    Console.WriteLine("Vous devez entrer une date comprise entre 1 et 2005");
                else if (year >= 1 && year < 100)
                    Console.WriteLine("Vous êtes au premier siècle");
                else
                {
                    int century = centuryFromYear(year);
                    Console.WriteLine("L'{0} correspond au {1} siècle", year, century);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Entrez une année correcte svp!!");
            }
        }

        static int centuryFromYear(int x)
        {
            return (int)(x / 100) + ((x % 100 == 0) ? 0 : 1);
        }
    }
}
