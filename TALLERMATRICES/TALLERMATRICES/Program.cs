using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TALLERMATRICES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            //pantalla la suma de los elementos de cada columna

            /* int[,] matriz = new int[10, 20];
             int[] SumaColumnas = new int[20];

             //LLENAR MATRIZ
             for (int i = 0; i < 10; i++)
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
             }*/

            //-----------------------------------------------------------------------------------------------------------------------------------------------------

            //2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            //caracteres en cada posición de la matriz hasta llenarla.El programa debe intercambiar la
            //primera fila con la última fila de la matriz.Al final se debe imprimir la matriz original, y la
            //matriz con el intercambio de filas. 



            /*int filas, columnas;

            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            // Llenar la matriz
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el numero deseado para fila {i + 1} y columnas {j + 1} ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Mostrar matriz original
            Console.WriteLine("MATRIZ ORIGINAL: --------------------------");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j]);
                }

                Console.WriteLine();
            }

        int[] primeraFila = new int[columnas];
        int[] ultimaFila = new int[columnas];  //si se pone filas solo quedaria el espacio de liuneas sin las columnas.....

        // Intercambiar primera fila con última fila
        for (int j = 0; j < columnas; j++)
           {


               primeraFila[j] = matriz[0, j];
               ultimaFila[j] = matriz[filas - 1, j];


           }
        // Ahora sí intercambiarlas
         for (int j = 0; j < columnas; j++)
            {
             matriz[0, j] = ultimaFila[j];
             matriz[filas - 1, j] = primeraFila[j];
           }
        // Mostrar matriz modificada
        Console.WriteLine("\nMATRIZ MODIFICADA:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j]);
            }

            Console.WriteLine();
        }*/

            //----------------------------------------------------------------------------------------------------

            //3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
            /* 5x5 llena de números aleatorios.
             El algoritmo debe permitir:
             Usa la función Random para generar los números aleatorios.
             Crea un arreglo adicional para almacenar la frecuencia de cada número.
             Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número*/



            /*int[,] matriz = new int[5, 5];
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
                    Console.Write(matriz[i, j] + "\t");
                }

                Console.WriteLine();
            }

            // Contar cuántas veces aparece cada número
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int numero = matriz[i, j];

                    frecuencia[numero - 1]++;
                }
            }

            // Mostrar las frecuencias
            Console.WriteLine("FRECUENCIA DE LOS NÚMEROS:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número " + (i + 1) + ": " + frecuencia[i] + " veces");
            }

            Console.ReadKey();*/


            /*char[,] tablero = new char[5, 5];

            Random rnd = new Random();

            // Inicializar tablero con guiones
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = '-';   
                }
            }

            // Colocar las 3 X aleatoriamente
            int cantidadX = 0;

            while (cantidadX < 3)
            {
                int fila = rnd.Next(0, 5);
                int columna = rnd.Next(0, 5);

                // Verificar que no haya una X en esa posición
                if (tablero[fila, columna] != 'X')
                {
                    tablero[fila, columna] = 'X';
                    cantidadX++;
                }
            }

            Console.WriteLine("JUEGO: ENCUENTRA UNA X");
            Console.WriteLine("El tablero tiene 5 filas y 5 columnas.");
            Console.WriteLine("Hay 3 X escondidas.");
            Console.WriteLine("Tienes 3 intentos.\n");

            bool encontrado = false;
            int filaEncontrada = -1;
            int columnaEncontrada = -1;

            // Tres intentos
            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine("INTENTO " + intento);

                Console.Write("Ingrese fila (1-5): ");
                int fila = int.Parse(Console.ReadLine());

                Console.Write("Ingrese columna (1-5): ");
                int columna = int.Parse(Console.ReadLine());

                // Restamos 1 porque la matriz comienza desde 0
                fila = fila - 1;
                columna = columna - 1;

                if (fila >= 0 && fila < 5 &&
                    columna >= 0 && columna < 5)
                {
                    if (tablero[fila, columna] == 'X')
                    {
                        encontrado = true;

                        filaEncontrada = fila;
                        columnaEncontrada = columna;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("No hay una X en esa posición.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Posición fuera del tablero.\n");
                }
            }

            // Resultado
            if (encontrado)
            {
                Console.WriteLine("\n¡FELICITACIONES!");
                Console.WriteLine("Encontraste una X.");

                Console.WriteLine(
                    "Posición: fila " + (filaEncontrada + 1) +
                    ", columna " + (columnaEncontrada + 1));
            }
            else
            {
                Console.WriteLine("\nNo encontraste ninguna X.");
                Console.WriteLine("El tablero era:");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j] + "\t");
                    }

                    Console.WriteLine();
                }
            }*/
            //----------------------------------------------------------------------------


            //5.  Desarrollar un programa e C# que: 
            /*Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz
             de enteros 
             Cargue los datos de la matriz ingresándolos por teclado
             Muestre la matriz ingresada 
             Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser
             ahora la columna 1.
             Mostrar la nueva matriz*/


            /*int filas, columnas;

            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            // Llenar matriz
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el numero deseado para fila {i + 1} y columnas {j + 1} : ");

                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Mostrar matriz original
            Console.WriteLine("\nMATRIZ ORIGINAL:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }

                Console.WriteLine();
            }

            // Crear matriz transpuesta
            int[,] nuevaMatriz = new int[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    nuevaMatriz[j, i] = matriz[i, j];
                }
            }

            // Mostrar matriz transpuesta
            Console.WriteLine("\nMATRIZ CON FILAS CONVERTIDAS EN COLUMNAS:");

            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write(nuevaMatriz[i, j] + "\t");
                }

                Console.WriteLine();
            }*/

            //-----------------------------------------------------------------------------------------

            //6. Crear una aplicación en C# que permita realizar las siguientes acciones: 
              //Crear una matriz de n filas por m columnas
              /*Llenar la matriz con números aleatorios del 1 al 3(investigar la función random en C#) 
               Mostrar la matriz generada 
               Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el
               número 3, y cuál de los tres números fue repetido más veces
*/

                int filas, columnas;

                Console.Write("Ingrese el número de filas: ");
                filas = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de columnas: ");
                columnas = int.Parse(Console.ReadLine());

                int[,] matriz = new int[filas, columnas];

                Random rnd = new Random();

                int contador1 = 0;
                int contador2 = 0;
                int contador3 = 0;

                // Llenar la matriz con números aleatorios del 1 al 3
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matriz[i, j] = rnd.Next(1, 4);
                    }
                }

                // Mostrar la matriz
                Console.WriteLine("MATRIZ GENERADA:");

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                // Contar cuántas veces aparece cada número
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (matriz[i, j] == 1)
                        {
                            contador1++;
                        }
                        else if (matriz[i, j] == 2)
                        {
                            contador2++;
                        }
                        else if (matriz[i, j] == 3)
                        {
                            contador3++;
                        }
                    }
                }

                // Mostrar cantidades
                Console.WriteLine("\nEl número 1 apareció " + contador1 + " veces.");
                Console.WriteLine("El número 2 apareció " + contador2 + " veces.");
                Console.WriteLine("El número 3 apareció " + contador3 + " veces.");

                // Determinar cuál se repitió más
                if (contador1 > contador2 && contador1 > contador3)
                {
                    Console.WriteLine("\nEl número que más se repitió fue el 1.");
                }
                else if (contador2 > contador1 && contador2 > contador3)
                {
                    Console.WriteLine("\nEl número que más se repitió fue el 2.");
                }
                else if (contador3 > contador1 && contador3 > contador2)
                {
                    Console.WriteLine("\nEl número que más se repitió fue el 3.");
                }
                else
                {
                    Console.WriteLine("\nHay un empate entre dos o más números.");
                }

                Console.ReadKey();
            }
        }
    }
     
    
        
    
 
 
