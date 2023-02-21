using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero para calcular su factorial");
            long numero= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("El factorial del número "+ numero+ " es " + factorial( numero));
            Console.ReadKey();
            //factorial de 13 con int 1932053504
            //factorial de 13 con long 6227020800
            // hay un cambio entre el int y el lon pq con el int no se llega al valor del factorial del 13 cosa que el long si que lo alcanza
            //factorial de 24 con long -7835185981329244160
            //entiendo que es negativo pq hay overflow en el resultado y el overflow se representa con el -
        }
        public static long factorial (long numero) 
        {
            long resultado = 1;
            if (numero>1)
            {
                for (long i = numero; i > 1; i--)
                {
                    resultado *= i;
                }
                    
            }
            return resultado;
        }
    }
}
