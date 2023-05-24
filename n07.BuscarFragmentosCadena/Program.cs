using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n07.BuscarFragmentosCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una frase");
            string cadena = Console.ReadLine();
            Console.WriteLine("Dame el fragmento a buscar");
            string fragmento = Console.ReadLine();
            /* //Método más sencillo
            if (cadena.Contains(fragmento))
            {
                Console.WriteLine("Está");
            }
            else
            {
                Console.WriteLine("No está");
            } */
            int count = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == fragmento[0])
                {
                    for (int j = 0; j < fragmento.Length; j++)
                    {
                        if (cadena[i] == fragmento[j])
                        {
                            i++;
                            count++;
                        }
                    }
                }
            }
            if (count == fragmento.Length)
            {
                Console.WriteLine("Está");
            }
            else
            {
                Console.WriteLine("No está");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
