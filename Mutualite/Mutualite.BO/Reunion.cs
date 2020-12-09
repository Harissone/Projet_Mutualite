using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    [Serializable]
    public class Reunion
    {
        public string NomReunion { get; set; }
        public string DescriptionTontine { get; set; }
        public string TypeTontine { get; set; }
        public int MontantMinimum { get; set; }
        public DateTime DateTontine { get; set; }
        public int Penalite { get; set; }

        public Reunion()
        {

        }

        public Reunion(string nomReunion, string descriptionTontine, string typeTontine, int montantMinimum, DateTime dateTontine, int penalite)
        {
            NomReunion = nomReunion;
            DescriptionTontine = descriptionTontine;
            TypeTontine = typeTontine;
            MontantMinimum = montantMinimum;
            DateTontine = dateTontine;
            Penalite = penalite;
        }
        public override bool Equals(object obj)
        {
            return obj is Reunion product &&
                   NomReunion.Equals(product.NomReunion, StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(NomReunion);
        }
    }
}
