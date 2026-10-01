using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERICIOSTALLERCLASE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO 3
            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int[10];

            Random rnd = new Random();

            // Llenar la matriz con números aleatorios del 1 al 10
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rnd.Next(1, 11); ///numeros del 0 al 10
                }
            }

            // Mostrar la matriz
            Console.WriteLine("MATRIZ:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matriz[i, j]}");
                    switch (matriz[i, j])
                    {
                        case 1:
                            frecuencia[0]++;
                            break;
                        case 2:
                            frecuencia[2]++;
                            break;

                        case 3:
                            frecuencia[3]++;
                            break;
                        case 4:
                            frecuencia[4]++;
                            break;
                        case 5:
                            frecuencia[5]++;
                            break;
                        case 6:
                            frecuencia[6]++;
                            break;
                        case 7:
                            frecuencia[7]++;
                            break;
                        case 8:
                            frecuencia[8]++;
                            break;
                        case 9:
                            frecuencia[9]++;
                            break;
                        case 10:
                            frecuencia[10]++;
                            break;
                        default:
                            break;

                    }
                }   
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"la frecuencia del numero {i+1} es {frecuencia[i]}");
            }
        }
    }
}
