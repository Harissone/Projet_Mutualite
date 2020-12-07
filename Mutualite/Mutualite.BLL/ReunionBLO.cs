using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BLL
{
    public class ReunionBLO
    {
        ReunionDAO reunionRepo;
        public ReunionBLO(string dbFolder)
        {
            reunionRepo = new ReunionDAO(dbFolder);
        }
        public void CreateReunion(Reunion reunion)
        {
            reunionRepo.Add(reunion);
        }
        public void DeleteReunion(Reunion reunion)
        {
            reunionRepo.Remove(reunion);
        }
        public IEnumerable<Reunion> GetAllReunions()
        {
            return reunionRepo.Find();
        }
        public IEnumerable<Reunion> GetByNomReunion(string NomReunion)
        {
            return reunionRepo.Find(x => x.NomReunion == NomReunion);
        }
        public IEnumerable<Reunion> GetBy(Func<Reunion, bool> predicate)
        {
            return reunionRepo.Find(predicate);
        }
        public void EditReunion(Reunion oldReunion, Reunion newReunion)
        {
            reunionRepo.Set(oldReunion, newReunion);
        }
    }
}
