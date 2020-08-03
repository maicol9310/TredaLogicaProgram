using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TredaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, mul = 0, mul2 = 0, i = 1;
            int N3 = 3;
            int N5 = 5;
            String cad = "";
            Console.WriteLine("Ingresa numero");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            while (mul < (N - N3))
            {

                mul = N3 * i;
                mul2 = mul2+mul;
                
                i++;
                cad = cad + " " + mul;

            }
            Console.WriteLine("Los multiplos encontrados son: " + cad);
            Console.WriteLine("La suma de los multiplos encontrados son: " + mul2);

            Console.ReadLine();
        }
    }
}
