using Mutualite.BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;

namespace Mutualite.DAL
{
    public class ReunionDAO
    {
        private static List<Reunion> reunions;
        private const string FILE_NAME = @"products.json";
        private readonly string dbFolder;
        private FileInfo file;
        public ReunionDAO(string dbFolder)
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
                    reunions = JsonConvert.DeserializeObject<List<Reunion>>(json);
                }
            }
            if (reunions == null)
            {
                reunions = new List<Reunion>();
            }
        }
        public void Set(Reunion oldReunion, Reunion newReunion)
        {
            var oldIndex = reunions.IndexOf(oldReunion);
            var newIndex = reunions.IndexOf(newReunion);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The meeting doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This meeting name already exists !");
            reunions[oldIndex] = newReunion;
            Save();
        }
        public void Add(Reunion reunion)
        {
            var index = reunions.IndexOf(reunion);
            if (index >= 0)
                throw new DuplicateNameException("This meeting name already exists !");
            reunions.Add(reunion);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(reunions);
                sw.WriteLine(json);
            }
        }
        public void Remove(Reunion reunion)
        {
            reunions.Remove(reunion);//base sur Reunion.Equals redefini
            Save();
        }
        public IEnumerable<Reunion> Find()
        {
            return new List<Reunion>(reunions);
        }
    }
}
