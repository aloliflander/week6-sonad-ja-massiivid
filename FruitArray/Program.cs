using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] fruit = new string[5] { "an apple", "a banana", "a lemon", "an oringe", "some grapes" };
            Console.WriteLine("Enter a number from 0 to 4:");
            //int usernumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Today you will have {fruit[usernumber]}");
            Random rnd = new Random();
            int usernumber = rnd.Next(0, fruit.Length);
            Console.WriteLine($"Today you will have {fruit [usernumber]}");
        }
    }
}
