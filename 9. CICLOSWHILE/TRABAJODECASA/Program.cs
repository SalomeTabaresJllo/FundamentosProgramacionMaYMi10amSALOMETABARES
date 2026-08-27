using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJODECASA
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un
            //número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.

            int contador = 1;
            int acumulador = 0;  //SE PUEDE 0 PARA SUMA, 1 PARA MULTIPLICAR
            int numero = 0;


            Console.WriteLine("INGRESE EL NUMERO A SUMAR");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)  //positivo
            {

                acumulador += numero;
                Console.WriteLine("INGRESE EL NUMERO A SUMAR");           //CICLO PARA PEDIR EL NUMERO MIENTRAS SEA POSITIVO
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("LA SUMA DE LOS NUMEROS INGRESADOS ES " + acumulador);   //AL INGRESAR UN NEGATIVO, AGABA EL CICLO Y EL SISTEMA HACE LA SUMA*/




            //2. ALGORITMO QUE PIDA INGRESAR UN NUMERO DE ENTEROS AL AZAR (PREGUNTAR CUANTOS DESEA INGRESAR) Y QUE EL ALGORITMO MUESTRE =
            // LA CANTIDAD DE NUMEROS INTRODUCIDOS QUE SON MAYORES a 0
            // LA CANTIDAD DE NUMEROS INTRODUCIDOS MENORES QUE 0
            // LA CANTIDAD DE NUMEROS IGUALES A 0


            /*  int contador = 0;  //PARA CONTAR CUANTOS NUMEROS LLEVA INGRESADO EL SISTEMA
              int numero = 0;
              int cantidad = 0;
              int contadormayores = 0;
              int contadormenores = 0;
              int contadoriguales = 0;


              Console.WriteLine("INGRESE LA CANTIDAD DE NUMEROS QUE DESEA EN EL ALGORITMO");
              cantidad = int.Parse(Console.ReadLine());

              while (contador < cantidad )  // el contador empieza en 0, por lo que se puede poner (ej) 6, para que sean 6 digitos ingresados.
              {
                  Console.WriteLine("INGRESE NUMERO");
                  numero = int.Parse(Console.ReadLine());
                  contador++;

                  if (numero > 0)  //positivo          //el if va dentro del while, los comentarios afuera.
                  {

                      contadormayores++;
                  }
                  else
                  {
                      if (numero < 0)  //negativo
                      {

                          contadormenores++;
                      }
                      else
                      {

                          contadoriguales++;
                      }
                  }

              }

              Console.WriteLine("CANTIDAD DE MAYORES A 0 : " + contadormayores + " CANTIDAD DE MENORES A 0: " + contadormenores + "CANTIDAD DE IGUALES A 0 : " + contadoriguales);*/


            //3. ALGORITMO QUE CUENTE CUANTOS NUMEROS PARES HAY EN UN RANGO DEL NUMERO 1 AL NUMERO N ( FUNCION MOD EN C# ) ....Math.IEEERemainder()

            int contador = 1;  //EL ALGORITMO INICIA EN 1 , POR LO QUE SE USA 1 
            int rango = 0;
            int pares = 0;
            

            Console.WriteLine("INGRESE LA CANTIDAD QUE DESEA PARA EL ALGORITMO");
            rango = int.Parse(Console.ReadLine());

            while (contador <= rango) 
            {
                if (contador % 2 == 0 )  //para saber si es par se divide entre 2 y el contador debe dar 0
                {
                    pares++;
                    Console.WriteLine(contador);
                }
                contador ++;
   
            }
            Console.WriteLine("HAY " + pares + " PARES EN EL RANGO DE 1 A " + rango);
        }
    }
}
