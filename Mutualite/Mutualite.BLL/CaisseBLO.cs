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
        public void AddPayment(Caisse caisse)
        {
            caisseRepo.Add(caisse);
        }
        public void DeletePayment(Caisse caisse)
        {
            caisseRepo.Remove(caisse);
        }
        public IEnumerable<Caisse> GetAllPayment()
        {
            return caisseRepo.Find();
        }
        public IEnumerable<Caisse> GetByDateVersement(DateTime datevers)
        {
            return caisseRepo.Find(x => x.DateVersement == datevers);
        }
        public IEnumerable<Caisse> GetBy(Func<Caisse, bool> predicate)
        {
            return caisseRepo.Find(predicate);
        }
        public void EditPayment(Caisse oldCaisse, Caisse newCaisse)
        {
            caisseRepo.Set(oldCaisse, newCaisse);
        }
    }
}

