using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
   public class Caisse
    {
        public string NameMem { get; set; }
        public DateTime DateVersement { get; set; }
        public int Montant { get; set; }

        public Caisse()
        {

        }

        public Caisse(string namememb, DateTime datevers, int montant)
        {
            NameMem = namememb;
            DateVersement = datevers;
            Montant = montant;
        }
    }
}
