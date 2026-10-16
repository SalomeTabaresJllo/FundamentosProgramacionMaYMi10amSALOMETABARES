using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOSTEAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CICLO WHILE 1: 
            /*
                        int suma = 0;

                        Console.Write("Ingrese un número entero positivo (negativo para salir): ");
                        int numero = int.Parse(Console.ReadLine());

                        while (numero >= 0)
                        {
                            suma = suma + numero;

                            Console.WriteLine("Ingrese otro número (negativo para salir): ");
                            numero = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("El total de la suma es: " + suma);*/

            //----------------------------------------------------------------------------------------------

            /*Random generador = new Random();
            int numero = generador.Next(1, 101); // 1 AL 100
            int intento = 0;
            int contador = 0;

            Console.WriteLine("Intenta adivinar el numero");

            while (intento != numero)
            {
                Console.Write("Ingresa tu intento: ");
                intento = int.Parse(Console.ReadLine());
                contador++;

                if (intento > numero)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else if (intento < numero)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Adivinaste el número.");
                }
            }
            Console.WriteLine("Tus intentos fueron: " + contador);*/

            //----------------------------------------------------------------------------------------------



              /*  Console.Write("Ingrese el primer número del rango: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número del rango: ");
                int num2 = int.Parse(Console.ReadLine());

                int inicio = Math.Min(num1, num2);
                int fin = Math.Max(num1, num2);

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Evaluando desde " + inicio + " hasta " + fin + ":");
                Console.WriteLine("----------------------------------");

                int cantidadMultiplos = 0;

                for (int i = inicio; i <= fin; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("* " + i + " es múltiplo de 5");
                        cantidadMultiplos++;
                    }
                }

                if (cantidadMultiplos == 0)
                {
                    Console.WriteLine("No se encontraron múltiplos de 5 en este rango.");
                }*/
        }
    }
}      


