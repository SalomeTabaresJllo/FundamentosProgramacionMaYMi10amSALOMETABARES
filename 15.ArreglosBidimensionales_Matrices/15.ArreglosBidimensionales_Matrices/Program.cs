using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ArreglosBidimensionales_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        //ARREGLOS BIDIMENSIONALES O MATRICES - DATOS 
                        //ASI SE HACE UNA MATRIZ:
                        int[,] numeros = new int[2, 3];   //DOS FILAS Y 3 COLUMNAS EN ESTE CASO

                        //EXISTEN [0,0], [0,1], [0,2] (PRIMERA FILA, 3 COUMNAS)
                        //EXISTEN [1,0],[1,1], [1,2] (SEGUNDA FILA, 3 COLUMNAS)

                        //NUMERO [2,1] = 10; EL INDICE DE LA FILA NO EXISTE, NO SE PUEDE ALMACENAR
                        //NUMERO [1,3] = 15; TAMPOCO EXISTE, SE DESBORDA LA COLUMNA

                        numeros[0,0] = 12;
                        numeros[0,1] = 100;
                        numeros[0, 2] = 56;
                        numeros[1,0] = 45;
                        numeros[1,1] = 8;
                        numeros[1,2] = 10;

                        Console.WriteLine($"EL VALOR ALMAENADO EN NUMERO[1,0]:{numeros[1,0]}");

                        //rango = fila x columnas

                        //FOR ANINADO

                        char [,] simbolos = new char[3, 2];
                        Console.Clear();
                        for (int i = 0; i< 3; i++) //RECORRE LAS FILAS i <3 maximo 3 filas
                        {
                            for(int j = 0; j<2; j++) //RECORRE LAS COLUMNAS, COMO TIENEN EL MISMO CONTEXTO I NO SE PUEDE SER IGUAL  SE CAMBIA, J.
                            {
                                Console.WriteLine($"ingrese el caracter para simbolos[{i},{j}]");
                                simbolos[i,j]= char.Parse(Console.ReadLine());
                            }
                        }
                        //RECORRER PARA RECUPERAR DATOS
                        for(int i =0; i < simbolos.GetLength(0); i++)  //numero de filas, GetLength(0) devuelve el numero de filas
                        {
                            for(int j =0; j<simbolos.GetLength(1);j++)  //numero de columnas, GetLength(1) devuelve el numero de columnas
                            {
                                Console.Write($"{simbolos[i,j]} |");

                            }
                            Console.WriteLine();
                        }

                        //OTRA FORMA DE INICIALIZAR MATRICES     //MATRICES CUDRADAS, CADA COLUMNA DEBE SER IGUAL
                        string[,] nombres =
                        {
                            {"ANA", "JUAN", "CARLOS", "ALVARO" },
                            {"PEDRO", "FERNEY", "YULI", "FELIX" },
                            {"CARLA", "ALEX", "ESTEBAN", "SALOME" },

                        };
            */

            //---------------------------------------------------------------------------------------------------------


            //CREAR UNA MATIRZ [10,20] EN CADA POSICION PONER EL NUMERO 100 Y MOSTRAR LA MATRIZ EN LA CONSOLA

            /* int[,] matriz = new int [10, 20];


             //LLENAR LA MATRIZ

             for(int i = 0; i<10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     matriz[i, j] = 100;
                 }

             }
             //MOSTRAR LA MATRIZ
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     matriz[i, j] = 100;
                     Console.WriteLine(matriz[i, j]);
                 }
                 Console.WriteLine();
             }*/


            //-------------------------------------------------------------------------------------------------------------------------

            //2. PROGRAMA QUE REALICE LA SUMA DE 2 MATRICES EN DIMENSIONES 2 X 3 
            //REQUISITOS: SOLICITAR AL USUARIO QUE INGRESE LOS ELEMENTOS DE LA PRIMERA Y SEGUNDA MATRIZ DE LAS MISMAS DIMENSIONES
            //CALCULAR LA MATRIZ SUMA , RESULTADO DE SUMAR CADA ELEMENTO DE LAS DOS MATRICES
            //MUESTRE LA MATRIZ RESULTANTE DE LA SUMA EN FORMATO MATRIZ 2 FILAS , 3 COLUMNAS

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSuma = new int[2, 3];


            for (int i =0; i <2; i++)
            {
                for(int j =0; j<3; j++)
                {
                    Console.WriteLine($"ingrese el caracter para matriz 1 [{i},{j}]");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"ingrese el caracter para matriz 2 [{i},{j}]");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //SUMA DE MATRICES

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizSuma[i, j]= matriz1[i, j] + matriz2[i, j];
                }
            }

            //MOSTRAR MATRIZ RESULTANTE

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"LA MATRIZ RESULTANTE ES {matrizSuma[i, j]} |");
                }

                Console.WriteLine();
            }


        }
    }
}
