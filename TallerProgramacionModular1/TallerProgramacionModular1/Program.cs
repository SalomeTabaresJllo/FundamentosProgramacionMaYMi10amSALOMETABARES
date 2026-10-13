using System;

namespace TallerProgramacionModular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //USUARIO INGRESA PRIMERO PALABRA
            string palabra = IngresarPalabra();

            char[] Vector2 = ConvertirAVector(palabra);

            int consonantes = SumaConsonantes(Vector2);
            int vocales = SumaVocales(Vector2);

            Resultados(Vector2, vocales, consonantes);

            BorrarPantalla();

        }


        static string IngresarPalabra()
        {
            Console.WriteLine("INGRESE UNA PALABRA PARA EL CONTEO DE VOCALES Y CONSONANTES");
            return Console.ReadLine();
        }

        static string CapturarOpcion()
        {

            return Console.ReadLine();
        }

        static char[] ConvertirAVector(string texto)
        {
            //CON CHAR LA PALABRA SE DIVIDE POR LETRA

            char[] vector = new char[texto.Length];
            //.LEGTH RANGO DE LA PALABRA

            for (int i = 0; i < texto.Length; i++)
            {
                vector[i] = texto[i];
            }

            return vector;
        }

        static int SumaVocales(char[] vector)
        {
            int cantidadVocales = 0; // ACUMULADOR

            for (int i = 0; i < vector.Length; i++)  //ANALIZAR CADA PARTE DEL VECTOR
            {
                char letra = char.ToLower(vector[i]);

                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    cantidadVocales++;
                }
            }


            return cantidadVocales;

        }

        static int SumaConsonantes(char[] vector)
        {
            int cantidadConsonantes = 0; // ACUMULADOR

            for (int i = 0; i < vector.Length; i++)  //ANALIZAR CADA PARTE DEL VECTOR
            {
                char letra = char.ToLower(vector[i]);

                if (letra != 'a' && letra != 'e' && letra != 'i' && letra != 'o' && letra != 'u')
                {
                    cantidadConsonantes++;
                }
            }


            return cantidadConsonantes;
        }

        static void Resultados(char[] vector, int consonantes, int vocales)
        {
            string palabraCompleta = new string(vector);
            Console.WriteLine($"EN EL VECTOR '{palabraCompleta}', hay {consonantes} consonantes y {vocales} vocales");
        }
        static void BorrarPantalla()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}