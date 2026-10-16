using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;


namespace TALLERCICLOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
             le permitirá al usuario, introducir tantas calificaciones como así desee, 
             en el momento en que seleccione que no desea continuar capturando 
             calificaciones, el algoritmo debe presentar el promedio de las 
            calificaciones capturadas previamente.*/

            /*  

              float acumulador = 0;   //SUMA DE NOTAS
              int contador = 0;
              string continuar = "si";
              float nota = 0;
              float promedio = 0;



              do
              {
                  Console.WriteLine("INGRESE NOTA");
                  nota = float.Parse(Console.ReadLine());

                  Console.WriteLine("DESEA INGRESAR OTRA NOTA (SI/NO)");
                  continuar = Console.ReadLine();

                  acumulador += nota;
                  contador++;

              }
              while (continuar == "SI");

              promedio = acumulador / contador;
              Console.WriteLine("SE INGRESARON: " + contador + " NOTAS Y EL PROMEDIO DE NOTAS ES " + promedio);*/



            //------------------------------------------------------------------------------------------------


            /*2.Se requiere un algoritmo para mostrar por pantalla los divisores de un
                número ingresado por teclado.
                Tener en cuenta que dados dos números enteros a y b, se dice que b es
                divisor de a si se cumple que al efectuar una división entera a/ b el
                residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
                una división de dos números.
                Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
                2, 1 que son los divisores del número 6.*/


            /*int DatoA = 0;
            int DatoB = 0;
            int contador = 0;


            Console.WriteLine("INGRESE NUMERO A");
            DatoA = int.Parse(Console.ReadLine());

            Console.WriteLine("LOS DIVISORES DEL NUMERO SON");

            for (DatoB = 1; DatoB <= DatoA; DatoB++) // empieza en 1, se evalua hasta que sea menor o igual a datoa y se va sumando dato b de a uno
            {
                if (DatoA % DatoB ==0)
                {

                    Console.WriteLine(DatoB);
                    contador++;

                    
                }
            }*/


            //----------------------------------------------------------------------------------------


            /*3.Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.
            Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’*/

            /*int baseA = 0;
            int Exponente = 0;
            double resultado = 0;
            string continuar = "n";
            int acumulador = 0;

            do
            {
                Console.WriteLine("INGRESE NUMERO PARA BASE");
                baseA = int.Parse(Console.ReadLine());

                Console.WriteLine("INGRESE NUMERO PARA EXPONENTE");
                Exponente = int.Parse(Console.ReadLine());

                resultado = Math.Pow(baseA, Exponente);
                acumulador++;

                Console.WriteLine("EL RESULTADO ES" + resultado);

                Console.WriteLine("DESEA CONTIMUAR? (S/N)");
                continuar = Console.ReadLine();


            } while (continuar != "n");

            Console.WriteLine("ADIOS");*/

            //------------------------------------------------------------------------------------------------------------


            /* 4.Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
               kilómetros durante 10 días, para determinar si es apto para la prueba de
               5 kilómetros.Para considerarlo apto debe cumplir las siguientes
               condiciones: 
                    Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
                    Que al menos en una de las pruebas realice un tiempo menor de 15
                    minutos.
                    Que su promedio sea menor o igual a 18 minutos.*/

            /*double tiempo = 0;
            double acumulador = 0;
            double promedio = 0;
            int contador20 = 0;
            int contador15 = 0;

            int contador = 1;

            while (contador <= 10)

               
            {
                Console.WriteLine("INGRESE EL TIEMPO DEL DIA " + contador + ":");
                tiempo = double.Parse(Console.ReadLine());



                acumulador = acumulador + tiempo;
                contador++;

                if (tiempo > 20)
                {
                     contador20++;
                }
                if (tiempo <15)
                {
                    contador15++;
                }
                

            }

            promedio = acumulador / 10;

            Console.WriteLine("EL PROMEDIO DE TIEMPO ES" + promedio);

            if ( contador20 == 0 && contador15 >=1 && promedio <= 18)
            {
                Console.WriteLine("ES APTO PARA LA PRUEBA DE 5 KM");

            }
            else
            {
                Console.WriteLine("NO ES APTO PARA LA PRUEBA DE 5 KM");
            }*/

            /*
             * 
             //--------------------------------------------------------------------------------------------


             5.Se aplicó una encuesta a n personas solicitando su opinión sobre el 
              tema del servicio militar obligatorio para las mujeres. Las opciones de 
              respuesta fueron: a favor, en contra y no responde. Se solicita un 
              algoritmo que calcule qué porcentaje de los encuestados marcó cada 
              una de las respuestas. */

            /*int cantidad = 0;
            string respuesta;
            int contador = 1;
            int contadorAF = 0; //a favor
            int contadorEC = 0; // en contra
            int contadorNR = 0; //no responde

            Console.WriteLine("CUANTAS PERSONAS DESEAN SER ENTREVISTADAS");
            cantidad = int.Parse(Console.ReadLine());

            
            
            for (contador = 1; contador <= cantidad; contador++)
            {
                Console.WriteLine("PERSONA NUMERO " + contador + "INGRESE SU RESPUESTA, \"QUE OPINA DE  EL SERVICIO MILITAR OBLIGATORIO PARA MUJERES, A FAVOR, ENCONTRA O NO RESPONDE");
                respuesta = Console.ReadLine();

                if (respuesta == "a favor")
                {
                    contadorAF++;
                }
                else if (respuesta == "en contra")
                {
                    contadorEC++;
                }
                else if (respuesta == "no responde")
                {
                    contadorNR++;
                }
            }

            double porcentajeAF = (contadorAF * 100) / cantidad;
            double porcentajeEC = (contadorEC * 100) / cantidad;
            double porcentajeNR = (contadorNR * 100) / cantidad;

           Console.WriteLine("PORCENTAJE A FAVOR: " +  porcentajeAF + "%");
           Console.WriteLine("PORCENTAJE EN CONTRA: " + porcentajeEC + "%");
           Console.WriteLine("PORCENTAJE NO RESPONDE: " + porcentajeNR + "%");*/

            //--------------------------------------------------------------------------------------

            /*6.Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos
              de esos números son positivos, cuántos negativos, cuántos son neutros
              (0); además que imprima por pantalla la sumatoria de los números
              positivos y la de los negativos. */

            /*int numero = 0;
            int contadorP = 0; //positivos
            int contadorN = 0; //negativo
            int contadorC = 0; //contador 0
            int contador = 1;
            int acumulador = 0; 


            for (contador=1;contador <=40; contador++)
            {
                Console.WriteLine("INGRESE EL NUMERO " + contador);
                numero = int.Parse(Console.ReadLine());


                if ( numero > 0 )
                {
                    contadorP++;
                }
                else if (numero < 0)
                {
                    contadorN++;
                }
                else
                {
                    contadorC++;
                }
                acumulador = acumulador + numero;
            }

            Console.WriteLine("HAY " + contadorP + " NUMEROS POSITIVOS");
            Console.WriteLine("HAY " + contadorN + " NUMEROS NEGATIVOS");
            Console.WriteLine("HAY " + contadorC + " NUMEROS NEUTROS");
            Console.WriteLine("SUMA DE TODOS LOS NUMEROS:  " + acumulador);*/




            //--------------------------------------------------------------------------------
            /*
                        7.Una persona desea realizar un muestreo con 70 personas para
                        determinar el promedio de peso de los niños, jóvenes, adultos y viejos
                        que existen en su zona y cuántos son de cada una de las categorías. 
                        Las categorías están dadas por la siguiente tabla: */

            /*int edad;
            double peso;

            int contadorN = 0; //niños
            int contadorJ = 0;  //jovenes
            int contadorA = 0;   //adultos
            int contadorV = 0;    //viejos

            double acumuladorN = 0;
            double acumuladorJ = 0;
            double acumuladorA = 0;
            double acumuladorV = 0;

            for (int contador = 1; contador <= 70; contador++)
            {
                Console.Write("Ingrese la edad de la persona " + contador);
                edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el peso de la persona " + contador);
                peso = double.Parse(Console.ReadLine());

                if (edad >= 0 && edad <= 13)
                {
                    contadorN++;
                    acumuladorN = acumuladorN + peso;
                }
                else if (edad >= 14 && edad <= 30)
                {
                    contadorJ++;
                    acumuladorJ = acumuladorJ + peso;
                }
                else if (edad >= 31 && edad <= 60)
                {
                    contadorA++;
                    acumuladorA = acumuladorA + peso;
                }
                else if (edad >= 61)
                {
                    contadorV++;
                    acumuladorV = acumuladorV + peso;
                }
            }

            Console.WriteLine("\nRESULTADOS");

            Console.WriteLine("Niños: " + contadorN);
            Console.WriteLine("Jóvenes: " + contadorJ);
            Console.WriteLine("Adultos: " + contadorA);
            Console.WriteLine("Viejos: " + contadorV);

            if (contadorN > 0)
                Console.WriteLine("Promedio de peso de niños: " + acumuladorN / contadorN);

            if (contadorJ > 0)
                Console.WriteLine("Promedio de peso de jóvenes: " + acumuladorJ / contadorJ);

            if (contadorA > 0)
                Console.WriteLine("Promedio de peso de adultos: " + acumuladorA / contadorA);

            if (contadorV > 0)
                Console.WriteLine("Promedio de peso de viejos: " + acumuladorV / contadorV);*/


            //---------------------------------------------------------------------------------



           /* 8.El Departamento de Transito de Antioquia.desea saber de los n autos
que entran a la ciudad de Medellín, cuántos autos entran con
calcomanía de un determinado color. Conociendo el último dígito de la
placa de cada automóvil se puede determinar el color de la calcomanía,
para determinar lo anterior utilice la siguiente tabla:
            1-2 AMARILLO, 3-4 ROSA,5-6 ROJA 7-8 VERDE, 9-0 AZUL*/


            int cantidad = 0;
            int placa= 0;
            int contador = 1;
            int Camarillo = 0;
            int Crosa = 0;
            int Crojo = 0;
            int Cverde = 0;
            int Cazul = 0;

            Console.Write("Ingrese la cantidad de autos: ");
            cantidad = int.Parse(Console.ReadLine());

            for (contador = 1; contador <= cantidad; contador++)
            {
                Console.Write("Ingrese el último dígito de la placa: ");
                placa = int.Parse(Console.ReadLine());

                if (placa == 1 || placa == 2)
                {
                    Camarillo++;
                }
                else if (placa == 3 || placa == 4)
                {
                    Crosa++;
                }
                else if (placa == 5 || placa == 6)
                {
                    Crojo++;
                }
                else if (placa == 7 || placa == 8)
                {
                    Cverde++;
                }
                else if (placa == 9 || placa == 0)
                {
                    Cazul++;
                }
            }

            Console.WriteLine("RESULTADOS");
            Console.WriteLine("Autos con calcomanía amarilla: " + Camarillo);
            Console.WriteLine("Autos con calcomanía rosa: " + Crosa);
            Console.WriteLine("Autos con calcomanía roja: " + Crojo);
            Console.WriteLine("Autos con calcomanía verde: " + Cverde);
            Console.WriteLine("Autos con calcomanía azul: " + Cazul);

        }
    }
}

