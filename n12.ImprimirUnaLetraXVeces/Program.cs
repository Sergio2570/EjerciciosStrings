using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n12.ImprimirUnaLetraXVeces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra; int repeticion; bool valido = true; string nuevaCadena = "";
            Console.WriteLine("Dame una letra");
            while(!char.TryParse(Console.ReadLine(), out letra))
            {
                Console.WriteLine("Introduce solo una letra");
            }
            Console.WriteLine("Dame un número de veces que se repite");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out repeticion))
                {
                    Console.WriteLine("Dame un número válido");
                }
                if (repeticion > 1)
                {
                    valido = false;
                }
            } while (valido);
            for (int i = 0; i < repeticion; i++)
            {
                nuevaCadena += letra;
            }
            Console.WriteLine(nuevaCadena);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
/*Desarrolla un programa que devuelva una cadena con
un carácter repetido n veces, siendo n solicitado por
teclado.*/