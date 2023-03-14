using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hacer un programa para ingresar los valores de los pesos de distintas
            // encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            // ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
            // pueden transportar hasta 200 kilos en total.
            // Por ejemplo:
            // 10, 20, 140,   70, 100,    40, 10, 50, 80,    90, 30, 40,    50,     -10.
            // Camión 1.    Camión 2        Camión 3           Camión 4   Camión 5
            // Se pide determinar e informar:
            // a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
            // Camión 2: 170kg, etc.).
            // b. El número de camión que transporta mayor cantidad de encomiendas
            // (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
            // c. La cantidad de camiones que se terminaron cargando.

            float pesoCamion, peso;
            int camion = 0, numEncomiendas, maximoEncomiendas = 0 , maximoCamion = 0;


            Console.WriteLine("INGRESE EL PESO DEL CAMIÓN: ");
            peso = int.Parse(Console.ReadLine());

            while(peso > 0){
                camion++;

                pesoCamion = 0;
                numEncomiendas = 0;

                while(peso > 0 && pesoCamion + peso <= 200){
                    pesoCamion += peso;

                    numEncomiendas++;

                    Console.WriteLine("INGRESE EL PESO DE LA ENCOMIENDA: ");
                    peso = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("CAMIÓN "+ camion + ": "+ pesoCamion +"kg");

                // CALCULANDO EL CAMION CON MAYOR CANTIDAD DE ENCOMIENDAS
                if(numEncomiendas > maximoEncomiendas){
                    maximoEncomiendas = numEncomiendas;
                    maximoCamion = camion;
                }

            }

            Console.WriteLine("EL CAMION QUE TRANSPORTA MAS ESCOMIENDAS ES EL CAMIÓN : "+ maximoCamion + " CON " + maximoEncomiendas+ " ENCOMIENDAS");
            Console.WriteLine("SE CARGARON UN TOTAL DE " + camion + " CAMIONES");
        }
    }
}
