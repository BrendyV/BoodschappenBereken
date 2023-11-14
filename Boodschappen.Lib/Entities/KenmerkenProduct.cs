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
        public decimal Aantal { get; set; }
        public StukOfKg StukOfGewicht { get; set; }
        public decimal PrijsPerStuk { get; set; }
        public decimal Totaal { get; set; }

        public KenmerkenProduct (string productNaam, Afdelingen afdeling, decimal aantal, StukOfKg stukOfGewicht, decimal prijsPerStuk, decimal totalePrijs)
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
