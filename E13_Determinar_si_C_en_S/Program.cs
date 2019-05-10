using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13_Determinar_si_C_en_S
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese la cadena:");
                string cadena = Console.ReadLine();
                Console.WriteLine("Ingrese caracter:");
                if ( char.TryParse(Console.ReadLine(), out char c))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La cadena es \"{0}\"", cadena);
                    Console.WriteLine("\"{0}\" {1} está en la cadena \"{2}\"", c, BuscarEnCadena(c, cadena) ? "si" : "no", cadena);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se ingreso caracter");
                }

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);

            } while (!salir);
        }
        public static bool BuscarEnCadena(char c, string cadena)
        {
            foreach (var v in cadena.ToCharArray())                
                    if (c == v)
                        return true;                
            return false;
        }
    }
}
