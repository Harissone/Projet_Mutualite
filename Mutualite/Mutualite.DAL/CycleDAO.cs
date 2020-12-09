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
    public class CycleDAO
    {
        private static List<Cycle> cycles;
        private const string FILE_NAME = @"cycles.json";
        private readonly string dbFolder;
        private FileInfo file;
        public CycleDAO(string dbFolder)
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
                    cycles = JsonConvert.DeserializeObject<List<Cycle>>(json);
                }
            }
            if (cycles == null)
            {
                cycles = new List<Cycle>();
            }
        }
        public void Set(Cycle oldCycle, Cycle newCycle)
        {
            var oldIndex = cycles.IndexOf(oldCycle);
            var newIndex = cycles.IndexOf(newCycle);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The cycle doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This cycle type meeting already exists !");
            cycles[oldIndex] = newCycle;
            Save();
        }
        public void Add(Cycle cycle)
        {
            var index = cycles.IndexOf(cycle);
            if (index >= 0)
                throw new DuplicateNameException("This cycle type meeting already exists !");
            cycles.Add(cycle);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(cycles);
                sw.WriteLine(json);
            }
        }
        public void Remove(Cycle cycle)
        {
            cycles.Remove(cycle);//base sur Cycle.Equals redefini
            Save();
        }
        public IEnumerable<Cycle> Find()
        {
            return new List<Cycle>(cycles);
        }
        public IEnumerable<Cycle> Find(Func<Cycle, bool> predicate)
        {
            return new List<Cycle>(cycles.Where(predicate).ToArray());
        }


    }
}
