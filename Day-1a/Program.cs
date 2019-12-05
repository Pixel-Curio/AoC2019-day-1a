using System;
using System.IO;
using System.Linq;

namespace Day1a
{
    class Program
    {
        private const string InputPath = @"day1a-input.txt";

        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines(InputPath);
            Console.WriteLine(inputs.Select(int.Parse).Select(x => x/3-2).Sum());
            Console.ReadKey();
        }
    }
}
