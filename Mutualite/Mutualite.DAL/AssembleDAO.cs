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
    public class AssembleDAO
    {
        private static List<Assemble> assembles;
        private const string FILE_NAME = @"assembles.json";
        private readonly string dbFolder;
        private FileInfo file;
        public AssembleDAO(string dbFolder)
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
                    assembles = JsonConvert.DeserializeObject<List<Assemble>>(json);
                }
            }
            if (assembles == null)
            {
                assembles = new List<Assemble>();
            }
        }
        public void Set(Assemble oldAssemble, Assemble newAssemble)
        {
            var oldIndex = assembles.IndexOf(oldAssemble);
            var newIndex = assembles.IndexOf(newAssemble);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The assembly doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This assembly hote already exists !");
            assembles[oldIndex] = newAssemble;
            Save();
        }
        public void Add(Assemble assemble)
        {
            var index = assembles.IndexOf(assemble);
            if (index >= 0)
                throw new DuplicateNameException("This assembly hote already exists !");
            assembles.Add(assemble);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(assembles);
                sw.WriteLine(json);
            }
        }
        public void Remove(Assemble assemble)
        {
            assembles.Remove(assemble);//base sur Assemble.Equals redefini
            Save();
        }
        public IEnumerable<Assemble> Find()
        {
            return new List<Assemble>(assembles);
        }
        public IEnumerable<Assemble> Find(Func<Assemble, bool> predicate)
        {
            return new List<Assemble>(assembles.Where(predicate).ToArray());
        }
    }
}
