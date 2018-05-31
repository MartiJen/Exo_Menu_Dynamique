using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string[] menusItems = { "Choix utilisateur", "Creer contact", "Supprimer un message", "deplacer un dossier", "Vider la corbeille, ", "Quitter" };

        static void Main(string[] args)
        {

            int menuItem = NaviguerMenuDynamique("0125");

            Console.WriteLine("Vous avez choisi : " + menuItem);

            Console.ReadLine();
        }

        static int NaviguerMenuDynamique(string dynamicItems)
        {
            int i;

            foreach (char c in dynamicItems)
            {
                i = (int)char.GetNumericValue(c);
                Console.Write(i + ". ");
                Console.WriteLine(menusItems[i]);
            }

            int numeroMenuValide = -1;
            while (numeroMenuValide == -1)
            {
                Console.WriteLine();
                Console.WriteLine("Entrer votre choix !");

                string saisie = Console.ReadLine();
                int numeroMenu = int.Parse(saisie);

                foreach (char c in dynamicItems)
                {
                    i = (int)char.GetNumericValue(c);
                    //Console.Write(i + " a ");

                    if (i == numeroMenu) { numeroMenuValide = i; break; }
                }

                if (numeroMenuValide == -1) Console.WriteLine("Choix Invalide !");
            }

            return numeroMenuValide;
        }

    }
}
