using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    public class Cycle
    {
        public string DureeCycle { get; set; }
        public string FrequenceAssemble { get; set; }
        public string TypeRencontre { get; set; }
        public string JourSemaine { get; set; }
        public DateTime DatePremiereRencontre { get; set; }
        public DateTime HeureAssemble { get; set; }
        public int SanctionRetard { get; set; }
        public int SanctionAbsence { get; set; }

        public Cycle(string dureeCycle, string frequenceAssemble, string typeRencontre, string jourSemaine, DateTime datePremiereRencontre, DateTime heureAssemble, int sanctionRetard, int sanctionAbsence)
        {
            DureeCycle = dureeCycle;
            FrequenceAssemble = frequenceAssemble;
            TypeRencontre = typeRencontre;
            JourSemaine = jourSemaine;
            DatePremiereRencontre = datePremiereRencontre;
            HeureAssemble = heureAssemble;
            SanctionRetard = sanctionRetard;
            SanctionAbsence = sanctionAbsence;

        }
        public override bool Equals(object obj)
        {
            return obj is Cycle cycle &&
                   DureeCycle.Equals(cycle.DureeCycle, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(DureeCycle);
        }
    }
}
