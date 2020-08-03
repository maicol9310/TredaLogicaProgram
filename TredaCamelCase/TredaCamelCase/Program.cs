using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TredaCamelCase
{
    class Program
    {
        public static string camelcase(string camel)
        {
            camel = camel.Replace(" ", "").Replace("_", "").Replace("-", "");
            return camel;
        }

        public static void Main(string[] args)
        {
            string N;
            string Resultado;
            Console.WriteLine("Ingresar text:");
            N = Console.ReadLine();

            Resultado = camelcase(N);


            Console.WriteLine(Resultado);
            Console.ReadLine();
        }
    }
}
