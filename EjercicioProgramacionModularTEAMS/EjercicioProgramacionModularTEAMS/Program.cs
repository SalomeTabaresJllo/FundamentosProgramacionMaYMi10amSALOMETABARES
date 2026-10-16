using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProgramacionModularTEAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                int filas = CapturarFilas();
                int columnas = CapturarColumnas();

                int[,] matriz = new int[filas, columnas];

                BorrarPantalla();
                LlenarMatriz(matriz, filas, columnas);

              
                MostrarMatriz(matriz, filas, columnas);
                Console.ReadLine();
            }

            static int CapturarFilas()
            {
                Console.Write("Ingrese el número de filas: ");
                return int.Parse(Console.ReadLine());
            }

            static int CapturarColumnas()
            {
                Console.Write("Ingrese el número de columnas: ");
                return int.Parse(Console.ReadLine());
            }

           

            static bool Multiplo5(int numero)
            {
                return numero % 5 == 0;  //CONFIRMAR SI ES MULTPLO DE 5
            }
            static void LlenarMatriz(int[,] matriz, int filas, int columnas)
            {
                Console.WriteLine("LLENADO DE MATRIZ (MÚLTIPLOS 5): ");

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        int valor;
                        bool valido = false;

                        while (!valido)   //DIFERENTE DE VALIDO
                        {
                            Console.Write($"Ingrese un múltiplo de 5 para [{i},{j}]: ");
                            valor = int.Parse(Console.ReadLine());

                            // Llama a la función EsMultiplo
                            if (Multiplo5(valor))
                            {
                                matriz[i, j] = valor;
                                valido = true;
                            }
                            else
                            {
                                Console.WriteLine("El número NO es múltiplo de 5. Intente de nuevo.");
                            }
                        }
                    }
                }

                BorrarPantalla();
            }

            static void MostrarMatriz(int[,] matriz, int filas, int columnas)
            {
                Console.WriteLine("MATRIZ FINAL RESULTANTE:");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write($"[{matriz[i, j]}] ");
                    }
                    Console.WriteLine();
                }
            }
        static void BorrarPantalla()
        {
            Console.Clear();
        }

    }
}


  
