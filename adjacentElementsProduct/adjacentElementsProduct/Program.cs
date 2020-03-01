//Ce programme permet de renvoyer le maximum du produit des éléments adjacents d'un tableau fournit par l'utilisateur 
using System;
using System.Collections.Generic;
using System.Linq;

namespace adjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la taille du tableau : ");
            var taille = Console.ReadLine();
            var retour = initTab(taille);
            Console.WriteLine(Product(retour));
            Console.WriteLine();
        }

        static int[] initTab(string taille)//Fonction d'initialisation du tableau
        {
            int[] tableau;                                          
            tableau = new int[Convert.ToInt32(taille)];             
            Console.Write(" Votre tableau contiendra " + tableau.Length + " caracteres");
            Console.WriteLine();
            int i = 0;
            string saisie_tableau;
            Console.WriteLine(" Pour ajouter un élément au tableau, saississez-le puis appuyer sur la touche 'Entrée'");

            while (i < Convert.ToDouble(taille))
            {
                Console.WriteLine();
                Console.Write("Entrez un nombre :");
                saisie_tableau = Console.ReadLine();
                int valeur = Convert.ToInt32(saisie_tableau);
                tableau[i] = valeur;
                i++;
            }

            Console.Write("\nVoici votre tableau :");
            Console.Write("[");
            foreach (var n in tableau)
            {
                Console.Write(" "+n+" ");
            }
            Console.Write("]\n\n");

            return tableau;
        }

        static int Product(int[] array)//Fonction du produit des éléments adjancents du tableau
        {
            List<int> listArray = new List<int>();

            for(int i =0; i < array.Length-1; i++)
            {
                var result = array[i] * array[i + 1];
                listArray.Add(result);
            }

            var max = listArray.Max();//Cherche le maximum

            Console.Write("Le Maximum du produit des éléments adjacents du tableau est : " );

            return max;
        }
    }
}

