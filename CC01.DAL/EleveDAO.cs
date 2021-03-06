﻿using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{

    public class EleveDAO
    {
        private static List<Eleve> elèves;
        private const string FILE_NAME = @"eleves.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EleveDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    elèves = JsonConvert.DeserializeObject<List<Eleve>>(json);
                }
            }
            if (elèves == null)
            {
                elèves = new List<Eleve>();
            }
        }

        public void Set(Eleve oldEtudiant, Eleve newEtudiant)
        {
            var oldIndex = elèves.IndexOf(oldEtudiant);
            var newIndex = elèves.IndexOf(newEtudiant);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The student exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This Student identified already exists !");
            elèves[oldIndex] = newEtudiant;
            Save();
        }

        public void Add(Eleve etudiant)
        {
            var index = elèves.IndexOf(etudiant);
            if (index >= 0)
                throw new DuplicateNameException("This Student identified already exists !");
            elèves.Add(etudiant);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(elèves);
                sw.WriteLine(json);
            }
        }

        public void Remove(Eleve etudiant)
        {
            elèves.Remove(etudiant);
            Save();
        }

        public IEnumerable<Eleve> Find()
        {
            return new List<Eleve>(elèves);
        }

        public IEnumerable<Eleve> Find(Func<Eleve, bool> predicate)
        {
            return new List<Eleve>(elèves.Where(predicate).ToArray());
        }
    }
}
