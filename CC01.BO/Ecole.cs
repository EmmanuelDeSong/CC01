using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Ecole
    {
        public string Nom { get; set; }
        public string BoitePostale { get; set; }
        public long Telephone { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }

        public Ecole()
        {
        }

        public Ecole(string nom, string boitePostale, long telephone, string email, byte[] logo)
        {
            Nom = nom;
            BoitePostale = boitePostale;
            Telephone = telephone;
            Email = email;
            Logo = logo;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom.Equals(ecole.Nom, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }
}
