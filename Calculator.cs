using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CalculatorConsoleApp
{
    class CalculatorProgram
    {
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static double Pembagian(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
        Home:
            Console.Clear();

            Console.Title = "CalculatorConsoleApp";

            int Chose;

            Console.WriteLine("=== WELCOME TO CALCULATOR CONSOLE APP ===\n");
            Console.WriteLine("1. (+) = Penambahan");
            Console.WriteLine("2. (-) = Pengurangan");
            Console.WriteLine("3. (*) = Perkalian");
            Console.WriteLine("4. (/) = Pembagian\n");

            Console.Write("Chose Number (1 - 4) = ");
            Chose = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Chose > 4 || Chose < 1)
            {

                Console.WriteLine("Menu Not Found!!");
                Console.ReadKey();
                goto Home;

            }
            else
            {
                Console.Write("Input Value a = ");
                int a = int.Parse(Console.ReadLine()); 

                Console.Write("Input Value b = ");
                int b = int.Parse(Console.ReadLine()); 

                Console.WriteLine(); 

                if (Chose == 1)
                {
                    Console.WriteLine("Result for Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
                }
                else if (Chose == 2)
                {
                    Console.WriteLine("Result for Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
                }
                else if (Chose == 3)
                {
                    Console.WriteLine("Result for Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
                }
                else if (Chose == 4)
                {
                    Console.WriteLine("Result for Pembagian: {0} /  {1} = {2}", a, b, Pembagian(a, b));
                }
            }

            Console.WriteLine("\npress any key to exit...");
            Console.ReadKey();
        }
    }
}