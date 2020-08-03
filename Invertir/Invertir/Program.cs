using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir
{
    class Program
    {
        public static void Main(string[] args)
        {
            string N;
            Console.WriteLine("Ingresa texto a invertir:");
            N = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Texto Normal: "+N);
            Console.WriteLine("Texto Invertido: "+Invertir(N));
            Console.ReadLine();
        }

        public static string Invertir(string cadena)
        {
            char[] cadenaInver = cadena.ToCharArray();
            Array.Reverse(cadenaInver);
            return new string(cadenaInver);
        }
    }
}
