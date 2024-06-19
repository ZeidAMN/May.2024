using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eigenesproj
{
    internal class Flugzeug
    {
        public string modell;
        public string hersteller;
        public int baujah;
        public int sitzplätze;
        public double reichweite;       // in Kilometern
        public string kennzeichen;
        public string farbe;
        public double gesamt_tankinhalt;
        public double aktuelletankfüllung;
        public bool ist_in_betrieb;


        public Flugzeug()
        {
            sitzplätze = 0;
            reichweite = 0.00;
            kennzeichen = "AT00000";
            farbe = "Weiss";
            gesamt_tankinhalt = 0.00;
            aktuelletankfüllung = 0;
            ist_in_betrieb = false;     // Standardmäßig außer Betrieb

        }

        public void startemotor()
        {
            ist_in_betrieb = true;
            Console.WriteLine("Der Motor des Flugzeugs " + kennzeichen + " wurde gestartet.");
        }

        public void stoppemotor()
        {
            ist_in_betrieb = false;
            Console.WriteLine("Der Motor des Flugzeugs" + kennzeichen + " wurde gestoppt.");
        }

        public void tanken(double _liter)
        {
            aktuelletankfüllung += _liter;
            Console.WriteLine("das Flugzeug " + kennzeichen + " wurde um " + _liter + "Liter getankt. Aktuelle Tankfüllung : " + aktuelletankfüllung + "Liter. ");

        }

        public void fliegen(string _ziel)
        {

            if (ist_in_betrieb && aktuelletankfüllung > 0)
            {
                Console.WriteLine("Das Flugzeug " + kennzeichen + " fliegt zum Zielort: " + _ziel);
                aktuelletankfüllung -= 100;
            }
            else
            {
                Console.WriteLine("Das Flugzeug kann nicht fliegen. Bitte überprüfen Sie den Betriebszustand und den Tankstand.");
            }

        }

    }
}
