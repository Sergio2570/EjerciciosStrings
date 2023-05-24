using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n09.NombreApellido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu apellido, nombre");
            string apeNom = Console.ReadLine();
            string apellido = "", nombre = "", nomApe = "";
            if (apeNom.Contains(","))
            {
                int count = 0;
                while (apeNom[count] != ',')
                {
                    apellido = apellido + apeNom[count];
                    count++;
                }
                for (int i = count; i < apeNom.Length; i++)
                {
                    if (apeNom[i] != ',' && apeNom[i] != ' ')
                    {
                        nombre = nombre + apeNom[i];
                    }
                }
                nomApe = nombre + " " + apellido;
                Console.WriteLine($"{apeNom} es {nomApe}");
            }
            else
            {
                Console.WriteLine("El dato no está en el formato solicitado");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
