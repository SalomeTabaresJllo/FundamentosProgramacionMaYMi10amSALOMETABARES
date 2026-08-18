using System;

namespace _7.TALLER_STJ18082026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DISEÑAR ALGORITMO DONDE SE INGRESAN 3 NUMEROS Y DECIR CUAL ES EL MAYOR y MENCIONE EL ORDEN DE MAYOR A MENOR

            /*int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("SE DEBE INGRESAR 3 NUMEROS DIFERENTES");
            Console.WriteLine("INGRESE NUMERO 1 ");
            num1 = int.Parse(Console.ReadLine());   // int.parse es otra manera de convertir 
            Console.WriteLine("INGRESE NUMERO 2 ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE NUMERO 3 ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num2 != num3 && num3 != num1)
            {
                Console.WriteLine("LOS NUMEROS SON DIFERENTES");
                if (num1 > num2 && num1 > num3)
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("EL MAYOR ES " + num1 + " EL MEDIO ES " + num2 + " EL MENOR ES " + num3);
                    }
                    else
                    {
                        Console.WriteLine("EL MAYOR ES " + num1 + " EL MEDIO ES " + num3 + " EL MENOR ES " + num2);
                    }
                }
                if (num2 > num1 && num2 > num3)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("EL MAYOR ES " + num2 + " EL MEDIO ES " + num1 + " EL MENOR ES " + num3);
                    }
                    else
                    {
                        Console.WriteLine("EL MAYOR ES " + num2 + " EL MEDIO ES " + num3 + " EL MENOR ES " + num1);
                    }
                }
                if (num3 > num2 && num3 > num1)
                {
                    if (num2 > num1)
                    {
                        Console.WriteLine("EL MAYOR ES " + num3 + " EL MEDIO ES " + num2 + " EL MENOR ES " + num1);
                    }
                    else
                    {
                        Console.WriteLine("EL MAYOR ES " + num3 + " EL MEDIO ES " + num1 + " EL MENOR ES " + num2);
                    }
                }

            }

            else
            {
                Console.WriteLine("DEBE INGRESAR NUMEROS DIFERENTES");
            }*/


            //2. El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si CUENTA CON MUNICIION Y SE ENCUENTRA EN ESTADO INVNCIBLE
            //A. PERMITA INGRESAR POR TECLADO SI EL PERSONAJE ESTA EN ESTADO INVENCIBLE, B. LA CANTIDAD DE MUNICION LO ELEGIRA LA MAQUINA 
            //C. SI ESTA EN ESTADO INVENCIBLE Y ESTA ENTRE 1 Y 10 DISPARA Y TIENE MUNICION, SI NO NO HACER NADA.


            /*string estado ;
            Console.WriteLine("SU PERSONAJE ESTA EN ESTADO INVENCIBLE, DIGITE SI O NO");
            estado = Console.ReadLine();

            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 20);//Devuelve un número entre 0 y 19
            Console.WriteLine(numero);

            if (estado == "si" && numero<=10)
            {
                Console.WriteLine("SU PERSONAJE ESTA DISPARRANDO");
            }
            else
            {

            }
*/

            //3. PREGUNTAR 3 PUNTOS CON CORDENADA X Y Y Y CALCULAR DISTANCIA DE CADA PUNTO Y SABER SI SE CUMPLEN LAS CONDCIONES PARA UN TRIANGULO. 
            // FORMULA DISTANCIA = √((x2 - x1)² + (y2 - y1)²) 

            float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 0;
            float x3 = 0;
            float y3 = 0;

            Console.WriteLine("DIGITE LAS COORDENADAS X Y Y DESEADAS PARA LOS 3 PUNTOS ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("PUNTO 1");
            Console.WriteLine("EN X");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("EN Y");
            y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("PUNTO 2");
            Console.WriteLine("EN X");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("EN Y");
            y2 = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("PUNTO 3");
            Console.WriteLine("EN X");
            x3 = float.Parse(Console.ReadLine());
            Console.WriteLine("EN Y");
            y3 = float.Parse(Console.ReadLine());

            float distancia1 = (float) Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2 - y1), 2));

            Console.WriteLine(" LA DISTANCIA DE PUNTO 1 A PUNTO 2 ES " + distancia1);

            //Console.WriteLine("LA DISTANCIA DEL PUNTO 1 AL PUNTO 2 ES " + distancia  (Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)) );
        }

    }

}

