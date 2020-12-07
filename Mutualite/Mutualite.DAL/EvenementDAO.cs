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
    public class EvenementDAO
    {
        private static List<Evenement> evenements;
        private const string FILE_NAME = @"evenement.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EvenementDAO(string dbFolder)
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
                    evenements = JsonConvert.DeserializeObject<List<Evenement>>(json);
                }
            }
            if (evenements == null)
            {
                evenements = new List<Evenement>();
            }
        }
        public void Set(Evenement oldEvenement, Evenement newEvenement)
        {
            var oldIndex = evenements.IndexOf(oldEvenement);
            var newIndex = evenements.IndexOf(newEvenement);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The evenement doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This evenemt title already exists !");
            evenements[oldIndex] = newEvenement;
            Save();
        }
        public void Add(Evenement evenement)
        {
            var index = evenements.IndexOf(evenement);
            if (index >= 0)
                throw new DuplicateNameException("This evenement title already exists !");
            evenements.Add(evenement);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(evenements);
                sw.WriteLine(json);
            }
        }
        public void Remove(Evenement evenement)
        {
            evenements.Remove(evenement);//base sur Evenement.Equals redefini
            Save();
        }
        public IEnumerable<Evenement> Find()
        {
            return new List<Evenement>(evenements);
        }
        public IEnumerable<Evenement> Find(Func<Evenement, bool> predicate)
        {
            return new List<Evenement>(evenements.Where(predicate).ToArray());
        }
    }
}
