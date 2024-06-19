using System;

namespace eigenesproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flugzeug flugzeug1 = new Flugzeug();



            Console.WriteLine("bitte geben sie den Name des Modells ein");
            flugzeug1.modell = Console.ReadLine();

            Console.WriteLine("bitte geben sie den Hersteller ein");
            flugzeug1.hersteller = Console.ReadLine();

            Console.WriteLine("bitte geben sie die Baujahr ein ");
            flugzeug1.baujah = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("bitte geben sie die Sitzplätze ein ");
            flugzeug1.sitzplätze = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben sie die Reichweite ein ");
            flugzeug1.reichweite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben sie die Kennzeiche ein ");
            flugzeug1.kennzeichen = Console.ReadLine();

            // den Motor des Flugzeuges
            flugzeug1.startemotor();

            // Tanken
            flugzeug1.tanken(500);      // 500 liter tanken


            Console.Write("Geben Sie den Zielort ein: ");
            string zielort = Console.ReadLine();
            flugzeug1.fliegen(zielort);


            flugzeug1.stoppemotor();





            Console.WriteLine("Hello World!");
        }
    }
}
