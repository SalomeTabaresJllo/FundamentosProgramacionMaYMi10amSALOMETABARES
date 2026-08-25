using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CICLOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* //ESCRIBA UN ALGORITMO QUR PERMITA GENERAR LOS PRIMEROS 5 NUMEROS ENTEROS POSITIVOS, RELIZAR Y MOSTRAR SU SUMA

             int contador = 1;  // cuantas unidades va cambiado, en este caso 1 (1-2-3-4-5-)
             int acumulador = 0;

             while (contador <= 5) //CONDICION PARA QUE SE CUMPLA
             {
                 acumulador = acumulador + contador;
                 contador++;
             }

             Console.WriteLine("LA SUMA DE LOS 5 PRIMEROS NUMEROS ENTEROS ES " + acumulador);*/

            //ALGORITMO QUE PERMITA CALCULAR LA FACTORIAL DE UN NUMERO DADO POR EL USUARIO ( EJ: 5!)

            int contador = 1;
            int acumulador = 1;
            int numero = 0;

            Console.WriteLine("INGRESE EL NUMERO QUE DESEA PARA FACTORIAL");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                acumulador = acumulador * contador;
                contador ++;
              
            }

            Console.WriteLine("EL FACTORIAL DE " + numero + " ES " + acumulador);
        }
    }
}
