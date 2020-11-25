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
        public EleveBLO(string dbFolder)
        {
            eleveRepo = new EleveDAO(dbFolder);
        }
        public void CreateEleve(Eleve eleve)
        {
            eleveRepo.Add(eleve);
        }

        public void DeleteEleve(Eleve eleve)
        {
            eleveRepo.Remove(eleve);
        }


        public IEnumerable<Eleve> GetAllEleves()
        {
            return eleveRepo.Find();
        }


        public IEnumerable<Eleve> GetByMatricule(string matricule)
        {
            return eleveRepo.Find(x => x.Matricule == matricule);
        }

        public IEnumerable<Eleve> GetBy(Func<Eleve, bool> predicate)
        {
            return eleveRepo.Find(predicate);
        }

        public void EditEtudiant(Eleve oldEleve, Eleve newEleve)
        {
            eleveRepo.Set(oldEleve, newEleve);
        }
    }
}
