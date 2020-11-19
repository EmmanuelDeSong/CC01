using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EleveBLO
    {
        EleveDAO eleveRepo;

        public EleveBLO()
        {
            eleveRepo = new EleveDAO();
        }

        public void NouvelEleve(Eleve eleve)
        {
            eleveRepo.Add(eleve);
        }

        public void RetirerEleve(Eleve eleve)
        {
            eleveRepo.Remove(eleve);
        }
    }
}
