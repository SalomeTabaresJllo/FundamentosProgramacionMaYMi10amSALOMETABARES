using System;


namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CONDICIONALES MULTIPLES
            //CREAR ALGORITMO DONDE EL USUARIO ELIGA UN NUMERO DEL MENU


            int respuesta = 0;
            Console.WriteLine("--------BIENVENIDO AL MENU---------");
            Console.WriteLine("ELIGA UNA OPCION DEL MENU;");
            Console.WriteLine("1. OPCION 1           2.OPCION 2");
            Console.WriteLine("3. OPCION 3           4.OPCION 4");
            Console.WriteLine("5. OPCION 5");
            Console.WriteLine("--------LOL---------");

            respuesta=int.Parse(Console.ReadLine());


            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("ELIGIO LA OPCION 1");
                    break;

                case 2:
                    Console.WriteLine("ELIGIO LA OPCION 2");
                    break;

                case 3:
                    Console.WriteLine("ELIGIO LA OPCION 3");
                    break;

                case 4:
                    Console.WriteLine("ELIGIO LA OPCION 4");
                    break;

                case 5:
                    Console.WriteLine("ELIGIO LA OPCION 5");
                    break;


                default:
                    Console.WriteLine("ELIJA UNA OPCION VALIDA");
                    break;
            }


        }
    }
}
