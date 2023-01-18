using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cijena, cijenaPDV, PDV;

            Console.WriteLine("Unesite cijenu bez i sa PDV-om: ");
            cijena = Convert.ToDouble(Console.ReadLine());
            cijenaPDV = Convert.ToDouble(Console.ReadLine());

            PDV = (cijenaPDV - cijena) / cijena * 100;

            Console.WriteLine("PDV je " + PDV + "%");

            Console.ReadKey();
        }
    }
}
