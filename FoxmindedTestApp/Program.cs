using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FoxmindedTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath;

            if (args.Length > 0)
            {
                filePath = args[0];
            }
            else
            {
                Console.WriteLine("Enter file path: ");
                filePath = Console.ReadLine();
            }

            FileAnalizeResult result = Helper.AnalizeFile(filePath);

            Console.WriteLine("Max sum: " + result.MaxSum);
            Console.WriteLine("Line number: " + result.MaxLineNumber);
            Console.WriteLine("Broken lines:");
            foreach (var line in result.BrokenLines)
                Console.WriteLine(line);
        }   
    }
}
