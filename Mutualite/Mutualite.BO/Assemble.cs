using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    public class Assemble
    {
        public string Hote { get; set; }
        public DateTime DateAssemble { get; set; }
        public DateTime HeureAssemble { get; set; }
        public string TypeAssemble { get; set; }
        public string SanctionRetard { get; set; }
        public string SanctionAbsence { get; set; }

        public Assemble(string hote, DateTime dateAssemble, DateTime heureAssemble, string typeAssemble, string sanctionRetard, string sanctionAbsence)
        {
            Hote = hote;
            DateAssemble = dateAssemble;
            HeureAssemble = heureAssemble;
            TypeAssemble = typeAssemble;
            SanctionRetard = sanctionRetard;
            SanctionAbsence = sanctionAbsence;
        }
    }
}
