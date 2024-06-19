using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();           // hier wird objekt car1 erzeugt
            string antwort;
            double liter;

            Console.WriteLine("Willkommen zur Auto datenbank ");
            Console.WriteLine("bitte kennzeichen eigeben");
            car1.kennzeichen = Console.ReadLine();

            Console.WriteLine("bitte den gesamten tankinhalt eingeben in liter");
            car1.gesamt_tankinhalt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("bitte geben sie ihre derzeitigen tankinhalt ein");
            car1.derzeitiger_tankinhalt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("bitte geben sie ihre auto model ein");
            car1.model = Console.ReadLine();

            Console.WriteLine("bitte geben sie ihre auto farbe ");
            car1.farbe = Console.ReadLine();

            Console.WriteLine("bitte geben sie das produktionsnummer ein ");
            car1.produktionsnummer = Console.ReadLine();

            Console.WriteLine("bitte geben sie wie viel ps ihre auto hat");
            car1.ps = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("willst du tanken?");
            antwort = Console.ReadLine();

            if (antwort == "ja")
            {
                Console.WriteLine("wie viel willst du tanken?");
                liter = Convert.ToDouble(Console.ReadLine());

                car1.tanken(liter);

            }
            else
            {
               
            }

            Console.WriteLine("Wollen Sie fahren? (ja/nein):");
            antwort = Console.ReadLine().ToLower();

            if (antwort == "ja")
            {
                Console.WriteLine("Wie viele Kilometer möchten Sie fahren?");
                double kilometer = Convert.ToDouble(Console.ReadLine());
                car1.fahren(kilometer);
            }



            Car car2 = new Car();

            Console.WriteLine("Willkommen zur Auto datenbank ");
            Console.WriteLine("bitte kennzeichen eigeben");
            car2.kennzeichen = Console.ReadLine();

            car2.gesamt_tankinhalt = 100;

            Console.WriteLine("bitte geben sie ihre derzeitigen tankinhalt ein");
            car2.derzeitiger_tankinhalt = Convert.ToDouble(Console.ReadLine());

            car2.model = "M4";

            Console.WriteLine("bitte geben sie ihre auto farbe ");
            car2.farbe = Console.ReadLine();

            car2.produktionsnummer = "A000092";

            car2.ps = 300;

            Console.WriteLine(car2.ps);


        }
    }
}
