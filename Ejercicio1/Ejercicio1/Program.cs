using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos paquetes de folios desea comprar?");
            int cantidad=Convert.ToInt32(Console.ReadLine());
            double precio;
            if (cantidad < 200) precio = cantidad * 4.50;
            else if (cantidad >= 200 && cantidad <= 500) precio = cantidad * 3.75;
            else precio = cantidad * 3.25;
            Console.WriteLine("El precio a pagar por los "+ cantidad+ " paquetes es de "+precio + " euros.");
            Console.ReadKey();
        }
    }
}
