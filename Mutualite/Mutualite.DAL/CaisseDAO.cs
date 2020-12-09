using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutualite.BO;
using Newtonsoft.Json;

namespace Mutualite.DAL
{
    public class CaisseDAO
    {
        private static List<Caisse> caisses;
        private const string FILE_NAME = @"caisse.json";
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
            caisses[oldIndex] = newCaisse;
            Save();
        }
        public void Add(Caisse caisse)
        {
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
            caisses.Remove(caisse);//base sur Evenement.Equals redefini
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

