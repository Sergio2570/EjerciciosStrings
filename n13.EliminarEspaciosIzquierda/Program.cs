using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n13.EliminarEspaciosIzquierda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una frase (Con espacios a la izquierda)");
            string cadena = Console.ReadLine(); string nuevaCadena = "";
            int j = 0;
            bool fin = false;
            while (!fin)
            {
                if (cadena[j] != Convert.ToChar(" "))
                {
                    for (int i = j; i < cadena.Length; i++)
                    {
                        nuevaCadena = nuevaCadena + cadena[i];
                    }
                    fin = true;
                }
                j++;
            }
            Console.WriteLine(nuevaCadena);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
