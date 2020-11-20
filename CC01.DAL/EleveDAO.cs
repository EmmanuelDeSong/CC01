using CC01.BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
    public class EleveDAO
    {
        public static List<Eleve> eleves;
        private const string FILE_NAME = @"data/eleves.json";

        public EleveDAO()
        {
            FileInfo file = new FileInfo(FILE_NAME);

            if(!file.Directory.Exists)
            {
                file.Directory.Create();
            }

            if(!file.Exists)
            {
                file.Create().Close();
            }

             void Add(Eleve eleve)
            {
                eleves.Add(eleve);
                
            }
            
        }

        
    }
}
