using System;

namespace Tarea04_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVentas = 0;
            double total = 0;

            Console.Write("Introduce cantidad de ventas: ");
            numVentas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < numVentas; i++)
            {
                Console.Write("Introduce precio de venta {0}: ", i + 1);
                total= total + Convert.ToDouble(Console.ReadLine() );
            }

            Console.WriteLine();
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("Precio total de ventas: {0} euros.", total);
            Console.ReadKey();
        }
    }
}
