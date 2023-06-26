using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdenamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine($"Arreglo generado al azar de longitud {n}:");
            int[] arreglo = new int[n];
            Random random = new Random();
            for ( int i = 0; i < arreglo.Length; i++ )
                arreglo[i] = random.Next(1,1000);
            PrintArray(arreglo);

            Console.WriteLine("Arreglo ordenado:");
            PrintArray(Sort.QuickSort(arreglo));

            Console.ReadLine();
        }

        private static void PrintArray(int[] array)
        {
            Console.Write("[");
            for ( int i = 0;i < array.Length;i++ )
            {
                Console.Write(array[i]);
                if ( i < array.Length - 1 )
                    Console.Write(",");
            }
            Console.Write("]\n");
        }
    }
}
