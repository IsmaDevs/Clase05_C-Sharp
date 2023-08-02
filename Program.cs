using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05_CSharp
{
    class Program
    {
        static void VectorBi()
        {
            // matrices bidiomensionales 

            int[,] num = new int[3, 3];

            num[0, 0] = 10;

            int[,] num2 = { {2, 5, 7},
                            {4, 6, 8},
                            {1, 3, 9} };

            int filas = num2.GetLength(0);

            Console.WriteLine("MATRIZ:");


            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < num2.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.Write(num2[i, j] + " ");
                }
            }

        }


        static void Main(string[] args)
        {
            VectorBi();

            Console.ReadKey();

        }
    }
}