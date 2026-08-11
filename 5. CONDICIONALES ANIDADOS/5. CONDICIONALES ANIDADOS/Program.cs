using System;

namespace _5.CONDICIONALES_ANIDADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DISEÑAR ALGORITMO DONDE SE INGRESAN 3 NUMEROS Y DECIR CUAL ES EL MAYOR 

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("SE DEBE INGRESAR 3 NUMEROS DIFERENTES");
            Console.WriteLine("INGRESE NUMERO 1 ");
            num1= int.Parse (Console.ReadLine());   // int.parse es otra manera de convertir 
            Console.WriteLine("INGRESE NUMERO 2 ");
            num2= int.Parse (Console.ReadLine());
            Console.WriteLine("INGRESE NUMERO 3 ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            { 
                //verdadera

                if (num1>num3)
                    {
                    Console.WriteLine("el numero 1 es el mayor");
                }
              else
                {
                    Console.WriteLine("el numero 3 es mayor");
                }
            }
            else
            {
                if (num2 > num3) 
                    {
                    Console.WriteLine("el numero 2 es mayor");

            
                }
                else
                {
                    Console.WriteLine("el numero 3 es mayor");
                }
            }




        }
    }
}
