using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    public class Membre
    {
        public string Nom { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }

        public Membre(string nom, int telephone, string email)
        {
            Nom = nom;
            Telephone = telephone;
            Email = email;
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
