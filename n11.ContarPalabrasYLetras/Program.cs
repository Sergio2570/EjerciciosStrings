using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n11.ContarPalabrasYLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string cadena = Console.ReadLine();
            int count = 0;
            string espacio = " ";
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == Convert.ToChar(" "))
                {
                    Console.WriteLine("\n" +count);
                    count = 0;
                }
                else
                {
                    Console.Write(cadena[i]);
                    count++;
                }
            }
            Console.WriteLine("\n" + count);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
    class Aiuda
    {
        static void ayuda()
        {

        }
    }
}
/*Introducir por teclado una frase y a continuación
visualizar cada palabra de la frase, una debajo de otra,
seguida cada palabra del número de letras que compone
dicha palabra.*/
