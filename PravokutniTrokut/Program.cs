using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PravokutniTrokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Unesite 3 stranice pravokutnog trokuta, zadnja treba biti hipotenuza: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            if ((x * x) + (y * y) == (z * z) & x != 0 & y != 0 & z != 0)
            {
                Console.WriteLine("Ovo je pravokutni trokut.");
            }
            else
            {
                Console.WriteLine("Ovo nije pravokutni trokut.");
            }

            Console.ReadKey();
        }
    }
}
