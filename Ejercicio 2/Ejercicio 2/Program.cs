using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra para comprobar si es capicua: ");
            string palabra = Console.ReadLine();
            bool capicua = true;
            for (int i = 0; i < palabra.Length/2; i++)
            {
                if (palabra[i] != palabra[palabra.Length - 1 - i]) 
                { 
                    capicua = false;
                    break;
                }
            }
            if (capicua) Console.WriteLine("La palabra es capicua");
            else Console.WriteLine("La palabra NO es capicua");
            Console.ReadKey();
        }
    }
}
