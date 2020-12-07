using Mutualite.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.DAL
{
    public class EcheanceDAO
    {
        private static List<Echeance> echeances;
        private const string FILE_NAME = @"echeance.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EcheanceDAO(string dbFolder)
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
                    echeances = JsonConvert.DeserializeObject<List<Echeance>>(json);
                }
            }
            if (echeances == null)
            {
                echeances = new List<Echeance>();
            }
        }
        public void Set(Echeance oldEcheance, Echeance newEcheance)
        {
            var oldIndex = echeances.IndexOf(oldEcheance);
            var newIndex = echeances.IndexOf(newEcheance);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The echeance doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This echeance title already exists !");
            echeances[oldIndex] = newEcheance;
            Save();
        }
        public void Add(Echeance echeance)
        {
            var index = echeances.IndexOf(echeance);
            if (index >= 0)
                throw new DuplicateNameException("This echeance title already exists !");
            echeances.Add(echeance);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(echeances);
                sw.WriteLine(json);
            }
        }
        public void Remove(Echeance echeance)
        {
            echeances.Remove(echeance);//base sur Echeance.Equals redefini
            Save();
        }
        public IEnumerable<Echeance> Find()
        {
            return new List<Echeance>(echeances);
        }
        public IEnumerable<Echeance> Find(Func<Echeance, bool> predicate)
        {
            return new List<Echeance>(echeances.Where(predicate).ToArray());
        }
    }
}
