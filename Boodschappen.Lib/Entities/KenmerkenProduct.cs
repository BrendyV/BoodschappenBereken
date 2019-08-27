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
        public int Prijs { get; set; }
        public int Totaal { get; set; }

        public KenmerkenProduct (string productNaam, Afdelingen afdeling, int aantal, StukOfKg stukOfGewicht, int prijs, int totalePrijs)
        {
            ProductNaam = productNaam;
            Afdeling = afdeling;
            Aantal = aantal;
            StukOfGewicht = stukOfGewicht;
            Prijs = prijs;
            Totaal = totalePrijs;
        }

        public override string ToString()
        {
            return $"{ProductNaam} Aantal : {Aantal}";
        
        }
    }
}
