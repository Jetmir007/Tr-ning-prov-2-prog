using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class
{
    public class Uthyrning
    {
        private Bil b;

        private Kund k;

        private int antaldagar;

        public int Antaldagar{
            get { return antaldagar; }
            set { antaldagar = value; }
        }

        private double totalkostnad;

        public double Totalkostnad{
            get { return totalkostnad; }
            set { totalkostnad = value; }
        }

        void VisaUthyrningsInfo(){
            Console.WriteLine("Kundens namn: " + k.Name);
            Console.WriteLine("Kundens telefonnummer: " + k.Telefonnummer);
            Console.WriteLine("Bilen märke: " + b.Märke);
            Console.WriteLine("Bilen modell: " + b.Modell);
            Console.WriteLine("Bilen årsmodell: " + b.Årsmodell);
            Console.WriteLine("Antal dagar: " + antaldagar);
            Console.WriteLine("Total kostnad: " + totalkostnad);
        }
    }
}
