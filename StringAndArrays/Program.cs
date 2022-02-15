using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi");
            string firstName = Console.ReadLine();
            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimi on {firstNameLength} sümbolit.");
        }
    }
}
