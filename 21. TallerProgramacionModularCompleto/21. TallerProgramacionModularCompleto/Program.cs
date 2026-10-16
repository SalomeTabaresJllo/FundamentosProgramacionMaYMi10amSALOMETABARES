using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21.TallerProgramacionModularCompleto
{
    internal class Program
    {
        /* static void Main(string[] args)
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
     }*/

        //===================================================================================================================================================================


        /* static string[] tareas = new string[5];
         static int totalTareas = 0;

         static void Main(string[] args)
         {
             int opcion = 0;

             while (opcion != 4)
             {
                 MostrarMenu();
                 Console.Write("Seleccione una opción: ");
                 opcion = int.Parse(Console.ReadLine());

                 if (opcion == 1)
                 {
                     AgregarTarea();
                 }
                 else if (opcion == 2)
                 {
                     EliminarTarea();
                 }
                 else if (opcion == 3)
                 {
                     MostrarTareas();
                 }
                 else if (opcion == 4)
                 {
                     Console.WriteLine("Saliendo del programa...");
                 }
                 else
                 {
                     Console.WriteLine("Opción no válida.");
                 }
             }
         }
         static void MostrarMenu()
         {
             Console.WriteLine("--- GESTOR DE TAREAS ---");
             Console.WriteLine("1. Agregar tarea");
             Console.WriteLine("2. Eliminar tarea");
             Console.WriteLine("3. Mostrar lista de tareas");
             Console.WriteLine("4. Salir");
         }

         static void AgregarTarea()
         {
             if (totalTareas >= 50)
             {
                 Console.WriteLine("La lista está llena (máximo 50 tareas).");
                 return;
             }

             Console.Write("Ingrese la descripción de la tarea: ");
             string tarea = Console.ReadLine();

             if (tarea != "")
             {
                 tareas[totalTareas] = tarea;  
                 totalTareas = totalTareas + 1;
                 Console.WriteLine("Tarea agregada correctamente.");
             } 
         }

         static void EliminarTarea()
         {
             if (totalTareas == 0)
             {
                 Console.WriteLine("No hay tareas registradas para eliminar.");
                 return;
             }

             MostrarTareas();

             Console.Write("Ingrese el número de la tarea a eliminar: ");
             int numero = int.Parse(Console.ReadLine());
             int indice = numero - 1;

             if (indice >= 0 && indice < totalTareas)
             { 
                 for (int i = indice; i < totalTareas - 1; i++)
                 {
                     tareas[i] = tareas[i + 1];
                 }

                 totalTareas = totalTareas - 1; 
                 Console.WriteLine("Tarea eliminada con éxito.");
             }
             else
             {
                 Console.WriteLine("Número de tarea no válido.");
             }
         }

         static void MostrarTareas()
         {
             if (totalTareas == 0)
             {
                 Console.WriteLine("La lista de tareas está vacía.");
                 return;
             }

             Console.WriteLine("Lista de Tareas:  ");
             for (int i = 0; i < totalTareas; i++)
             {
                 Console.WriteLine((i + 1) + ". " + tareas[i]);
             }
         }*/

        //=================================================================================================================================================================================================================

        /*static void Main(string[] args)
        {
            int opcionCategoria = 0;

            while (opcionCategoria != 5 && opcionCategoria < 5)
            {
                MenuCategorias();
                Console.WriteLine("SELECCIONE UNA OPCION: ");
                opcionCategoria = int.Parse(Console.ReadLine());

                if (opcionCategoria == 1)
                {
                    ConversionMasa();
                }
                else if (opcionCategoria == 2)
                {
                    ConversionCapacidad();
                }
                else if (opcionCategoria == 3)
                {
                    ConversionLongitud();
                }
                else if (opcionCategoria == 4)
                {
                    ConversionTiempo();
                }
                else if (opcionCategoria == 5)
                {
                    Console.WriteLine("ADIOS");
                }
                else
                {
                    Console.WriteLine("Opción no valida");
                    Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                }
            }
        }

        static void MenuCategorias()
        {
            Console.WriteLine("CONVERTIDOR DE UNIDADES: ");
            Console.WriteLine("1. Masa");
            Console.WriteLine("2. Capacidad");
            Console.WriteLine("3. Longitud");
            Console.WriteLine("4. Tiempo");
            Console.WriteLine("5. Salir");
        }


        static void ConversionMasa()
        {
            Console.WriteLine("CONVERTIDOR DE MASA:  ");
            Console.WriteLine("1. De kilogramos a gramos");
            Console.WriteLine("2. De gramos a kilogramos");
            Console.WriteLine("Seleccione el tipo de conversión: ");
            int Opcion = int.Parse(Console.ReadLine());

            if (Opcion == 1)
            {
                Console.WriteLine("Ingrese el valor en kilogramos: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor * 1000;
                MostrarResultado(valor, "kilogramos", resultado, "gramos");
            }
            else if (Opcion == 2)
            {
                Console.WriteLine("Ingrese el valor en gramos: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor / 1000;
                MostrarResultado(valor, "gramos", resultado, "kilogramos");
            }
            else
            {
                Console.WriteLine("Opción de conversión no válida.");
                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadLine();
            }
        }

        static void ConversionCapacidad()
        {
            Console.WriteLine("Conversión de Capacidad: ");
            Console.WriteLine("1. De litro a mililitro");
            Console.WriteLine("2. De mililitro a litro");
            Console.WriteLine("Seleccione el tipo de conversión: ");
            int Opcion = int.Parse(Console.ReadLine());

            if (Opcion == 1)
            {
                Console.WriteLine("Ingrese el valor en litros: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor * 1000;
                MostrarResultado(valor, "litros", resultado, "mililitros");
            }
            else if (Opcion == 2)
            {
                Console.WriteLine("Ingrese el valor en mililitros: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor / 1000;
                MostrarResultado(valor, "mililitros", resultado, "litros");
            }
            else
            {
                Console.WriteLine("Opción de conversión no válida.");
                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadLine();
            }
        }

        static void ConversionLongitud()
        {
            Console.WriteLine("Conversión de Longitud:");
            Console.WriteLine("1. De kilometro a metro");
            Console.WriteLine("2. De metro a kilometro");
            Console.WriteLine("Seleccione el tipo de conversión: ");
            int Opcion = int.Parse(Console.ReadLine());

            if (Opcion == 1)
            {
                Console.WriteLine("Ingrese el valor en kilómetros: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor * 1000;
                MostrarResultado(valor, "kilómetros", resultado, "metros");
            }
            else if (Opcion == 2)
            {
                Console.WriteLine("Ingrese el valor en metros: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor / 1000;
                MostrarResultado(valor, "metros", resultado, "kilómetros");
            }
            else
            {
                Console.WriteLine("Opción de conversión no válida.");
                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadLine();
            }
        }

        static void ConversionTiempo()
        {
            Console.WriteLine("\n-- Conversión de Tiempo --");
            Console.WriteLine("1. De hora a segundos");
            Console.WriteLine("2. De segundos a hora");
            Console.WriteLine("Seleccione el tipo de conversión: ");
            int Opcion = int.Parse(Console.ReadLine());

            if (Opcion == 1)
            {
                Console.WriteLine("Ingrese el valor en horas: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor * 3600;
                MostrarResultado(valor, "horas", resultado, "segundos");
            }
            else if (Opcion == 2)
            {
                Console.WriteLine("Ingrese el valor en segundos: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor / 3600;
                MostrarResultado(valor, "segundos", resultado, "horas");
            }
            else
            {
                Console.WriteLine("Opción de conversión no válida.");
                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadLine();
            }
        }

        static void MostrarResultado(double valorInicial, string unidadInicial, double valorFinal, string unidadFinal)
        {
            Console.WriteLine($"{valorInicial} {unidadInicial} son {valorFinal} {unidadFinal}");
            Console.ReadKey();
        }*/



        //===========================================================================================================================================================================


        /*static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            string[,] matrizContactos = new string[filas, columnas];
           
            LlenarMatriz(matrizContactos, filas, columnas);

            MostrarMatriz(matrizContactos, filas, columnas);

            Console.WriteLine("Ingrese el nombre del contacto que desea buscar: ");
            string nombre = Console.ReadLine();

            BuscarYModificarContacto(matrizContactos, filas, columnas, nombre);

            Console.WriteLine("--- MATRIZ ACTUALIZADA ---");
            MostrarMatriz(matrizContactos, filas, columnas);

            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA FINALIZAR");
            Console.ReadLine();
        }

        static void LlenarMatriz(string[,] matriz, int filas, int columnas)
        {
            Console.WriteLine("INGRESAR CONTACTOS: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese el nombre para la posición [{i + 1}, {j + 1}]: ");
                    string entrada = Console.ReadLine();

                    if (entrada == "" )
                    {
                        matriz[i, j] = "Sin Nombre";
                    }
                    else
                    {
                        matriz[i, j] = entrada;
                    }
                }
            }
        }

        static void MostrarMatriz(string[,] matriz, int filas, int columnas)
        {
            Console.WriteLine("CONTACTOS");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"[{matriz[i, j]}] ");
                }
                Console.WriteLine();
            }
        }

        static void BuscarYModificarContacto(string[,] matriz, int filas, int columnas, string nombre)
        {
            bool encontrado = false;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] == nombre)
                    {
                        encontrado = true;

                        
                        Console.WriteLine($"Contacto {nombre} encontrado en la posición ({i + 1}, {j + 1}).");
                        Console.WriteLine("Ingrese el nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();

                        
                        matriz[i, j] = nuevoNombre;

                        
                        Console.WriteLine("--- DATOS DE LA MODIFICACIÓN ---");
                        Console.WriteLine($"Nombre encontrado: {nombre}");
                        Console.WriteLine($"Posición en la matriz: ({i + 1}, {j + 1})");
                        Console.WriteLine($"Nuevo nombre ingresado: {nuevoNombre}");
                    }
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine($"El contacto {nombre} no se encuentra en la matriz.");
            }
        }*/

        //===========================================================================================================================================================



        // Tablero de 3x3 como variable global para que todos los métodos lo compartan


        // Tablero global de 3x3

        // Tablero inicial con números del 1 al 9
        static char[,] tablero = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

        static char turnoActual = 'X';

        static void Main(string[] args)
        {
            int movimientos = 0;
            bool Ganador = false;

            while (movimientos < 9 && Ganador == false)
            {
                Console.Clear();
                DibujarTablero();

                Console.WriteLine($"Turno del jugador: {turnoActual}");
                Console.WriteLine("Elige una casilla (1-9): ");
                int casilla = int.Parse(Console.ReadLine());

               
                bool movimientoValido = RealizarMovimiento(casilla, turnoActual);

                if (movimientoValido)
                {
                    movimientos++;

                    
                    Ganador = VerificarGanador(turnoActual);

                    if (Ganador)
                    {
                        Console.Clear();
                        DibujarTablero();
                        Console.WriteLine($"¡Felicidades! El jugador '{turnoActual}' ha ganado.");
                    }
                    else
                    {
                        CambiarTurno();
                    }
                }
                else
                {
                    Console.WriteLine("Casilla ocupada o no válida. Presiona ENTER para reintentar...");
                    Console.ReadLine();
                }
            }

            
            if (Ganador == false)
            {
                Console.Clear();
                DibujarTablero();
                Console.WriteLine("¡Empate! No hay más movimientos disponibles.");
            }

            Console.WriteLine("PRESIONA CUALQUIER TECLA PARA FINALIZAR");
            Console.ReadLine();
        }

        
        static void DibujarTablero()
        {
            Console.WriteLine("--- TRIQUI ---");
            Console.WriteLine();
            Console.WriteLine($" {tablero[0, 0]} | {tablero[0, 1]} | {tablero[0, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tablero[1, 0]} | {tablero[1, 1]} | {tablero[1, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tablero[2, 0]} | {tablero[2, 1]} | {tablero[2, 2]} ");
        }

        static void CambiarTurno()
        {
            if (turnoActual == 'X')
            {
                turnoActual = 'O';
            }
            else
            {
                turnoActual = 'X';
            }
        }


        static bool RealizarMovimiento(int casilla, char simbolo)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    if (tablero[i, j] == (char)('0' + casilla))
                    {
                        tablero[i, j] = simbolo;
                        return true;
                    }
                }
            }
            return false;
        }

       
        static bool VerificarGanador(char s)
        {
            // Filas
            if (tablero[0, 0] == s && tablero[0, 1] == s && tablero[0, 2] == s) return true;
            if (tablero[1, 0] == s && tablero[1, 1] == s && tablero[1, 2] == s) return true;
            if (tablero[2, 0] == s && tablero[2, 1] == s && tablero[2, 2] == s) return true;

            // Columnas
            if (tablero[0, 0] == s && tablero[1, 0] == s && tablero[2, 0] == s) return true;
            if (tablero[0, 1] == s && tablero[1, 1] == s && tablero[2, 1] == s) return true;
            if (tablero[0, 2] == s && tablero[1, 2] == s && tablero[2, 2] == s) return true;

            // Diagonales
            if (tablero[0, 0] == s && tablero[1, 1] == s && tablero[2, 2] == s) return true;
            if (tablero[0, 2] == s && tablero[1, 1] == s && tablero[2, 0] == s) return true;

            return false;
        }

        
      
    }
}