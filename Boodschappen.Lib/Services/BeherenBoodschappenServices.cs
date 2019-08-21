using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boodschappen.Lib.Entities;

namespace Boodschappen.Lib.Services
{
    public class BeherenBoodschappenServices
    {
        public static List <KenmerkenProduct> KenmerkenProducts { get; set; }

        public BeherenBoodschappenServices()
        {
            List<string> Boodschappen;
            KenmerkenProducts = new List<KenmerkenProduct>();
        }

        public void SlaOp (KenmerkenProduct vorigeVersie, KenmerkenProduct huidigeVersie)
        {
            if (vorigeVersie == null)
            {
                VoegToe(huidigeVersie);
            }
            else
            {
                Wijzig(vorigeVersie, huidigeVersie);
            }
        }

        void VoegToe (KenmerkenProduct nieuw)
        {
            KenmerkenProducts.Add(nieuw);
        }

        public void Verwijder (KenmerkenProduct teVerwijderen)
        {
            KenmerkenProducts.Remove(teVerwijderen);
        }

        void Wijzig (KenmerkenProduct vorigeVersie, KenmerkenProduct huidigeVersie)
        {
            if (vorigeVersie != huidigeVersie)
            {
                Verwijder(vorigeVersie);
                VoegToe(huidigeVersie);
            }
        }
    }

    
}
