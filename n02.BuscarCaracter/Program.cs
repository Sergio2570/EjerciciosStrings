using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n02.BuscarCaracter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una frase");
            string cadena = Console.ReadLine();
            Console.WriteLine("Dame un caracter a buscar");
            string letra = Console.ReadLine();
            if (letra.Length == 1)
            {
                int count = 0;
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == letra[0])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"La cadena tiene un total de {count} veces el caracter {letra}");
            }
            else
            {
                Console.WriteLine("Solo tienes que darme 1 letra");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
