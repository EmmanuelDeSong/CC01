using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Eleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Matricule { get; set; }
        public string Ecole { get; set; }
        public string Datedenaissance { get; set; }
        public string Ville { get; set; }
       

        public Eleve()
        {

        }

        public Eleve(string nom, string prenom, string matricule, string ecole, string datedenaissance, string ville)
        {
            Nom = nom;
            Prenom = prenom;
            Matricule = matricule;
            Ecole = ecole;
            Datedenaissance = datedenaissance;
            Ville = ville;
           
        }

        public override bool Equals(object obj)
        {
            return obj is Eleve eleve &&
                   Matricule == eleve.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
