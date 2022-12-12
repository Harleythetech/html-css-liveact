using System;

namespace ET_ICT201A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Word:");
            String word = Console.ReadLine();
            char endw = word[word.Length - 1];
            for(int i = 2; i <=word.Length; i++)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(endw);


        }
    }
}
