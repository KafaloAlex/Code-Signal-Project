//Un palindrome est un mot dont l'ordre reste le même de gauche à droite et inversement.
//Le programme ramène *True* si le mot est palindrome ,et *False* dans le cas contraire.
using System;
using System.Linq;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entrez un mot");
                string chaine = Console.ReadLine();

                checkPalindrome(chaine);
            }
            catch(Exception)
            {
                Console.WriteLine("Nous avons seulement besoin d'un mot");
            }
        }

        static bool checkPalindrome( string word)
        {
            bool isPalindrome = false;
            String chaineReverse = new string(word.ToCharArray().Reverse().ToArray());

            if (word == chaineReverse)
            {
                isPalindrome = true;
                Console.WriteLine(isPalindrome);
            }  
            else
            {
                isPalindrome = false;
                Console.WriteLine(isPalindrome);
            }
           
            return isPalindrome;
        }
    }
}
