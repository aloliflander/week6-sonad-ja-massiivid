using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Dont Panic" nulliga - 0
            //programm asendab kõik 'a' tähed samaslauses 4-ga

            string dontPanic = "Dont Panic";
            dontPanic = dontPanic.Replace('o', '0');
            dontPanic = dontPanic.Replace('a', '4');
            Console.WriteLine(dontPanic);
        }
    }
}
