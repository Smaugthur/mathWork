using System;
using MATHMETHODS;
using INPUT;

namespace mathHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            do{
                Console.Clear();
                Console.WriteLine("What you want to do? Factorization(1) mcm(2) MCD(3)");
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Insert your value for FACTORIZATION: ");
                        int input = int.Parse(Console.ReadLine());
                        basics.factorization(input);
                        break;
                    case 2:
                        Console.WriteLine("Insert your value for mcm: ");
                        int[] input2 = InputMethods.inputArray();
                        basics.mcm(input2);
                        break;
                    case 3:
                        Console.WriteLine("Insert your value to MCD: ");
                        int[] input3 = InputMethods.inputArray();
                        int hola = input3[0];
                        int adios= input3[1];
                        basics.mcm(input3);
                        Console.WriteLine(basics.gcd(hola, adios));
                        break;
                }
                Console.WriteLine("\nPress <Enter to continue>"); 
            }while(Console.ReadKey().Key == ConsoleKey.Enter);

        }
    }
}
