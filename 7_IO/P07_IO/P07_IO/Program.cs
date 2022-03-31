using P07_IO.Domain.Services;
using System;

namespace P07_IO
{
    class Program
    {
        static void Main(string[] args)
        {

            var reader = new TextFileReader();
            Console.Write("Type the targer file path: ");
            Console.WriteLine(reader.ReadFile(Console.ReadLine()).Message); 
        }
    }
}
