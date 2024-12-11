using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class
{
    public class Bil
    {
        private string märke;

        public string Märke{
            get { return märke; }
            set { märke = value; }
        }

        private string modell;

        public string Modell{
            get { return modell; }
            set { modell = value; }
        }

        private int årsmodell;

        public int Årsmodell{
            get { return årsmodell; }
            set { årsmodell = value; }
        }

        private double dagshyra;

        public double Dagshyra{
            get { return dagshyra; }
            set { dagshyra = value; }
        }

        private bool ärtillgänglig;

        public bool ÄrTillgänglig{
            get { return ärtillgänglig; }
            set { ärtillgänglig = value; }
        }

        void VisaInfo(){
            Console.WriteLine(Märke + " " + Modell + ", " + "Årsmodell: " + Årsmodell + ", " + "Dagshyra: " + Dagshyra + "Tillgänglig: " + ÄrTillgänglig);
        }

        public Bil(string mä, string mo, int å, double d, bool ä)
        {
            Märke = mä;
            Modell = mo;
            Årsmodell = å;
            Dagshyra = d;
            ÄrTillgänglig = ä;
        }
    }
}
