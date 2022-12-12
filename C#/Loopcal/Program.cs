using System;

namespace Loopcal
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Addition \n2. Subtaction \n3. Multiplication \n4. Division \n5. End");
                Console.Write("Choose:");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.Write("First Number:");
                    int inp1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second Number:");
                    int inp2 = Convert.ToInt32(Console.ReadLine());
                    int sum = inp1 + inp2;
                    Console.WriteLine("The answer is: " + sum);
                }
                else if (input == 2)
                {
                    Console.Write("First Number:");
                    int inp1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second Number:");
                    int inp2 = Convert.ToInt32(Console.ReadLine());
                    int sum = inp1 - inp2;
                    Console.WriteLine("The answer is: " + sum);
                }
                else if (input == 3)
                {
                    Console.Write("First Number:");
                    int inp1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second Number:");
                    int inp2 = Convert.ToInt32(Console.ReadLine());
                    int sum = inp1 * inp2;
                    Console.WriteLine("The answer is: " + sum);
                }
                else if (input == 4)
                {
                    Console.Write("First Number:");
                    int inp1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second Number:");
                    int inp2 = Convert.ToInt32(Console.ReadLine());
                    int sum = inp1 / inp2;
                    Console.WriteLine("The answer is: " + sum);
                }
                else
                {
                    Console.Write("First Number:");
                    int inp1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second Number:");
                    int inp2 = Convert.ToInt32(Console.ReadLine());
                }
            } while (input != 5);

            }
            }
            
    }
    
