using System;

namespace _4.CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estructura de control adicional 
            //condicional simple 
            //1. algoritmo que lea la edad y si es 18o mas diga "bienvenido a mi sitio web"

            /*byte edad = 0;
            Console.WriteLine("Ingrese su Edad");
            edad = Convert.ToByte(Console.ReadLine());      //todo lo que se lea se ve como un string (por eso el error) - se añade una clase convert

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");   //s la condicion = true mostrar mensaje   //EJERCICIO HECHO EN CLASE 


            }
            else
            {
                Console.WriteLine("no es apto para e contenido del sitio web");
            }
*/
            //2. ALGORITMO INGRESAR NOMBRE Y SUELDO DE UNA PERSONA  SI EL SUELDO >3000 PESOS , INDICA QUE DEBE AGAR IMPUESTOS

            /*   Console.WriteLine("ingrese su nombre");
               Console.ReadLine();
               Console.WriteLine("ingrese su sueldo");
               float sueldo = 0f;
               sueldo = Convert.ToSingle(Console.ReadLine());

               if (sueldo >= 3000)
               {
                   Console.WriteLine("DEBE PAGAR IMPPUESTOS");
               }
               else
               {
                   Console.WriteLine ("NO DEBE PAGAR IMPUESTOS ");
               }*/

            //ALGORITMO QUE PERMITA INGREAR 2 UMEROS SI EL PRIMERO ES MAYOR AL SEGUNDO PONER SU SUMA Y DIFERENCIA EN CASO CONTRARIO INFORMAAR EL PRODUCTO Y DIVISION DEL PRIMER NUMERO RESPECTO AL SEGUNDO NUMERO

            float num1 = 0.0f;
            float num2 = 0.0f;
            Console.WriteLine("ingrese numero 1");
            num1 = Convert.ToSingle (Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            num2 = Convert.ToSingle(Console.ReadLine());


            if (num1 > num2) 
                {
                Console.WriteLine("numero 1 es mayor, por lo que la suma y diferencia de ambos seria " + (num1 + num2) + " y " + (num1 - num2));
            }
            else
            {
                Console.WriteLine("num2 es mayor o igual, por lo que la multiplicacion y division de ambos seria " + (num2 * num1) + " y " + (num2 / num1));
            }
        }
    }
}
