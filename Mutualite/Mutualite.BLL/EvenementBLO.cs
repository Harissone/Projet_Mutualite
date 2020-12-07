using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BLL
{
    public class EvenementBLO
    {
        EvenementDAO evenementRepo;
        public EvenementBLO(string dbFolder)
        {
            evenementRepo = new EvenementDAO(dbFolder);
        }
        public void CreateEvenement(Evenement evenement)
        {
            evenementRepo.Add(evenement);
        }
        public void DeleteEvenement(Evenement evenement)
        {
            evenementRepo.Remove(evenement);
        }
        public IEnumerable<Evenement> GetAllEvenements()
        {
            return evenementRepo.Find();
        }
        public IEnumerable<Evenement> GetByTitre(string titre)
        {
            return evenementRepo.Find(x => x.Titre == titre);
        }
        public IEnumerable<Evenement> GetBy(Func<Evenement, bool> predicate)
        {
            return evenementRepo.Find(predicate);
        }
        public void EditEvenement(Evenement oldEvenement, Evenement newEvenement)
        {
            evenementRepo.Set(oldEvenement, newEvenement);
        }
    }
}
