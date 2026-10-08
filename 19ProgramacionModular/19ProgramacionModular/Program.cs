using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _19ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)   //LOS MODULOS SON INDEPENDIENTES ENTRE SI PERO PUEDO LLAMARLOS PARA REALIZAR UNA TAREA EN CUALQUIER MODULO.
        {
            MostrarMenu();
           
            RealizarOperaciones(CapturarOpcion());  //es mas facil asi que poner uno a uno
        }

        static float suma()  //funcion, devuelve VARIABLES LOCALES  //SI NO HAY RETURN SALE ERROR
        {
            float suma = 0;  //acumulador
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("INGRESE LOS NUMEROS QUE DESEE INGRESAR");
                numero = float.Parse(Console.ReadLine());
                suma += numero;

                Console.WriteLine("DESEA INGRESAR MAS NUMEROS, INGRESE S PARA CONTINUAR");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
           return suma;    //EL RETURN ES AFUERA DEL CICLO

         }

        static float resta()
        {

            float resta = 0;  //acumulador
            float numero1 = 0;
            float numero2 = 0;

            Console.WriteLine("INGRESE PRIMER NUMERO");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE SEGUNDO NUMERO");
            numero2 = float.Parse(Console.ReadLine());

            resta = numero1-numero2;

            return resta;
        }

        static float division()
        {

            float division = 0;  //acumulador
            float numero1 = 0;
            float numero2 = 0;

            Console.WriteLine("INGRESE PRIMER NUMERO");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE SEGUNDO NUMERO");
            numero2 = float.Parse(Console.ReadLine());

            division = numero1 / numero2;

            return division;
        }

        static float multiplicacion()
        {
            float multiplicacion = 1;  //acumulador SI EMPIEZA EN 1 SI ES MULTIPLICAR EMPIEZA EN 1, SI NO DA 0
            float numero = 0;
            char respuesta = ' ';


            do
            {
                Console.WriteLine("INGRESE EL NUMERO QUE DESEE INGRESAR");
                numero = float.Parse(Console.ReadLine());

                multiplicacion *= numero;

                Console.WriteLine("DESEA INGRESAR MAS NUMEROS, INGRESE S PARA CONTINUAR");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');

            return multiplicacion;    //EL RETURN ES AFUERA DEL CICLO

        }

        static void RealizarOperaciones(int opcion) //AGARRA EL NUMERO DE LA OPCION (EN ESTE CASO ES NUMERO ENTERO)
        {
            while(opcion != 0)
          {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"LA SUMA DE LOS NUMEROS ES: {suma()}");
                    break;
                case 2:
                    Console.WriteLine($"LA RESTA DE LOS NUMEROS ES: {resta()}");
                    break;
                case 3:
                    Console.WriteLine($"LA MUKTIPLICACION DE LOS NUMEROS ES: {multiplicacion()}");
                    break;
                case 4:
                    Console.WriteLine($"LA DIVISION DE LOS NUMEROS ES: {division()}");
                    break;

                        

            }
                Console.ReadKey();
                BorrarPantalla();
                MostrarMenu();   //se puede llamar de cualquier modulo
                opcion = CapturarOpcion(); 
            }
            

        }
        static int CapturarOpcion()  //EL STATIC POR EL TIPO DE CLASE QUE TIENE LA CONSOLA, EL INT ES PARA QUE DEVUELVA
                                     //EL TIPO DE DATO QUE EL USUARIO SELECCIONE, EN ESTE CASO UN NUMERO 
        {

            return int.Parse(Console.ReadLine());
        }

       

            static void MostrarMenu()
        {
            Console.WriteLine("------------------MENU-----------------------");
            Console.WriteLine("1. SUMA                         2. RESTA");
            Console.WriteLine("3. MULTIPLICACION               4. DIVISION");
            Console.WriteLine("0. SALIR");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("INGRESE UNA OPCION DEL MENU:");

        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }
    }
}
