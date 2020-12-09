using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    [Serializable]
    public class Membre
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }

        public Membre(string nom, int telephone, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Email = email;
            Telephone = telephone;
           
        }
        public override bool Equals(object obj)
        {
            return obj is Membre membre &&
                   Nom.Equals(membre.Nom, StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }
}
