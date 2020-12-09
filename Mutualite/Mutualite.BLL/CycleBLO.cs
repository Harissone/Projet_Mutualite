using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BLL
{
    public class CycleBLO
    {
        CycleDAO cycleRepo;
        public CycleBLO(string dbFolder)
        {
            cycleRepo = new CycleDAO(dbFolder);
        }
        public void CreateCycle(Cycle cycle)
        {
            cycleRepo.Add(cycle);
        }
        public void DeleteCycle(Cycle cycle)
        {
            cycleRepo.Remove(cycle);
        }
        public IEnumerable<Cycle> GetAllCycles()
        {
            return cycleRepo.Find();
        }
        public IEnumerable<Cycle> GetByTypeRencontre(string dureeCycle)
        {
            return cycleRepo.Find(x => x.DureeCycle == dureeCycle);
        }
        public void EditCycle(Cycle oldCycle, Cycle newCycle)
        {
            cycleRepo.Set(oldCycle, newCycle);
        }


    }
}
