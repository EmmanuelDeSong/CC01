using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "y";
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------Creation d'une carte---------------------");
                Console.Write("entrer le nom:\t");
                String Nom = Console.ReadLine();
                Console.Write("entrer le prenom:\t");
                String Prenom = Console.ReadLine();
                Console.Write("entrer le Matricule:\t");
                String Matricule = Console.ReadLine();
                Console.Write("entrer le Ecole:\t");
                String Ecole = Console.ReadLine();
                Console.Write("entrer le Date de naissance:\t");
                String Datedenaissance = Console.ReadLine();
                Console.Write("entrer le Ville:\t");
                String Ville = Console.ReadLine();
                Console.Write("entrer le Numero de Telephone:\t");
                String Numerodetelephone = Console.ReadLine();

                Eleve eleve = new Eleve(Nom, Prenom, Matricule, Ecole, Datedenaissance, Ville, Numerodetelephone);
                EleveBLO eleveBLO = new EleveBLO();
                

                IEnumerable<Eleve> eleves = eleveBLO.ListeDesEleves();

                foreach (Eleve p in eleves)
                {
                    Console.WriteLine($"{p.Nom}\t{p.Prenom}");

                }

                Console.WriteLine("Creer une nouvelle carte?[y/n]:");
                choice = Console.ReadLine();
            }
            while (choice.ToLower() != "n");

            Console.ReadKey();

        }
    }
}
