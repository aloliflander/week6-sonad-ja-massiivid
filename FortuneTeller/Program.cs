﻿using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme
            string[] predictions = new string[4] { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };
            Random rnd = new Random();
            int usernumber = rnd.Next(0, predictions.Length);
            Console.WriteLine($"Tomorrow you will {predictions[usernumber]}.");
        }
    }
}
