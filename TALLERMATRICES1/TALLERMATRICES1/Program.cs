using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLERMATRICES1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            //pantalla la suma de los elementos de cada columna

            int[,] matriz= new int[10, 20];
            int[] SumaColumnas = new int[20];

            //LLENAR MATRIZ
            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    matriz[i, j] = 1;
                }
            }

            //SUMA

            for (int i = 0; i < 10; i++)
            {
    
                for (int j = 0; j < 20; j++)
                {
                    SumaColumnas[j] = SumaColumnas[j] + matriz[i, j];
                }
            }

            //MOSTRAR PANTALLA

            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine($"LA SUMA DE LAS COLUMNAS ES {SumaColumnas[j]}");
            }
        }
    }
}
