using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijeljivBroj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double broj;

            Console.WriteLine("Unesite broj: ");
            broj = Convert.ToDouble(Console.ReadLine());

            if(broj % 4 == 0 & broj % 6 !=0)
            {
                Console.WriteLine("Broj je dijeljiv s 4");
            }
            else if(broj % 4 != 0 & broj % 6 == 0)
            {
                Console.WriteLine("Broj je dijeljiv s 6");
            }
            else if (broj % 4 == 0 & broj % 6 == 0)
            {
                Console.WriteLine("Broj je dijeljiv sa 4 i sa 6");
            }
            else
            {
                Console.WriteLine("Broj nije dijeljiv sa 4 ni sa 6");
            }

            Console.ReadKey();
        }
    }
}
