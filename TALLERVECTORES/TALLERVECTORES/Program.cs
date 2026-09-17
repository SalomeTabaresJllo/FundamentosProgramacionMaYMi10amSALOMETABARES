using System;


namespace TALLERVECTORES
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
            //encuentre y muestre el valor máximo y mínimo de los números ingresados.


            /*
                        int[] numero = new int[15];

                        int mayor = numero[0];

                        int menor = numero[0];


                        for (int i = 0; i < numero.Length; i++)
                        {
                            Console.WriteLine($"INGRESE EL NUMERO DE LA POSICION {i + 1}");
                            numero[i] = int.Parse(Console.ReadLine());


                            if (i == 0)
                            {
                                mayor = numero[i];
                                menor = numero[i];
                            }

                            if (numero[i] > mayor)
                            {
                                mayor = numero[i];
                            }

                            if (numero[i] < menor)
                            {
                                menor = numero[i];
                            }
                        }

                        Console.WriteLine($"EL NUMERO MAYOR INGRESADO ES {mayor}");
                        Console.WriteLine($"EL NUMERO MENOR INGRESADO ES {menor}");
            */

            //----------------------------------------------------------------------------------------------------

            //2. Escribir un algoritmo que permita: 
            /*a.Crear dos vectores del mismo tamaño.  
            b.Llenarlos con números.
            c.Comparar posición por posición.
            d.Indicar cuántos elementos son iguales. */

           
            int[] vector1 = new int[10];
            int[] vector2 = new int[10];

        }
    }
}
