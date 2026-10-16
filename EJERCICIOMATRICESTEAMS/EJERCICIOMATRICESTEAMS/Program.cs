using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EJERCICIOMATRICESTEAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Diseñe un algoritmo que permita transformar una matriz numérica reemplazando todos sus elementos que sean menores a un valor umbral N, por dicho valor.

                Requerimientos:

               Solicitar al usuario las dimensiones de la matriz(número de filas y columnas).
               Capturar los valores numéricos para llenar la matriz.
               Solicitar el valor límite u objetivo(N).
               Recorrer la matriz y actualizar cualquier valor que cumpla la condición elemento<N.
               Mostrar la matriz resultante.
              */

            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());


            int[,] matriz = new int[filas, columnas];


            Console.WriteLine("LLENAR MATRIZ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.Write("INGRESE NUEVO NUMERO PARA REEMPLAZAR LOS NUMEROS MENOR A EL NUMERO ELEGIDO ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] < n)
                    {
                        matriz[i, j] = n;
                    }
                }
            }

            Console.WriteLine("\n--- Matriz Resultante ---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t"); //t agrega tabulación para que quede ordenada
                }
                Console.WriteLine();
            }
        }
    }
}
    