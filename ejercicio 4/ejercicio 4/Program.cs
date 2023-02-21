using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 5, 8, 9 };
            int[] array2 = { 2, 3, 4, 6, 7, 10 };
            int[] arrayresultado = new int[ array1.Length + array2.Length ];
            int cont1 = 0;
            int cont2 = 0;
            for (int i = 0; i < arrayresultado.Length; i++)
            {
                if (cont1== array1.Length)
                {
                    arrayresultado[i] = array2[cont2];
                    cont2++;
                }
                else if (cont2 == array2.Length)
                {
                    arrayresultado[i] = array1[cont1];
                    cont1++;
                }
                else if (array1[cont1] < array2[cont2])
                {
                    arrayresultado[i] = array1[cont1];
                    cont1++;
                }
                else if (array1[cont1] > array2[cont2])
                {
                    arrayresultado[i] = array2[cont2];
                    cont2++;
                }
                
            }
            Console.WriteLine(arrayresultado);
            Console.ReadKey();
        }
    }
}
