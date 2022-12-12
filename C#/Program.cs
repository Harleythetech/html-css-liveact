using System;

namespace project0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculator ===");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Modulo");

            Console.Write("Choose A Number:");
            int selector = Convert.ToInt32(Console.ReadLine());
            Console.Write("First Number:");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number:");
            int secondnum = Convert.ToInt32(Console.ReadLine());

            switch (selector)
            {
                case 1:
                    int ans = firstnum + secondnum;
                    Console.WriteLine("The Answer is: " + ans);
                    break;

                case 2:
                    int ans2= firstnum - secondnum;
                    Console.WriteLine("The Answer is: " + ans2);
                    break;

                case 3:
                    int ans3= firstnum * secondnum;
                    Console.WriteLine("The Answer is: " + ans3);
                    break;

                case 4:
                    int ans4 = firstnum / secondnum;
                    Console.WriteLine("The Answer is: " + ans4);
                    break;
                
                case 5:
                    int ans5 = firstnum % secondnum;
                    Console.WriteLine("The Answer is: " + ans5);
                    break;

            }
        }
    }
}
