using System;
namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;


            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine($"La suma de los numeros es: {acumulador}");*/

            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el1 hasta el 10.
            //Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar 

            /*int numero;
            int contador = 0;
            int acumulador = 1;
            char respuesta;

            do
            {
                

                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    contador++;
                    acumulador = contador * numero;
                    Console.WriteLine(contador + "," + acumulador);
                } while (contador < 10);
                
                contador = 0;
                Console.WriteLine("Quiere seguir?");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');*/

            //Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el numero 100

            int contador = 1;
            int contador2 = 1;
            int contadorDivisiones = 0;

            do
            {
                do
                {
                    if (contador % contador2 == 0)
                    {
                        contadorDivisiones++;
                    }

                    contador2++;
                } while (contador2 <= contador);
                contador2 = 1;

                if (contadorDivisiones == 2)
                {
                    Console.WriteLine(contador);
                }
                contadorDivisiones = 0;
                contador++;

            } while (contador <= 100);


        }
    }
}
