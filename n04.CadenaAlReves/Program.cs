using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n04.CadenaAlReves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reves = "";
            Console.WriteLine("Dame una frase");
            string cadena = Console.ReadLine();
            for (int i = (cadena.Length - 1); i >= 0; i--)
            {
                reves = reves + cadena[i];
            }
            Console.WriteLine("La nueva cadena es:");
            Console.WriteLine(reves);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
