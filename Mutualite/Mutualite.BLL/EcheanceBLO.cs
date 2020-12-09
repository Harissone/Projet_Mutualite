using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BLL
{
    public class EcheanceBLO
    {
        EcheanceDAO echeanceRepo;
        public EcheanceBLO(string dbFolder)
        {
            echeanceRepo = new EcheanceDAO(dbFolder);
        }
        public void CreateEcheance(Echeance echeance)
        {
            echeanceRepo.Add(echeance);
        }
        public void DeleteEcheance(Echeance echeance)
        {
            echeanceRepo.Remove(echeance);
        }
        public IEnumerable<Echeance> GetAllEcheance()
        {
            return echeanceRepo.Find();
        }
        public IEnumerable<Echeance> GetByTitre(string titre)
        {
            return echeanceRepo.Find(x => x.Titre == titre);
        }
        public IEnumerable<Echeance> GetBy(Func<Echeance, bool> predicate)
        {
            return echeanceRepo.Find(predicate);
        }
        public void EditEcheance(Echeance oldEcheance, Echeance newEcheance)
        {
            echeanceRepo.Set(oldEcheance, newEcheance);
        }
    }
}
