using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ProgramaModular
{
    internal class Program
    {
        static void Main(string[] args)  //PROCEDIMIENTO: "VOID" NO DEVUELVE NADA
        {

            Console.WriteLine("BIENVENIDO AL PARQUE DE TERROR");
            MostrarMensajes("SALOME");
            MostrarMensaje("SALOME", "TABARES");
            Console.ReadKey();

            BorrarPantalla();



        }
        //PROCEDIMIENTOS SIN PARAMETROS
        static void BorrarPantalla()  //NO SE MODIFICA
        {
            Console.Clear();
        }


        //PROCEDIMIENTOS CON PARAMETROS
        static void MostrarMensajes(string nombre)
        {
            Console.WriteLine($"BIENVENIDO {nombre} AL PARQUE DEL TERROR");
        }

        static void
            MostrarMensaje(string nombre, string apellidos)  //DIFERENCIA = NUMERO DE PARAMETROS 
        {
            Console.WriteLine($"BIENVENIDO {nombre} {apellidos} AL PARQUE DEL TERROR");
        }
    }
}
