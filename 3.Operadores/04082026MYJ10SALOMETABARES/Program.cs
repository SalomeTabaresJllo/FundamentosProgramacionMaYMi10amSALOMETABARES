using System;


namespace _04082026MYJ10SALOMETABARES  //ejemplos de clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3 * 2;
            float dato3 = 4f * ( 2f / 3);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato1);
            Console.WriteLine(dato2);
            Console.WriteLine(dato3);
            Console.WriteLine(dato4);

            //OPERADORES LOGICOS: conjuncion - AND - Y - &&
            Console.WriteLine("TABLA CONJUNCION");
            Console.WriteLine(" V && V = "+(true && true));
            Console.WriteLine("V && F = "+(true && false));
            Console.WriteLine("F && V = " + (false & true));
            Console.WriteLine(" F && F = "+(false && false));
            Console.WriteLine("----------------");

            //Disyuncion - QR - 0 - ||

            Console.WriteLine("TABLA CONJUNCION");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("----------------");

            //OPERADORES DE COMPARACION
            bool dato6 = 5 > 4;
            bool dato7 = 100 == 99;
            bool dato8 = true;
            bool dato9 = !dato8;
            bool dato10 = 1002 != 102;
            bool dato11 = 10 >= 10;
            bool dato12 = 12 < 11 && 0 == 1;
            bool dato13 = dato8 && 0 != 10 || !dato10;
            Console.WriteLine(dato6);
            Console.WriteLine(dato7);
            Console.WriteLine(dato8);
            Console.WriteLine(dato9);
            Console.WriteLine(dato10);
            Console.WriteLine(dato11);
            Console.WriteLine(dato12);
            Console.WriteLine(dato13);
        }
    }
}
