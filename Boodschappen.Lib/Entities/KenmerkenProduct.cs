using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boodschappen.Lib.Services;

namespace Boodschappen.Lib.Entities
{
    public class KenmerkenProduct
    {
        public string ProductNaam { get; set; }
        public Afdelingen Afdeling { get; set; }
        public int Aantal { get; set; }
        public StukOfKg StukOfGewicht { get; set; }
        public int PrijsPerStuk { get; set; }
        public int Totaal { get; set; }

        public KenmerkenProduct (string productNaam, Afdelingen afdeling, int aantal, StukOfKg stukOfGewicht, int prijsPerStuk, int totalePrijs)
        {
            ProductNaam = productNaam;
            Afdeling = afdeling;
            Aantal = aantal;
            StukOfGewicht = stukOfGewicht;
            PrijsPerStuk = prijsPerStuk;
            Totaal = totalePrijs;
        }

        public override string ToString()
        {
            return $"{ProductNaam} Aantal : {Aantal}";
        
        }
    }
}
