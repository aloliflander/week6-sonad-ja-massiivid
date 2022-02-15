using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string hellow = "Hello World!";
            hellow = hellow.Replace('o', '*');
            hellow = hellow.Replace('!', '1');
            Console.WriteLine(hellow);
        }
    }
}
