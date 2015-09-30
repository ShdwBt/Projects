using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_exercice_2
{
    class Program
    {
        static string str;
        static int[] tab = new int[5];
        static int i;

        static void Main(string[] args)
        {
            
            do
            {
                MainCommande();
            } while (str != "q");

        }

        private static void MainCommande()
        {
            Console.WriteLine("Commande ?");
            str = Console.ReadLine();
            ChoixCommande();
        }

        private static void ChoixCommande()
        {
            switch (str)
            {
                case "e":
                    AjoutCommande();
                    break;

                case "d":
                    ListerCommande();
                    break;

                case "s":
                    TriCommandeASC();
                    break;

                case "r":
                    TriCommandeDESC();
                    break;
            }
        }

        private static void TriCommandeDESC()
        {
            Array.Reverse(tab);
            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Commande N°{0} valeur = {1}", i + 1, tab[i]);
            }
        }

        private static void TriCommandeASC()
        {
            Array.Sort(tab);
            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Commande N°{0} valeur = {1}", i + 1, tab[i]);
            }
        }

        private static void ListerCommande()
        {
            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Commande N°{0} valeur = {1}", i + 1, tab[i]);
            }
        }

        private static void AjoutCommande()
        {
            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Veuillez entrer la valeur N°{0}", i + 1);
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Toutes les valeurs ont étés entrées");
        }
    }
}
