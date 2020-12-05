using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktoriStatickeVarijable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa X = new PrvaKlasa("Paolo", "Beaković");
            PrvaKlasa Y = new PrvaKlasa("Karlo", "Matošević");
            PrvaKlasa Z = new PrvaKlasa();

            Console.WriteLine(X + "\n" + Y + "\n" + Z);
            Console.ReadKey();
        }
    }
}
