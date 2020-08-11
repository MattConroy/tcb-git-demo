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
        }
    }
}
