using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CICLOFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CICLO FOR
            int acumulador = 0;

            for (int contador = 1; contador <=5; contador++)  //EJEMPLO HASTA EL 5
            {
                acumulador += contador;
            }

            Console.WriteLine("LA SUMA DE LOS PRIMEROS 5 NUMEROS ES" + acumulador);
        }
    }
}
