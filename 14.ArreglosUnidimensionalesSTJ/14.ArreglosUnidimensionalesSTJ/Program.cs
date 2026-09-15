using System;

namespace _14.ArreglosUnidimensionalesSTJ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[] numeros = new int[5];    //ESPACIOS, 5 ESPACIOS.  (0,1,2,3,4) NO EXISTE EL 5

            numeros[0] = 15;  //EN EL SLOT 0 ESTA EL NUMERO 26
            numeros[1] = 102; //EN EL SLOT 1 ESTA EL NUMERO 102
            numeros[2] = 54; //EN EL SLOT 2 ESTA EL NUMERO 54
            numeros[3] = 26; //EN EL SLOT 3 ESTA EL NUMERO 26
            numeros[4] = 5;//EN EL SLOT 4 ESTA EL NUMERO 5
            *//*//NUMEROS[5]= 1; SLOT NO EXISTE, POSICION 6 EN INDICE 5 NO EXISTE.*//*
            Console.WriteLine($"EL NUMERO ALMACENADO EN LA POSICION 4 CON INDICE 3 ES : {numeros[3]}");



            //otras formas de declarar e iniciar vectores
            char[] simbolos = new char[] { '?', '/', 'o', '5' }; //4 SLOTS 
            bool[] valoresVerdad = { true, false, true, false, true, true };
            //RECORRER PARA LLENAR DATOS DEL VECTOR 

            string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)   //MENOR A 7 O MENOR O IGUAL A 6 //i = CONTADOR
            {
                Console.WriteLine($"INGRESE EL NOMBRE QUE DESEA ALMACENAR EN LA POSICION {i + 1};I{i}");
                nombres[i]=Console.ReadLine();
            }
            //RECORRER PARA RECUPERAR DATOS ALMACENADOS

            Console.Clear();

            for (int i = 0; i < nombres.Length; i++) //7 es el rango del vector en este caso (o se puede preguntar con nombre.legth)
            {
                Console.Write($" {nombres[i]} / ");  //write solo escriba la misma linea 
            }*/

            // -------------------------------------------------------------------------------------------------

            //EJERCICIO CLASE: CREAR UN ARREGLO DE ENTEROS DE 100 ELEMENTOS ASIGNAR EL NUMERO 10 EN CADA UNA DE LAS POSICIONES DEL ARREGLO,
            //LEER EL CONTENIDO DE CADA ELEMENTO Y MOSTRARLO EN PANTALLA

            /* int[] enteros = new int[100];


             for (int i = 0; i < enteros.Length; i++)
             {
                 enteros[i] = 10;
             }

             Console.Clear();

             for (int i = 0; i < enteros.Length; i++)
             {
                 Console.WriteLine($"EL CONTENIDO DE LAS POSICION {i + 1}; I{i} ES {enteros[i]}");
             }*/


            //2. EJERCICIO ALGORITMO QUE SOLICITE 10 NUMEROS LOS CUALES SERAN ALMACENADOS Y AL FINAL DEBE DE MOSTRAR EL PROMEDIO DE LOS NUMEROS

            /* double[] notas = new double[10];
             double acumulador = 0;

             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine($"INGRESE LA NOTA {i+1}");
                 notas[i] = double.Parse(Console.ReadLine());
                 acumulador = acumulador + notas[i];
             }
             Console.WriteLine($"EL PROMEDIO DE LAS NOTAS INGRESADAS ES {acumulador/notas.Length}");*/

            //-----------------------------------------------------------------------------------------------------


            //3. EJERCICIO: ARREGLO DE 15 NUMEROS INGRESADOS POR TECLADO, UNA VEZ REGISTRADOS MUESTRE EN PANTALLA TODOS LOS VALORES
            //FINALMENTE, DETERMINE CUAL ES EL NUMERO MAYOR Y MENOR, JUNTO CON LA POSICION QUE OCUPA EN EL ARREGLO

            int[] numero = new int[15];

            int mayor = 0;
            int posicionmayor = 0;

            int menor = 0;
            int posicionmenor = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"INGRESE EL NUMERO DE LA POSICION {i+1}");
                numero[i] = int.Parse(Console.ReadLine());

                if ( i ==0 && numero[i]> mayor)
                {
                    mayor = numero[i];
                    posicionmayor = i;
                }
                else if (i == 0 && numero[i] < menor)
                {
                    menor = numero[i];
                    posicionmenor = i;
                }
            }

            Console.WriteLine($"EL NUMERO MAYOR INGRESADO ES {mayor} en la posicion {posicionmayor}");
            Console.WriteLine($"EL NUMERO MENOR INGRESADO ES {menor} en la posicion {posicionmenor}");




        }
    }
}
