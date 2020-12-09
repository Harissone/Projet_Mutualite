using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutualite.BLL;
using Mutualite.BO;

namespace Mutualite.DAL
{
    public class CaisseBLO
    {
        CaisseDAO caisseRepo;
        public CaisseBLO(string dbFolder)
        {
            caisseRepo = new CaisseDAO(dbFolder);
        }
        public void CreateCaisse(Caisse caisse)
        {
            caisseRepo.Add(caisse);
        }
        public void DeleteCaisse(Caisse caisse)
        {
            caisseRepo.Remove(caisse);
        }
        public IEnumerable<Caisse> GetAllCaisse()
        {
            return caisseRepo.Find();
        }
        public IEnumerable<Caisse> GetByDateVersement(string compte)
        {
            return caisseRepo.Find(x => x.Compte == compte);
        }
        public IEnumerable<Caisse> GetBy(Func<Caisse, bool> predicate)
        {
            return caisseRepo.Find(predicate);
        }
        public void EditCaisse(Caisse oldCaisse, Caisse newCaisse)
        {
            caisseRepo.Set(oldCaisse, newCaisse);
        }
    }
}

