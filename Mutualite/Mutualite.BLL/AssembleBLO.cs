using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BLL
{
    public class AssembleBLO
    {
        AssembleDAO assembleRepo;
        public AssembleBLO(string dbFolder)
        {
            assembleRepo = new AssembleDAO(dbFolder);
        }
        public void CreateAssemble(Assemble assemble)
        {
            assembleRepo.Add(assemble);
        }
        public void DeleteAssemble(Assemble assemble)
        {
            assembleRepo.Remove(assemble);
        }
        public IEnumerable<Assemble> GetAllAssembles()
        {
            return assembleRepo.Find();
        }
        public IEnumerable<Assemble> GetByHote(string hote)
        {
            return assembleRepo.Find(x => x.Hote == hote);
        }
        public IEnumerable<Assemble> GetBy(Func<Assemble, bool> predicate)
        {
            return assembleRepo.Find(predicate);
        }
        public void EditAssemble(Assemble oldAssemble, Assemble newAssemble)
        {
            assembleRepo.Set(oldAssemble, newAssemble);
        }

    }
}
