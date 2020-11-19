using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Eleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Matricule { get; set; }
        public string Ecole { get; set; }
        public string Datedenaissance { get; set; }
        public string Ville { get; set; }
        public int Numerodetelephone { get; set; }

        public Eleve(string nom, string prenom, string matricule, string ecole, string datedenaissance, string ville, int numerodetelephone)
        {
            Nom = nom;
            Prenom = prenom;
            Matricule = matricule;
            Ecole = ecole;
            Datedenaissance = datedenaissance;
            Ville = ville;
            Numerodetelephone = numerodetelephone;
        }
    }
}
