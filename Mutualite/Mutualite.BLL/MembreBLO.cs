using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BLL
{
    public class MembreBLO
    {
        MembreDAO membreRepo;

        public MembreBLO()
        {

        }

        public MembreBLO(string dbFolder)
        {
            membreRepo = new MembreDAO(dbFolder);
        }
        public void CreateMembre(Membre membre)
        {
            membreRepo.Add(membre);
        }
        public void DeleteMembre(Membre membre)
        {
            membreRepo.Remove(membre);
        }
        public IEnumerable<Membre> GetAllMembres()
        {
            return membreRepo.Find();
        }
        public IEnumerable<Membre> GetByNom(string nom)
        {
            return membreRepo.Find(x => x.Nom == nom);
        }
        public IEnumerable<Membre> GetBy(Func<Membre, bool> predicate)
        {
            return membreRepo.Find(predicate);
        }
        public void EditMembre(Membre oldMembre, Membre newMembre)
        {
            membreRepo.Set(oldMembre, newMembre);
        }
    }
}
