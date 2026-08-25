using System;
using System.Runtime.InteropServices;

namespace _8.PARCIALCONDICIONALES
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double precioBase1;
            double iva1;
            double ValorIva1;
            double precioFinal1;

            double precioBase2;
            double iva2;
            double ValorIva2;
            double precioFinal2;

            double precioBase3;
            double iva3;
            double ValorIva3;
            double precioFinal3;

            double precioBase4;
            double iva4;
            double ValorIva4;
            double precioFinal4;

            double precioBase5;
            double iva5;
            double ValorIva5;
            double precioFinal5;

            double precioBase6;
            double iva6;
            double ValorIva6;
            double precioFinal6;



            string respuesta;
            Console.WriteLine("BIENVENIDO A LA PIZZERIA OLAFO,SELECCIONE CON 1 O 2 LA PIZZA QUE DESEA");
            Console.WriteLine("1-PIZZA VEGETARIANA");
            Console.WriteLine("2-PIZZA NO VEGETARIANA");
            respuesta = Console.ReadLine();

            string ingrediente1;
            string ingrediente2;
            string ingrediente3;

            if (respuesta == "1")
            {
                Console.WriteLine("INGRESE 3 INGREDIENTES, SELECCIONE EL INGREDIENTE (ESCRIBALO) QUE DESEE");

                Console.WriteLine("1.PIMIENTO");
                Console.WriteLine("2.TOFU");
                Console.WriteLine("3. CHAMPIÑONES");
                Console.WriteLine("4. TOMATE");
                Console.WriteLine("5. LECHUGA");

                Console.WriteLine("ELIGA PRIMER INGREDIENTE");
                ingrediente1 = Console.ReadLine();
                Console.WriteLine("ELIGA SEGUNDO INGREDIENTE INGREDIENTE");
                ingrediente2 = Console.ReadLine();
                Console.WriteLine("ELIGA TERCER INGREDIENTE");
                ingrediente3 = Console.ReadLine();

                if (ingrediente1 == ingrediente2 && ingrediente2 == ingrediente3 && ingrediente1 == ingrediente3)
                {
                    Console.WriteLine("DEBE INGRESAR INGREDIENTES DIFERENTES");
                }
                else
                {


                    if (((ingrediente1 == "PIMIENTO" && ingrediente2 == "CHAMPIÑONES" && ingrediente3 == "LECHUGA") ||
                       (ingrediente1 == "PIMIENTO" && ingrediente2 == "LECHUGA" && ingrediente3 == "CHAMPIÑONES") ||
                       (ingrediente1 == "CHAMPIÑONES" && ingrediente2 == "PIMIENTO" && ingrediente3 == "LECHUGA") ||
                       (ingrediente1 == "CHAMPIÑONES" && ingrediente2 == "LECHUGA" && ingrediente3 == "PIMIENTO") ||
                       (ingrediente1 == "LECHUGA" && ingrediente2 == "PIMIENTO" && ingrediente3 == "CHAMPIÑONES") ||
                       (ingrediente1 == "LECHUGA" && ingrediente2 == "CHAMPIÑONES" && ingrediente3 == "PIMIENTO")))
                    {

                        precioBase1 = 20000;
                        iva1 = 19;
                        ValorIva1 = precioBase1 * (iva1 / 100);
                        precioFinal1 = precioBase1 + ValorIva1;

                        Console.WriteLine("PRECIO BASE:" + precioBase1);
                        Console.WriteLine("IVA " + (ValorIva1) + "%");
                        Console.WriteLine();
                        Console.WriteLine("PRECIO FINAL:");
                        Console.WriteLine(precioFinal1);


                    }
                    else
                    {
                        if (((ingrediente1 == "TOFU" && ingrediente2 == "CHAMPIÑONES" && ingrediente3 == "LECHUGA") ||
                           (ingrediente1 == "TOFU" && ingrediente2 == "LECHUGA" && ingrediente3 == "CHAMPIÑONES") ||
                           (ingrediente1 == "CHAMPIÑONES" && ingrediente2 == "TOFU" && ingrediente3 == "LECHUGA") ||
                           (ingrediente1 == "CHAMPIÑONES" && ingrediente2 == "LECHUGA" && ingrediente3 == "TOFU") ||
                           (ingrediente1 == "LECHUGA" && ingrediente2 == "TOFU" && ingrediente3 == "CHAMPIÑONES") ||
                           (ingrediente1 == "LECHUGA" && ingrediente2 == "CHAMPIÑONES" && ingrediente3 == "TOFU")))
                        {
                            precioBase2 = 30000;
                            iva2 = 15;
                            ValorIva2 = precioBase2 * (iva2 / 100);
                            precioFinal2 = precioBase2 + ValorIva2;

                            Console.WriteLine("PRECIO BASE:" + precioBase2);
                            Console.WriteLine("IVA " + (ValorIva2) + "%");
                            Console.WriteLine();
                            Console.WriteLine("PRECIO FINAL:");
                            Console.WriteLine(precioFinal2);
                        }
                        else
                        {
                            precioBase3 = 25000;
                            iva3 = 10;
                            ValorIva3 = precioBase3 * (iva3 / 100);
                            precioFinal3 = precioBase3 + ValorIva3;

                            Console.WriteLine("PRECIO BASE:" + precioBase3);
                            Console.WriteLine("IVA " + (ValorIva3) + "%");
                            Console.WriteLine();
                            Console.WriteLine("PRECIO FINAL:");
                            Console.WriteLine(precioFinal3);
                        }

                    }







                    {

                    }


                }



            }
            else
            {
                if (respuesta == "2")
                {

                    Console.WriteLine("INGRESE 2 INGREDIENTES, SELECCIONE EL INGREDIENTE (ESCRIBALO) QUE DESEE");

                    Console.WriteLine("1.RES");
                    Console.WriteLine("2.CHORIZO");
                    Console.WriteLine("3.POLLO");
                    Console.WriteLine("4. CERDO");
                    Console.WriteLine("5. TOCINETA");

                    Console.WriteLine("ELIGA PRIMER INGREDIENTE");
                    ingrediente1 = Console.ReadLine();
                    Console.WriteLine("ELIGA SEGUNDO INGREDIENTE INGREDIENTE");
                    ingrediente2 = Console.ReadLine();

                    if ((ingrediente1 == "POLLO" && ingrediente2 == "RES") ||
                (ingrediente1 == "RES" && ingrediente2 == "POLLO"))
                    {

                        precioBase4 = 10000;
                        iva4 = 19;
                        ValorIva4 = precioBase4 * (iva4 / 100);
                        precioFinal4 = precioBase4 + ValorIva4;

                        Console.WriteLine("PRECIO BASE:" + precioBase4);
                        Console.WriteLine("IVA " + (ValorIva4) + "%");
                        Console.WriteLine();
                        Console.WriteLine("PRECIO FINAL:");
                        Console.WriteLine(precioFinal4);
                    }
                    else
                    {
                        if ((ingrediente1 == "TOCINETA" && ingrediente2 == "RES") ||
                (ingrediente1 == "RES" && ingrediente2 == "TOCINETA"))
                        {

                            precioBase5 = 10000;
                            iva5 = 19;
                            ValorIva5 = precioBase5 * (iva5 / 100);
                            precioFinal5 = precioBase5 + ValorIva5;

                            Console.WriteLine("PRECIO BASE:" + precioBase5);
                            Console.WriteLine("IVA " + (ValorIva5) + "%");
                            Console.WriteLine();
                            Console.WriteLine("PRECIO FINAL:");
                            Console.WriteLine(precioFinal5);
                        }
                        else
                        {
                            if ((ingrediente1 == "TOCINETA" && ingrediente2 == "CHORIZO") ||
               (ingrediente1 == "CHORIZO" && ingrediente2 == "TOCINETA"))
                            {

                                precioBase6 = 10000;
                                iva6 = 19;
                                ValorIva6 = precioBase6 * (iva6 / 100);
                                precioFinal6 = precioBase6 + ValorIva6;

                                Console.WriteLine("PRECIO BASE:" + precioBase6);
                                Console.WriteLine("IVA " + (ValorIva6) + "%");
                                Console.WriteLine();
                                Console.WriteLine("PRECIO FINAL:");
                                Console.WriteLine(precioFinal6);
                            }
                                else
                                    {
                                        precioBase3 = 25000;
                                        iva3 = 10;
                                        ValorIva3 = precioBase3 * (iva3 / 100);
                                        precioFinal3 = precioBase3 + ValorIva3;

                                        Console.WriteLine("PRECIO BASE:" + precioBase3);
                                        Console.WriteLine("IVA " + (ValorIva3) + "%");
                                        Console.WriteLine();
                                        Console.WriteLine("PRECIO FINAL:");
                                        Console.WriteLine(precioFinal3);
                                    }

                        }
                }

            }

        }
    }
}
