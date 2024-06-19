using System;

namespace Bibliotheksverwaltungssystem
{
    internal class Buch
    {
        public string titel { get; set; }           // get & set noch nicht gelernt es kommt nur von chatGPT
        public string autor { get; set; }
        public string isbn { get; set; }

        public Buch(string _titel, string _autor, string _isbn)
        {
            titel = _titel;
            autor = _autor;
            isbn = _isbn;
        }

        public override string ToString()
        {
            return "Titel: " + titel + ", Autor: " + autor + ", ISBN: " + isbn;
        }


        private static void Main(string[] args)
        {
            int wahl;

            Verwaltungssystem.buch_input();

            do
            {

                Console.WriteLine("\nBibliotheksverwaltung:");
                Console.WriteLine("1. Buch hinzufügen");
                Console.WriteLine("2. Alle Bücher anzeigen");
                Console.WriteLine("3. Buch suchen und löschen");
                Console.WriteLine("4. Bücher nach Autor auflisten");
                Console.WriteLine("5. Beenden");
                Console.Write("Wähle eine Option: ");
                wahl = Convert.ToInt32(Console.ReadLine());


                switch (wahl)
                {
                        case 1:
                        Verwaltungssystem.buch_hinzufuegen();
                        break;

                        case 2:
                        Verwaltungssystem.buecher_anzeigen();
                        break;

                        case 3:
                        Verwaltungssystem.suchen_loeschen();
                        break;

                        case 4:
                        Verwaltungssystem.buecher_nach_autor_auflisten();
                        break;

                        case 5:
                        Console.WriteLine("Programm wird beendet...");
                        break;

                        default:
                        Console.WriteLine("Ungültige Wahl. Bitte eine Zahl zwischen 1 und 5 eingeben.");
                        break;
                }
            } while (wahl != 5);
        }
    }
}
   