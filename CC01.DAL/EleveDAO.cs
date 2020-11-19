using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.BO;
using Newtonsoft.Json;

namespace CC01.DAL
{
    public class EleveDAO
    {

        private static List<Eleve> eleves;
        private const string FILE_NAME = @"data/Eleve.json";
        private FileInfo file;
        public EleveDAO()
        {
           file = new FileInfo(FILE_NAME);
            if(!file.Directory.Exists)
            {
                file.Directory.Create();
            }

            if(!file.Exists)
            {
                file.Create().Close();
            }

            if(file.Length>0 )
            {
                using(StreamReader sr= new StreamReader(
                    file.FullName))
                {
                    string json = sr.ReadToEnd();
                    eleves = JsonConvert.DeserializeObject<List<Eleve>>
                 (json);

                }

              
            }
            if(eleves==null)
            {
                eleves = new List<Eleve>();
            }


        }
        public void Add(Eleve eleve)
        {
            eleves.Add(eleve);
            Save(eleve);
        }

        private void Save(Eleve eleve)
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(eleve);
                sw.WriteLine(json);
            }
        }

        public void Remove(Eleve eleve)
        {
            eleves.Remove(eleve); //basé sur le matricule de l'élève

            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(eleve);
                sw.WriteLine(json);
            }
        }
    }
}
