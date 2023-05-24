using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n01.ContarCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string espacio = " ";
            Console.WriteLine("Dame una frase");
            string cadena = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] != espacio[0])
                {
                    count++;
                }
            }
            Console.WriteLine($"La cadena tiene un total de {count} caracteres");
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
/*Dada una cadena de caracteres introducida por teclado,
contar el número de caracteres que la componen.*/