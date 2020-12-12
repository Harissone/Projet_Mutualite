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
    public class MembreDAO
    {
        private static List<Membre> membres;
        private const string FILE_NAME = @"membre.json";
        private readonly string dbFolder;
        private FileInfo file;
        public MembreDAO(string dbFolder)
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
                    membres = JsonConvert.DeserializeObject<List<Membre>>(json);
                }
            }
            if (membres == null)
            {
                membres = new List<Membre>();
            }
        }
        public void Set(Membre oldMembre, Membre newMembre)
        {
            var oldIndex = membres.IndexOf(oldMembre);
            var newIndex = membres.IndexOf(newMembre);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The member doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This member name already exists !");
            membres[oldIndex] = newMembre;
            Save();
        }
        public void Add(Membre membre)
        {
            var index = membres.IndexOf(membre);
            if (index >= 0)
                throw new DuplicateNameException("This member name already exists !");
            membres.Add(membre);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(membres);
                sw.WriteLine(json);
            }
        }
        public void Remove(Membre membre)
        {
            membres.Remove(membre);//base sur Membre.Equals redefini
            Save();
        }
        public IEnumerable<Membre> Find()
        {
            return new List<Membre>(membres);
        }
        public IEnumerable<Membre> Find(Func<Membre, bool> predicate)
        {
            return new List<Membre>(membres.Where(predicate).ToArray());
        }
    }
}
