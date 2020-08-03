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
            int mul3 = 0, mul4 = 0, j = 1;
            int N3 = 3; int N5 = 5; int Total = 0;   
            String cad = "";
            String cad2 = "";
            Console.WriteLine("Ingresa numero:");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            while (mul < (N - N3))
            {
                mul = N3 * i;
                mul2 = mul2+mul;                
                i++;
                cad = cad + " " + mul;
            }

            while (mul3 < (N - N5))
            {
                mul3 = N5 * j;
                mul4 = mul4 + mul3;
                j++;
                cad2 = cad2 + " " + mul3;
            }

            Total = mul2 + mul3;
            Console.WriteLine("Los multiplos de 3 y 5 encontrados menores que "+N+" son: " + cad + cad2);
            Console.WriteLine("La suma de los multiplos encontrados son: " + Total);

            Console.ReadLine();
        }
    }
}
