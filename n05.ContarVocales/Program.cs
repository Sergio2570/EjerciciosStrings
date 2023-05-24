using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n05.BuscarVocales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.SinContains();
            const string a = "a", e = "e", i = "i", o = "o", u = "u";
            Console.WriteLine("Dame una frase");
            string cadena = Console.ReadLine();
            if (cadena.Contains(a))
            {
                Console.WriteLine("La cadena contiene a");
            }
            if (cadena.Contains(e))
            {
                Console.WriteLine("La cadena contiene e");
            }
            if (cadena.Contains(i))
            {
                Console.WriteLine("La cadena contiene i");
            }
            if (cadena.Contains(o))
            {
                Console.WriteLine("La cadena contiene o");
            }
            if (cadena.Contains(u))
            {
                Console.WriteLine("La cadena contiene u");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
        public static void SinContains()
        {
            Console.WriteLine("Dame una frase");
            string frase = Console.ReadLine();
            frase = frase.ToLower();
            const char a = 'a', e = 'e', i = 'i', o = 'o', u = 'u';
            int ia = 0, ie = 0, ii = 0, io = 0, iu = 0;
            for (int count = 0; count < frase.Length - 1; count++)
            {
                if (frase[count] == a)
                {
                    ia++;
                }
                if (frase[count] == e)
                {
                    ie++;
                }
                if (frase[count] == i)
                {
                    ii++;
                }
                if (frase[count] == o)
                {
                    io++;
                }
                if (frase[count] == u)
                {
                    iu++;
                }
            }
            Console.WriteLine("Hay un total de:");
            Console.WriteLine("a: " + ia);
            Console.WriteLine("e: " + ie);
            Console.WriteLine("i: " + ii);
            Console.WriteLine("o: " + io);
            Console.WriteLine("u: " + iu);
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
