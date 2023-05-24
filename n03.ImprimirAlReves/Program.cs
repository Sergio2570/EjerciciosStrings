using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n03.ImprimirAlReves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una frase");
            string cadena = Console.ReadLine();
            Console.WriteLine(); //Separador
            for (int i = (cadena.Length - 1); i >= 0; i--)
            {
                Console.Write(cadena[i]);
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
