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
        public string Afdeling { get; set; }
        public int Aantal { get; set; }
        public string StukOfGewicht { get; set; }
        public int Prijs { get; set; }
        public int Totaal { get; set; }

        public KenmerkenProduct (string productNaam, string afdeling, int aantal, string stukOfGewicht, int prijs, int totaal)
        {
            ProductNaam = productNaam;
            Afdeling = afdeling;
            Aantal = aantal;
            StukOfGewicht = stukOfGewicht;
            Prijs = prijs;
            Totaal = totaal;
        }

        public override string ToString()
        {
            return $"{ProductNaam} aantal :{Aantal}";
        
        }
    }
}
