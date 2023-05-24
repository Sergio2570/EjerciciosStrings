using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n08.InsertarContraseña
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwd = "";
            const string contrasenia = "Eureka";
            int count = 3; bool fin = false;
            while (!fin)
            {
                if (count == 0)
                {
                    Console.WriteLine("Fin de los intentos, saliendo...");
                    fin = true;
                }
                else
                {
                    Console.WriteLine($"Introduce la contraseña(Intentos restantes = {count})");
                    passwd = Console.ReadLine();
                    if (passwd == contrasenia)
                    {
                        Console.WriteLine("Contraseña correcta, buenos días");
                        fin = true;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}