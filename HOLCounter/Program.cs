﻿using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h''o''l' tähte on lauses"Hello World!"
            string HelloWorld = "Hello World".ToLower();
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;
            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if(HelloWorld[i] == 'h')
                {
                    hCounter++;
                }
                else if(HelloWorld[i] == 'o')
                {
                    oCounter++;
                }
                else if(HelloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }
            if(hCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World on {hCounter} 'h' täht.");
            }
            if(oCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World on {oCounter} 'o' täht.");
            }
            if(lCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World on {lCounter} 'l' täht.");
            }
        }
    }
}
