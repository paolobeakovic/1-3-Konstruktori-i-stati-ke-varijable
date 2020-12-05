using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktoriStatickeVarijable
{
    class PrvaKlasa
    {
        private static int counter;
        private string ime, prezime;

        public PrvaKlasa()
        {
            counter = 0;
            counter++;
        }
       
        public static int Brojač
        { 
            get => counter;
        }
        public string Ime
        { 
            get => Ime; set => Ime =value; 
        } 
        public string Prezime
        {
            get => Prezime; set => Prezime = value;
        }

        public override string ToString()
        {
            string ispis = "Redni br.: " + Ime + ", " + Prezime + " " + counter;

            return ispis;
        }


    }

}
