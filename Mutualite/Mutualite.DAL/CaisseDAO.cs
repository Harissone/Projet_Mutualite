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
    public class CaisseDAO
    {
        private static List<Caisse> caisses;
        private const string FILE_NAME = @"cycles.json";
        private readonly string dbFolder;
        private FileInfo file;
        public CaisseDAO(string dbFolder)
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
                    caisses = JsonConvert.DeserializeObject<List<Caisse>>(json);
                }
            }
            if (caisses == null)
            {
                caisses = new List<Caisse>();
            }
        }
        public void Set(Caisse oldCaisse, Caisse newCaisse)
        {
            var oldIndex = caisses.IndexOf(oldCaisse);
            var newIndex = caisses.IndexOf(newCaisse);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The transaction doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This transaction type meeting already exists !");
            caisses[oldIndex] = newCaisse;
            Save();
        }
        public void Add(Caisse caisse)
        {
            var index = caisses.IndexOf(caisse);
            if (index >= 0)
                throw new DuplicateNameException("This transaction already exists !");
            caisses.Add(caisse);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(caisses);
                sw.WriteLine(json);
            }
        }
        public void Remove(Caisse caisse)
        {
            caisses.Remove(caisse);//base sur Cycle.Equals redefini
            Save();
        }
        public IEnumerable<Caisse> Find()
        {
            return new List<Caisse>(caisses);
        }
        public IEnumerable<Caisse> Find(Func<Caisse, bool> predicate)
        {
            return new List<Caisse>(caisses.Where(predicate).ToArray());
        }
    }
}
