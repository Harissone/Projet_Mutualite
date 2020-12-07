using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    public class Evenement
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public int Montant { get; set; }

        public Evenement(string titre, string description, DateTime date, string lieu, int montant)
        {
            Titre = titre;
            Description = description;
            Date = date;
            Lieu = lieu;
            Montant = montant;
        }
        public override bool Equals(object obj)
        {
            return obj is Evenement product &&
                   Titre.Equals(product.Titre, StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Titre);
        }
    }
}
