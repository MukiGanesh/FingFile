using System;

namespace FindFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nEnter FileName: ");
            var fileName = Console.ReadLine();
            Console.WriteLine($"\nFilePath - { fileName}");
            Console.Write("\n Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
