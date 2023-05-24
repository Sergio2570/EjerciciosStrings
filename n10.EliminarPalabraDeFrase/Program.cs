using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10.EliminarPalabraDeFrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Dame la palabra a eliminar");
            string palabra = Console.ReadLine();
            Console.WriteLine($"Frase: {frase}");
            Console.WriteLine($"Palabra: {palabra}");
            string nuevaCadena = ""; 
            int i=0, j=0, k=0;
            bool comprobar = false;
            for (i = 0; i < frase.Length - 1; i++)
            {
                j = 0;
                if (frase[i] == palabra[j])
                {
                    if (frase[i+1] == palabra[j + 1])
                    {
                        k = i;
                        comprobar = true;
                        do
                        {
                            if (frase[k] == palabra[j])
                            {
                                k++; j++;
                                if (j == palabra.Length)
                                {
                                    i = i + j + 1;
                                    comprobar = false;
                                }
                            }
                            else
                            {
                                comprobar = false;
                            }

                        } while (comprobar);
                    }
                    else
                    {
                        nuevaCadena = nuevaCadena + frase[i];
                    }
                }
                else
                {
                    nuevaCadena = nuevaCadena + frase[i];
                }
            }
            Console.WriteLine(nuevaCadena);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
        private static void ConFunciones()
        {
            bool comprobar = false;
            Console.WriteLine("Dame una frase (Preferiblemente larga)");
            string frase = "Hola amigo, como estas amigo, yo estoy muy bien amigo"; //string frase = Console.ReadLine();
            Console.WriteLine("Dame la palabra que quieres eliminar de la frase");
            string palabra = "amigo"; //string palabra = Console.ReadLine();
            string nuevaFrase = frase;
            while (comprobar == false)
            {
                if (nuevaFrase.Contains(palabra))
                {
                    nuevaFrase = nuevaFrase.Replace(palabra, "");
                }
                else
                {
                    comprobar = true;
                }
            }
            Console.WriteLine(nuevaFrase);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}


/*Dada una frase y una palabra, eliminar esa palabra de la
frase tantas veces como aparezca, diciendo la frase sin
ellas y el número de veces que se ha eliminado. Por
ejemplo: dada la frase: “Hola amigo. Como estas amigo.
Yo estoy muy bien amigo.”, y la palabra “amigo”, debe
devolver: “Hola. Como estas. Yo estoy muy bien.” y
mostrar el valor 3, por eliminarlo tres veces. Se debe
eliminar la palabra, y el espacio en blanco anterior si lo
hubiera.*/