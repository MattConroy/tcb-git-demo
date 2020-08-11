using System;

namespace GitDemo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (var arg in args)
                Console.WriteLine(arg);

            Console.WriteLine("Waiting for input...");
            Console.ReadKey();
        }
    }
}
