using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioI
{
    class Program
    {
        static void Main(string[] args)

        {
            int registro = 691;

            for (int i = 1; i <= registro; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " - FooBar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - Foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " - Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey(true);
        }
    }
}
