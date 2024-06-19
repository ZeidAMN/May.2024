using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Car
    {
        // Attributes
        public string kennzeichen;
        public string model;
        public string farbe;
        public string produktionsnummer;
        public double ps;
        public double gesamt_tankinhalt;
        public double derzeitiger_tankinhalt;


        // Konstruktor ....  Constructor .... .. Initialisierung .... 
        public Car()
        {
            gesamt_tankinhalt = 0.0;
            produktionsnummer = "A00000";
            ps = 0.0;
            farbe = "White";

        }

        // Methoden
        public void fahren(double kilometer)
        {
            double verbrauchprokilometer = 0.25; // Annahme: Das Auto verbraucht 0.25 Liter pro Kilometer
            double benoetigterkraftstoff = kilometer * verbrauchprokilometer;

            Console.WriteLine("Für " + kilometer + " Kilometer werden " + benoetigterkraftstoff + " Liter Kraftstoff benötigt.");

            if (derzeitiger_tankinhalt >= benoetigterkraftstoff)
            {
                derzeitiger_tankinhalt -= benoetigterkraftstoff;
                Console.WriteLine("Das Auto ist " + kilometer + " Kilometer gefahren.");
                Console.WriteLine("Derzeitiger Tankinhalt nach der Fahrt: " + derzeitiger_tankinhalt + " Liter");
            }
            else
            {
                Console.WriteLine("Nicht genügend Kraftstoff für die Fahrt. Bitte tanken Sie auf.");
            }
        }
    



        public void tanken(double _liter)           //gesamt_tankinhalt = 100         derzeitiger_tankinhalt = 60   liter 4
        {
            Console.WriteLine("jetzt wird getankt");        // platzhalter
            Console.WriteLine("derzeitiger tankinhalt vorher " + derzeitiger_tankinhalt);
            derzeitiger_tankinhalt = derzeitiger_tankinhalt + _liter;

            Console.WriteLine("derzeitiger tankinhalt nachher " + derzeitiger_tankinhalt);
            

        }
    }
}
    


