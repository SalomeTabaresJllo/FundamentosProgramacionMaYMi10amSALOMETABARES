using System;

namespace _11.EJERCICIOSCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo que pida un grupo de usuarios nombre, numero de cuenta y saldo, para cada uno hacer lo siguiente: 
            //1. si el saldo >= 3.000.000 decir "es apto pra credito junto a nombre, uenta y saldo
            //2. si el saldo es menor, " no es apto para credito" junto nombre, cuenta, saldo.
            // el algoritmo debe permitir preguntar informacion de usuarios hasta que le indique que ya no se desea preguntar mas 
            //algortimo donde muestre a cuantos usuarios se les pregunto y mostrar promedio de los saldos.

            /*string nombreUsuario;
            string numeroCuenta;
            int saldo;
            string continuar = "si";
            int contadorUsuarios = 0;
            double acumuladorSaldos = 0;
            

            while (continuar == "si")
            {
                Console.WriteLine("INGRESE SU NOMBRE");
                nombreUsuario = Console.ReadLine();

                Console.WriteLine("INGRESE SU NUMERO DE CUENTA");
                numeroCuenta = Console.ReadLine();

                Console.WriteLine("INGRESE SU SALDO");
                saldo = int.Parse(Console.ReadLine());


                if (saldo >= 3000000)
                {
                    Console.WriteLine("EL USUARIO " + nombreUsuario + " CON NUMERO DE CUENTA " + numeroCuenta + "Y SALDO " + saldo + " ES APTO PARA CREDITO");
                }
                else
                {
                    Console.WriteLine("EL USUARIO " + nombreUsuario + " CON NUMERO DE CUENTA " + numeroCuenta + "Y SALDO " + saldo + " NO ES APTO PARA CREDITO");
                }

                contadorUsuarios++;
                acumuladorSaldos += saldo;

                Console.WriteLine("DESEA CONTINUAR INGRESANDO UN USUARIO? SI/NO");
                continuar = Console.ReadLine();

            }
            double promedio = acumuladorSaldos / contadorUsuarios;
            Console.WriteLine("EL PROMEDIO DE LOS SALDOS ES " + promedio + " NUMERO DE USUARIOS REGISTRADOS " + contadorUsuarios);
            */






            //ALGORITMO DONDE SE LE PREGUNTE AL USUARIO LA CONTRASEÑA Y EL USUARIO INTENTE ADIVINARLA Y CUANDO LO LOGRE DICE
            //CUANTOS INTENTOS FUERON

            string contraseña;
            string confirmacion;
            int contadorIntentos = 0;


            Console.WriteLine("INGRESE CONTRASEÑA");
            contraseña = Console.ReadLine();
            Console.WriteLine("ADIVINE LA CONTRASEÑA CONTRASEÑA");
            confirmacion = Console.ReadLine();

            while (contraseña != confirmacion)
            {
                contadorIntentos++;

                Console.WriteLine("CONTRASEÑA INCORRECTA");
                Console.WriteLine("VUELVA A INTENTARLO");
                confirmacion = Console.ReadLine();


            }

            Console.WriteLine("CONTRASEÑA CORRECTA");
            Console.WriteLine("CANTIDAD DE INTENTOS REALIZADOS:" + contadorIntentos);



        }
    }
}
