using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdenamiento
{
    internal class Sort
    {
        public static int[] QuickSort(int[] arreglo)
        {
            // Copia el arreglo, con el fin de consevar el arreglo desordenado
            int[] copia = new int[arreglo.Length];
            Array.Copy(arreglo,copia,arreglo.Length);
            QuickSort(copia, 0, arreglo.Length - 1);
            return copia;
        }

        private static void QuickSort(int[] arreglo, int izquierda, int derecha)
        {
            int i = izquierda;
            int j = derecha;
            int pivote = arreglo[izquierda];

            while ( i <= j )
            {
                while (arreglo[i] < pivote)
                {
                    i++;
                }
                while (arreglo[j] > pivote)
                {
                    j--;
                }

                if (i <= j)
                {
                    (arreglo[j], arreglo[i]) = (arreglo[i], arreglo[j]);
                    i++;
                    j--;
                }
            }
            if (izquierda < j)
                QuickSort(arreglo, izquierda, j);
            if (i < derecha)
                QuickSort(arreglo, i, derecha);
        }
    }
}
