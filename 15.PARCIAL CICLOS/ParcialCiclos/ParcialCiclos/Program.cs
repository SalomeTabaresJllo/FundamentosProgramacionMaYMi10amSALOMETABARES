using System;


//RESUMEN: 12 VEHICULOS EN TOTAL POR TURNO

//MENU : 1 MOTO, 2. CARRO, 3. CAMION 
//CANTIDAD DE HORA O FRACCION QUE ESTUVO ESTACIONADO
//VALOR A PAGAR POR CADA VEHICULO = HORAS ESTACIONADAS * TARIFA DE LA CATEGORIA
//MOTO (1) = TARIFA BASE 3.000 X HORA , 4+ HORAS SE LE APLICA 10% DE DESCUENTO SOBRE EL VALOR TOTAL DEL COBRO
//AUTOMOVIL(2) TARIFA BASE 5.000 X HORA, 3+ HORAS PAGA TARIFA FIJA DE 20 MIL SIN IMPORTAR HORAS ADICINALES.
//CAMION(3) = TARIFA BASE DE 10.000 X HORA , 5+ HORAS SE LE COBRA RECARGO ADICIONAL DE 15.000 POR SOBRECARGA DE ESPACIO.

/*Por cada vehículo, calcular y mostrar en pantalla el valor exacto a pagar.
Acumular el dinero total recaudado durante todo el turno por los 12 vehículos.
Contar cuántos vehículos de cada tipo (motos, automóviles y camiones) atendió el parqueadero.
Al finalizar el ciclo, mostrar en pantalla el reporte global: el total de dinero recaudado en la caja y cuántos vehículos hubo de cada categoría.*/


namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Motos = 0;
            int Autos = 0;
            int Camiones = 0;
            int OpcionVehiculo = 0;


            // TOTAL DINERO
            double totalRecaudado = 0;

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"--------------------------------------------------------");
                Console.WriteLine($"----------- REGISTRO DEL VEHÍCULO {i} DE {12} ----------");

                do
                {
        
                Console.WriteLine("--------- PARQUEADERO LA PAZ (TURNO DE LA TARDE) ---------");
                Console.WriteLine("--------------------------MENU --------------------");
                Console.WriteLine("SELECCIONE LA OPCION SEGUN EL TIPO DE VEHICULO INGRESADO:");
                Console.WriteLine("1. MOTO");
                Console.WriteLine("2. AUTOMOVIL");
                Console.WriteLine("3. CAMION");
                Console.Write("INGRESE LA OPCION DESEADA: ");
                

                OpcionVehiculo = int.Parse(Console.ReadLine());

                    if (OpcionVehiculo < 1 || OpcionVehiculo > 3)
                    {
                        Console.WriteLine("INGRESE SOLO NUMEROS DENTRO DEL MENU");
                    }

                } while (OpcionVehiculo < 1 || OpcionVehiculo > 3);



                //HORAS
                Console.Write("INGRESE LA CANTIDAD DE HORAS QUE ESTUVO EN EL PARQUEADERO: ");
                int horas = int.Parse(Console.ReadLine());

                
                double valorPagar = 0;

                if (OpcionVehiculo == 1) 
                {
                    Motos++;
                    double tarifaBase = horas * 3000; 

                    if (horas > 4)  //DESCUENTO 10% POR MAS DE 4 HORAS
                    {
                        double descuento = tarifaBase * 0.10; 
                        valorPagar = tarifaBase - descuento;

                        Console.WriteLine($"TARIFA BASE: $ {tarifaBase}");
                        Console.WriteLine($"DESCUENTO APLICADO POR SER MAS DE 4 HORAS (10%): -$ {descuento}");
                        
                    }
                    else
                    {
                        valorPagar = tarifaBase;
                    }
                }
                else if (OpcionVehiculo == 2) 
                {
                    Autos++;

                    if (horas > 3)
                    {
                        valorPagar = 20000; //TARIFA FIJA POR SER MAS DE 3 HORAS
                    }
                    else
                    {
                        valorPagar = horas * 5000;
                    }
                }
                else if (OpcionVehiculo == 3) 
                {
                    Camiones++;
                    double tarifaBase = horas * 10000;

                    if (horas > 5)
                    {
                        valorPagar = tarifaBase + 15000; 
                    }
                    else
                    {
                        valorPagar = tarifaBase;
                    }
                }

               
                Console.WriteLine($"Total a pagar: ${valorPagar}");
                totalRecaudado += valorPagar;

            }
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("             REPORTE DEL TURNO"                );
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"TOTAL RECAUDADO : ${totalRecaudado}");
            Console.WriteLine($"MOTOS ATENTIDAS EN EL TURNO: {Motos}");
            Console.WriteLine($"CARROS ATENTIDAS EN EL TURNO: {Autos}");
            Console.WriteLine($"CAMIONES ATENDIDOS EN EL TURNO: {Camiones}");
            Console.WriteLine($"TOTAL DE VEHICULOS ATENTIDOS EN EL TURNO: {Motos + Autos + Camiones}");
            Console.WriteLine("---------------------------------------------");
        }
    
    }
}