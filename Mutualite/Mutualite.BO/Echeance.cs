using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    [Serializable]
    public class Echeance
    {
        public int Montant { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public DateTime DelaisPayement { get; set; }

        public Echeance()
        {

        }

        public Echeance(int montant, string titre, string description, DateTime dateDebut, DateTime dateFin, DateTime delaisPayement)
        {
            Montant = montant;
            Titre = titre;
            Description = description;
            DateDebut = dateDebut;
            DateFin = dateFin;
            DelaisPayement = delaisPayement;
        }
        public override bool Equals(object obj)
        {
            return obj is Echeance echeance &&
                   Titre.Equals(echeance.Titre, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Titre);
        }
    }
}
