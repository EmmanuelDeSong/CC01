using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EcoleBLO
    {
        EcoleDAO ecoleRepo;
        public EcoleBLO(string dbFolder)
        {
            ecoleRepo = new EcoleDAO(dbFolder);
        }
        public void CreateEcole(Ecole ecole)
        {
            ecoleRepo.Add(ecole);
        }

        public void DeleteEcole(Ecole ecole)
        {
            ecoleRepo.Remove(ecole);
        }


        public IEnumerable<Ecole> GetAllEcole()
        {
            return ecoleRepo.Find();
        }


        public IEnumerable<Ecole> GetByPostalCode(string boitePostale)
        {
            return ecoleRepo.Find(x => x.BoitePostale == boitePostale);
        }

        public IEnumerable<Ecole> GetBy(Func<Ecole, bool> predicate)
        {
            return ecoleRepo.Find(predicate);
        }

        public void EditEcole(Ecole oldEcole, Ecole newEcole)
        {
            ecoleRepo.Set(oldEcole, newEcole);
        }
    }
}
