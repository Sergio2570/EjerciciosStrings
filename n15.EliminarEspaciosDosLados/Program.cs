using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n15.EliminarEspaciosDosLados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una frase (Con espacios a los lados)");
            string cadena = Console.ReadLine(); string nuevaCadena = "";
            int der = cadena.Length - 1, izq = 0;
            bool fin = false;
            while (!fin)
            {
                if (cadena[izq] == ' ')
                {
                    izq++;
                }
                else
                {
                    fin = true;
                }
            }
            fin = false;
            while (!fin)
            {
                if (cadena[der] == ' ')
                {
                    der--;
                }
                else
                {
                    fin = true;
                }
            }
            for (int i = izq; i <= der; i++)
            {
                nuevaCadena += cadena[i];
            }
            Console.WriteLine(nuevaCadena);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}