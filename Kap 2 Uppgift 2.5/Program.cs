using System;
namespace Uppgift2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ber användaren att skriva in en ekvation med två tal och ett gångertecken
            Console.WriteLine("Skriv en beräkning med två tal och ett gångertecken (a*b).");
            string calc = Console.ReadLine();

            //Räknar ut index för gångertecknet
            int multIndex = calc.IndexOf("*");

            //Skapar float-variabler för talen som användaren skrev
            float number1 = float.Parse(calc[..multIndex]);
            float number2 = float.Parse(calc[(multIndex + 1)..]);

            //Skriver ut produkten
            Console.WriteLine($"{calc} = {number1*number2}.");
            Console.ReadKey();
        }
    }
}