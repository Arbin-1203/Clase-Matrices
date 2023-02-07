using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        public static float num1, num2;
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]; // variable locales
            float sumatoria = 0; // variable locales
            string opcion = "s";
            int[,] matrix2 = new[,] { { 1, 20, 2 }, { 50, 4, 6 } };
            Console.WriteLine("************* Matrix 1 *************");
            for (int f = 0; f < 3; f++) // filas
            {
                for (int c = 0; c < 3; c++) // columnas
                {
                    Console.Write(matrix[f, c] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("************* Matrix 2 *************");
            for (int f = 0; f < 2; f++) // filas
            {
                for (int c = 0; c < 3; c++) // columnas
                {
                    Console.Write(matrix2[f, c] + " ");
                    sumatoria += matrix2[f, c];

                }
                Console.WriteLine();
            }
            Console.WriteLine("Sumatoria = {0}", sumatoria);
            Console.WriteLine("Promedio {0}", sumatoria /= matrix2.Length);


            int op = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1.Sumar");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2.Multiplicar");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3.Restar");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("4.División");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Digite una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        SolicitaDatos();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Total suma {0}", num1 + num2);
                        break;
                    case 2:
                        SolicitaDatos();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total multiplicacion {0}", num1 * num2);
                        break;
                    case 3:
                        SolicitaDatos();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Total resta {0}", num1 - num2);
                        break;
                    case 4:
                        SolicitaDatos();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total división {0}", num1 / num2);
                        break;

                    default:
                        break;


                }
            } while (op != 4);


            while (opcion != "n")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Digite el monto para prestamo");
                float monto = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite su salario");
                float salario = float.Parse(Console.ReadLine());

                if ((monto >= 100000) && (salario < 100000))
                {
                    Console.WriteLine("No se le puede prestar");

                }
                else if ((monto >= 100000) && (salario >= 100000))
                {
                    Console.WriteLine("Se le presta a 6 meses");
                }
                else if ((monto < 100000) && (salario >= 100000))
                {
                    Console.WriteLine("Se le presta a 24 meses");
                }
                Console.WriteLine("Desea continuar");
                opcion = Console.ReadLine();

            }

            Console.ReadLine();
        }

        private static void SolicitaDatos()
        {
            Console.WriteLine("Digite num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el num2");
            num2 = int.Parse(Console.ReadLine());
        }
    }
}
