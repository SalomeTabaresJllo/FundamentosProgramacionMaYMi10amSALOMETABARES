using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TALLERVECTORES1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
            //encuentre y muestre el valor máximo y mínimo de los números ingresados.


            /*
                        int[] numero = new int[15];

                        int mayor = numero[0];

                        int menor = numero[0];


                        for (int i = 0; i < numero.Length; i++)
                        {
                            Console.WriteLine($"INGRESE EL NUMERO DE LA POSICION {i + 1}");
                            numero[i] = int.Parse(Console.ReadLine());


                            if (i == 0)
                            {
                                mayor = numero[i];
                                menor = numero[i];
                            }

                            if (numero[i] > mayor)
                            {
                                mayor = numero[i];
                            }

                            if (numero[i] < menor)
                            {
                                menor = numero[i];
                            }
                        }

                        Console.WriteLine($"EL NUMERO MAYOR INGRESADO ES {mayor}");
                        Console.WriteLine($"EL NUMERO MENOR INGRESADO ES {menor}");
            */

            //----------------------------------------------------------------------------------------------------

            //2. Escribir un algoritmo que permita: 
            /*a.Crear dos vectores del mismo tamaño.  
            b.Llenarlos con números.
            c.Comparar posición por posición.
            d.Indicar cuántos elementos son iguales. */



            /* int tamaño;

             Console.Write("Ingrese el tamaño de los vectores: ");
             tamaño = int.Parse(Console.ReadLine());

             int[] vector1 = new int[tamaño];
             int[] vector2 = new int[tamaño];

             int iguales = 0;

             // Llenar primer vector
             Console.WriteLine("\nPRIMER VECTOR");

             for (int i = 0; i < tamaño; i++)
             {
                 Console.Write($"Ingrese el número de la posición ¨{ i + 1}: ");
                 vector1[i] = int.Parse(Console.ReadLine());
             }

             // Llenar segundo vector
             Console.WriteLine("\nSEGUNDO VECTOR");

             for (int i = 0; i < tamaño; i++)
             {
                 Console.Write($"Ingrese el número de la posición ¨{i + 1}: ");
                 vector2[i] = int.Parse(Console.ReadLine());
             }

             // Comparar posición por posición
             for (int i = 0; i < tamaño; i++)
             {
                 if (vector1[i] == vector2[i])
                 {
                     iguales++;
                 }
             }

             // Mostrar vectores
             Console.WriteLine("\nVector 1:");
             for (int i = 0; i < tamaño; i++)
             {
                 Console.Write($"{vector1[i]} " );
             }

             Console.WriteLine("\nVector 2:");
             for (int i = 0; i < tamaño; i++)
             {
                 Console.Write($"{vector2[i]} ");
             }

             Console.WriteLine("Cantidad de elementos iguales: " + iguales);

             Console.ReadKey();*/

            //3. Escribir un algoritmo que permita: 
            /*    a.Llenar un vector[20] con números enteros(positivos o negativos) ingresados por el
                usuario o generados aleatoriamente.
                b.Calcular y mostrar el promedio aritmético de todos los elementos almacenados en
                el vector.
                c.Recorrer nuevamente el vector para contar e indicar cuántos números son
                mayores que el promedio y cuántos son menores que este. 
                d.Mostrar en pantalla el vector completo junto con los resultados obtenidos.


    */

            /*
             {
                 int[] vector = new int[20];

                 Random rnd = new Random();

                 int suma = 0;
                 double promedio;
                 int mayores = 0;
                 int menores = 0;

                 // Llenar el vector con números aleatorios
                 for (int i = 0; i < 20; i++)
                 {
                     vector[i] = rnd.Next(-50, 51);

                     suma = suma + vector[i];
                 }

                 // Calcular promedio
                 promedio = (double)suma / 20;

                 // Contar mayores y menores al promedio
                 for (int i = 0; i < 20; i++)
                 {
                     if (vector[i] > promedio)
                     {
                         mayores++;
                     }
                     else if (vector[i] < promedio)
                     {
                         menores++;
                     }
                 }

                 // Mostrar vector
                 Console.WriteLine("VECTOR:");

                 for (int i = 0; i < 20; i++)
                 {
                     Console.Write(vector[i] + " ");
                 }

                 Console.WriteLine("\n\nPromedio: " + promedio);
                 Console.WriteLine("Números mayores al promedio: " + mayores);
                 Console.WriteLine("Números menores al promedio: " + menores);

                 Console.ReadKey();
             }*/
            //-----------------------------------------------------------------------------------------------------------------

            //4.Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el 
            //orden de los elementos del vector. Se deben mostrar lo dos vectores. 


            /* {
                 int tamaño;

                 Console.Write("Ingrese el tamaño del vector: ");
                 tamaño = int.Parse(Console.ReadLine());

                 char[] vector = new char[tamaño];
                 char[] invertido = new char[tamaño];

                 // Llenar el vector
                 for (int i = 0; i < tamaño; i++)
                 {
                     Console.Write("Ingrese el carácter " + (i + 1) + ": ");
                     vector[i] = char.Parse(Console.ReadLine());
                 }

                 // Invertir el vector
                 for (int i = 0; i < tamaño; i++)
                 {
                     invertido[i] = vector[tamaño - 1 - i];
                 }

                 // Mostrar vector original
                 Console.WriteLine("\nVECTOR ORIGINAL:");

                 for (int i = 0; i < tamaño; i++)
                 {
                     Console.Write(vector[i] + " ");
                 }

                 // Mostrar vector invertido
                 Console.WriteLine("\n\nVECTOR INVERTIDO:");

                 for (int i = 0; i < tamaño; i++)
                 {
                     Console.Write(invertido[i] + " ");
                 }

                 Console.ReadKey();
             }*/

            //-----------------------------------------------------------------

            //5.Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 
            /*0 y 50.Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
            número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
            vector resaltando el número en un color diferente.Si no se encuentra el número, se debe
            devolver y mostrar - 1.*/

            
            {
                /*    int[] vector = new int[20];

                    Random rnd = new Random();

                    // Llenar vector
                    for (int i = 0; i < 20; i++)
                    {
                        vector[i] = rnd.Next(0, 51);
                    }

                    Console.WriteLine("VECTOR GENERADO:");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write($"{vector[i]} ");
                    }

                    Console.Write("Ingrese el número que desea buscar: ");
                    int numero = int.Parse(Console.ReadLine());

                    int posicion = -1;

                    // Buscar número
                    for (int i = 0; i < 20; i++)
                    {
                        if (vector[i] == numero)
                        {
                            posicion = i;
                            break;
                        }
                    }

                    if (posicion != -1)
                    {
                        Console.WriteLine("El número fue encontrado.");
                        Console.WriteLine("Está en la posición: " + (posicion + 1));

                        Console.WriteLine("VECTOR:");

                        for (int i = 0; i < 20; i++)
                        {
                            if (vector[i] == numero)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;  //FORMA PARA RESALTAR EL NUMERO, EN ESTE CASO EL COLOR ES ROJO.
                                Console.Write(vector[i] + " ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write($"{vector[i]} ");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\-1");
                        Console.WriteLine("El número no se encuentra en el vector.");
                    }

                    Console.ReadKey();*/

                //----------------------------------------------------------------------------------------------------------
                //6.Escribir un algoritmo que permita: 
                /* a.Crear un vector con rango impar, exceptuando el 1.
                 b.Pedirle al usuario un número entero y almacenarlo en la mitad del vector. 
                 c.Llenar la primera mitad del vector, con los números menores al número almacenado
                  en la posición de la mitad. 
                 d.Llenar la parte inicial del vector, con los números menores al número almacenado
                   en la posición de la mitad. 
                 e.Llenar la parte final del vector, con los números mayores al número almacenado en
                 la posición de la mitad. 
                 f.Mostrar el vector en pantalla.*/



                /*int tamaño;

                Console.Write("Ingrese un tamaño impar mayor que 1: ");
                tamaño = int.Parse(Console.ReadLine());

                // Validar que sea impar y diferente de 1
                while (tamaño % 2 == 0 || tamaño == 1)
                {
                    Console.Write("Debe ingresar un número impar mayor que 1: ");
                    tamaño = int.Parse(Console.ReadLine());
                }

                int[] vector = new int[tamaño];

                int mitad = tamaño / 2;

                Console.Write("Ingrese el número que estará en la mitad: ");
                int numero = int.Parse(Console.ReadLine());

                vector[mitad] = numero;

                Random rnd = new Random();

                // Llenar primera mitad con números menores
                for (int i = 0; i < mitad; i++)
                {
                    vector[i] = rnd.Next(numero - 50, numero);
                }

                // Llenar segunda mitad con números mayores
                for (int i = mitad + 1; i < tamaño; i++)
                {
                    vector[i] = rnd.Next(numero + 1, numero + 51);
                }

                // Mostrar vector
                Console.WriteLine("VECTOR:");

                for (int i = 0; i < tamaño; i++)
                {
                    Console.Write($"{vector[i]} : ");
                }

                Console.ReadKey();*/


                //-----------------------------------------------------------------------
                //7. Escribir un algoritmo que permita: 
                /* a.Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el
                 usuario.
                 b.LLenar el primer vector con números aleatorios entre 0 y su rango + 1
                 c.LLenar el segundo vector con números aleatorios entre rango y rango * 2
                 d.Combinar los dos vectores en uno solo.
                 e.Mostrar en pantalla los tres vectores*/


                /*{
                    int rango1, rango2;

                    Console.Write("Ingrese el rango del primer vector: ");
                    rango1 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el rango del segundo vector: ");
                    rango2 = int.Parse(Console.ReadLine());

                    int[] vector1 = new int[rango1];
                    int[] vector2 = new int[rango2];

                    Random rnd = new Random();

                    // Llenar primer vector
                    for (int i = 0; i < rango1; i++)
                    {
                        vector1[i] = rnd.Next(0, rango1 + 1);
                    }

                    // Llenar segundo vector
                    for (int i = 0; i < rango2; i++)
                    {
                        vector2[i] = rnd.Next(rango2, (rango2 * 2) + 1);
                    }

                    // Crear vector combinado
                    int[] vector3 = new int[rango1 + rango2];

                    // Copiar primer vector
                    for (int i = 0; i < rango1; i++)
                    {
                        vector3[i] = vector1[i];
                    }

                    // Copiar segundo vector
                    for (int i = 0; i < rango2; i++)
                    {
                        vector3[rango1 + i] = vector2[i];
                    }

                    // Mostrar primer vector
                    Console.WriteLine("VECTOR 1:");

                    for (int i = 0; i < rango1; i++)
                    {
                        Console.Write(vector1[i] + " ");
                    }

                    // Mostrar segundo vector
                    Console.WriteLine("VECTOR 2:");

                    for (int i = 0; i < rango2; i++)
                    {
                        Console.Write(vector2[i] + " ");
                    }

                    // Mostrar vector combinado
                    Console.WriteLine("VECTOR COMBINADO:");

                    for (int i = 0; i < vector3.Length; i++)
                    {
                        Console.Write(vector3[i] + " ");
                    }

                    Console.ReadKey();
                }*/



                //--------------------------------------------------

                //8. Escribir un algoritmo que permita: 
                /* a.Crear un vector de nombres.
                 b.Solicitar una letra al usuario. 
                 c.Contar cuántos nombres empiezan con esa letra.*/

                /*{
                    int cantidad;

                    Console.Write("¿Cuántos nombres desea ingresar?: ");
                    cantidad = int.Parse(Console.ReadLine());

                    string[] nombres = new string[cantidad];

                    // Llenar el vector
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write($"Ingrese el nombre {(i + 1)}: ");
                        nombres[i] = Console.ReadLine();
                    }

                    Console.Write("\nIngrese la letra que desea buscar: ");
                    char letra = char.Parse(Console.ReadLine());

                    int contador = 0;

                    // Recorrer el vector
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (char.ToUpper(nombres[i][0]) == char.ToUpper(letra))
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine("\nCantidad de nombres que empiezan por "
                        + letra + ": " + contador);

                    Console.ReadKey();
                }*/

                //9. Escribir un algoritmo que permita: 
                /*a.Crear un vector de nombres.
                b.Identificar cuáles se repiten.
                c.Mostrar cuántas veces aparece cada uno.*/



                /*{
                    int cantidad;

                    Console.Write("Ingrese la cantidad de nombres: ");
                    cantidad = int.Parse(Console.ReadLine());

                    string[] nombres = new string[cantidad];

                    // Llenar el vector
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write("Ingrese el nombre " + (i + 1) + ": ");
                        nombres[i] = Console.ReadLine();
                    }

                    Console.WriteLine("\nNOMBRES REPETIDOS:");

                    for (int i = 0; i < cantidad; i++)
                    {
                        int contador = 0;
                        int repetidoAntes = 0;

                        // Contar cuántas veces aparece el nombre
                        for (int j = 0; j < cantidad; j++)
                        {
                            if (nombres[i] == nombres[j])
                            {
                                contador++;
                            }
                        }

                        // Revisar si ese nombre ya fue mostrado antes
                        for (int j = 0; j < i; j++)
                        {
                            if (nombres[i] == nombres[j])
                            {
                                repetidoAntes++;
                            }
                        }

                        // Mostrar solamente si está repetido
                        // y todavía no se ha mostrado
                        if (contador > 1 && repetidoAntes == 0)
                        {
                            Console.WriteLine(nombres[i] +
                                              " se repite " +
                                              contador + " veces");
                        }
                    }

                    Console.ReadKey();
                }*/

                /*//10. Escribir un algoritmo que permita: 
                a.Llenar un vector[30] con números enteros aleatorios entre 1 y 100.
                b.Analizar el vector para encontrar la secuencia consecutiva ascendente más larga
                (por ejemplo, si el vector tiene partes como [12, 13, 14, 15], esa es una
                secuencia de longitud 4). 
c.Guardar o identificar la posición de inicio y el tamaño de dicha secuencia.
d.Mostrar en pantalla el vector completo resaltando o imprimiendo únicamente el
subconjunto que forma la secuencia ascendente más larga encontrada.*/

                /*    
                {
                    int[] vector = new int[30];

                    Random rnd = new Random();

                    // Llenar vector
                    for (int i = 0; i < 30; i++)
                    {
                        vector[i] = rnd.Next(1, 101);
                    }

                    // Mostrar vector original
                    Console.WriteLine("VECTOR GENERADO:\n");

                    for (int i = 0; i < 30; i++)
                    {
                        Console.Write(vector[i] + " ");
                    }

                    int inicioActual = 0;
                    int tamañoActual = 1;

                    int mejorInicio = 0;
                    int mejorTamaño = 1;

                    // Buscar la secuencia consecutiva más larga
                    for (int i = 1; i < 30; i++)
                    {
                        if (vector[i] == vector[i - 1] + 1)
                        {
                            tamañoActual++;

                            if (tamañoActual > mejorTamaño)
                            {
                                mejorTamaño = tamañoActual;
                                mejorInicio = inicioActual;
                            }
                        }
                        else
                        {
                            inicioActual = i;
                            tamañoActual = 1;
                        }
                    }

                    Console.WriteLine("\n\nLa secuencia ascendente más larga tiene "
                        + mejorTamaño + " elementos.");

                    Console.WriteLine("Comienza en la posición: "
                        + (mejorInicio + 1));

                    // Mostrar vector resaltando la secuencia
                    Console.WriteLine("\nVECTOR CON LA SECUENCIA RESALTADA:\n");

                    for (int i = 0; i < 30; i++)
                    {
                        if (i >= mejorInicio &&
                            i < mejorInicio + mejorTamaño)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(vector[i] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(vector[i] + " ");
                        }
                    }

                    Console.ReadKey();
                }*/

                /*11.Escribir un algoritmo que permita: 
a.Crear un vector de 15 nombres completos ingresados por el usuario. 
b.Recorrer cada nombre carácter por carácter para analizar cuántas veces aparece
cada vocal(A, E, I, O, U) sumando las de todos los nombres del vector(sin
distinguir entre mayúsculas y minúsculas). 
c.Utilizar vectores paralelos para almacenar el conteo de cada vocal. 
d.Ordenar las vocales de mayor a menor frecuencia de aparición basándose en los
resultados obtenidos.
e.Mostrar un reporte en pantalla que funcione como un histograma básico de
frecuencias de las vocales.*/

             
            {
                string[] nombres = new string[15];

                char[] vocales = { 'A', 'E', 'I', 'O', 'U' };

                int[] cantidades = new int[5];

                // Ingresar los nombres
                for (int i = 0; i < 15; i++)
                {
                    Console.Write("Ingrese el nombre completo "
                        + (i + 1) + ": ");

                    nombres[i] = Console.ReadLine();
                }

                // Recorrer todos los nombres
                for (int i = 0; i < 15; i++)
                {
                    string nombre = nombres[i].ToUpper();

                    // Recorrer cada carácter del nombre
                    for (int j = 0; j < nombre.Length; j++)
                    {
                        if (nombre[j] == 'A')
                        {
                            cantidades[0]++;
                        }
                        else if (nombre[j] == 'E')
                        {
                            cantidades[1]++;
                        }
                        else if (nombre[j] == 'I')
                        {
                            cantidades[2]++;
                        }
                        else if (nombre[j] == 'O')
                        {
                            cantidades[3]++;
                        }
                        else if (nombre[j] == 'U')
                        {
                            cantidades[4]++;
                        }
                    }
                }

                // Ordenar de mayor a menor
                for (int i = 0; i < 4; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (cantidades[j] > cantidades[i])
                        {
                            int auxiliarCantidad = cantidades[i];
                            cantidades[i] = cantidades[j];
                            cantidades[j] = auxiliarCantidad;

                            char auxiliarVocal = vocales[i];
                            vocales[i] = vocales[j];
                            vocales[j] = auxiliarVocal;
                        }
                    }
                }

                // Mostrar resultados
                Console.WriteLine("\nFRECUENCIA DE VOCALES:");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(vocales[i] + ": "
                        + cantidades[i]);
                }

                // Histograma
                Console.WriteLine("\nHISTOGRAMA:");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(vocales[i] + " | ");

                    for (int j = 0; j < cantidades[i]; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine(" " + cantidades[i]);
                }

                Console.ReadKey();
            }
        }
    }
    }
 }


 


  


    
    