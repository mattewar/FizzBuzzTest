using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Class1();
            var conditions = new List<ModPair>();
            conditions.Add(new ModPair() { Word = "Fizz", Number = 3 });
            conditions.Add(new ModPair() { Word = "Buzz", Number = 5 });
            for (int i = 0; i < int.MaxValue; i++)
            {
                var list = printer.Print(i, conditions);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
