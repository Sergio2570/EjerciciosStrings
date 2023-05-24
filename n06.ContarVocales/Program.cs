using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n06.ContarVocales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;
            const string vocalA = "a", vocalE = "e", vocalI = "i", vocalO = "o", vocalU = "u";
            Console.WriteLine("Dame una frase");
            string cadena = Console.ReadLine();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == vocalA[0])
                {
                    countA++;
                }
                if (cadena[i] == vocalE[0])
                {
                    countE++;
                }
                if (cadena[i] == vocalI[0])
                {
                    countI++;
                }
                if (cadena[i] == vocalO[0])
                {
                    countO++;
                }
                if (cadena[i] == vocalU[0])
                {
                    countU++;
                }
            }
            Console.WriteLine($"La cadena contiene {countA} {vocalA}, {countE} {vocalE}, {countI} {vocalI}, {countO} {vocalO}, {countU} {vocalU},");
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
