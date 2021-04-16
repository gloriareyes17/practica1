using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla = 0;
            int resultado = 0;
            do
            {
                Console.WriteLine("ingresa la tabla de multiplicar que desea o 0 para salir: ");
                tabla = int.Parse(Console.ReadLine());
                for (int j = 0; j <= 10; j++)
                {
                    resultado = j * tabla;
                    Console.WriteLine("La multiplicacion de { 0} por { 1} es { 2}", tabla, j, resultado);
            }
            } while (tabla != 0);
            Console.ReadKey();
        }
}
}