using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees-ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendes on pikem, kas ees-või perekonnanimi
            Console.WriteLine("Sisesta eesnimi.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            string lastName = Console.ReadLine();
            int firstNameLenth = firstName.Length;
            int lastNameLength = lastName.Length;
            if(firstNameLenth > lastNameLength)
            {
                Console.WriteLine($"Sinu eesnimes on {firstNameLenth} sümbolit. See on pikem kui sinu perekonna nimi, kus on {lastNameLength} sümbolit.");
            }
            else if(firstNameLenth < lastNameLength)
            {
                Console.WriteLine($"Sinu eesnimes on {firstNameLenth} sümbolit. See on lühem kui sinu perekonnanimi, kus on {lastNameLength} sümbolit.");
            }
            else
            {
                Console.WriteLine($"Sinu eesnimies in {firstNameLenth} sümbolit. See on sama pikk kui on sinu perekonna nimi, kus on {lastNameLength} sümbolit.");
            }
        }
    }
}
