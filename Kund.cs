using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class
{
    public class Kund
    {
        private string name;

        public string Name{
            get { return name; }
            set { name = value; }
        }

        private string telefonnummer;

        public string Telefonnummer {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }

        void VisaKundInfo(){
            Console.WriteLine("Namn: " + Name);
            Console.WriteLine("Telefonnummer: " + Telefonnummer);
        }

        public Kund(string n, string t){
            Name = n;
            Telefonnummer = t;
        }
    }
}
