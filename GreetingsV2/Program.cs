using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            






            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutajat, kasutades neid andmeid
            Console.WriteLine("Mis on su eesnimi?");
            string UserName = Console.ReadLine();
            

            Console.WriteLine("Mis on su perekonnanimi?");
            string UserName2 = Console.ReadLine();
            
            //Console.WriteLine("Hello, " + UserName);

            //string interpolation

            //{} - altGr + 7 / altGr + 0

            Console.WriteLine($"Hello, {UserName} {UserName2}");

            Console.Read();






        }


    }
}
