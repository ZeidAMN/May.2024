using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheksverwaltungssystem
{
    internal class Verwaltungssystem
    {
        private static List<Buch> buecher = new List<Buch>();

        public static void buch_input()
        {
            string buch_;
            do
            {
                Console.Write("Gib den Buchtitel ein (oder 'x', um die Eingabe zu beenden): ");
                string titel = Console.ReadLine();
                if (titel.ToLower() == "x") // Überprüfung, ob der Benutzer die Eingabe beenden möchte
                    break;

                Console.Write("Gib den Autor ein: ");
                string autor = Console.ReadLine();

                Console.Write("Gib die ISBN ein: ");
                string isbn = Console.ReadLine();

                Buch buch = new Buch(titel, autor, isbn);
                buecher.Add(buch);

                Console.WriteLine("Buch erfolgreich hinzugefügt.");
                Console.WriteLine("Drücke 'x', um die Eingabe zu beenden, oder enter, weitere Bücher hinzuzufügen.");
                buch_ = Console.ReadLine();
            } while (buch_ != "x");
        }

        public static void buch_hinzufuegen()
        {
            Console.Write("Gib den Buchtitel ein: ");
            string titel = Console.ReadLine();

            Console.Write("Gib den Autor ein: ");
            string autor = Console.ReadLine();

            Console.Write("Gib die ISBN ein: ");
            string isbn = Console.ReadLine();

            Buch buch = new Buch(titel, autor, isbn);
            buecher.Add(buch);
            Console.WriteLine("Buch erfolgreich hinzugefügt.");
        }

        public static void buecher_anzeigen()
        {
            if (buecher.Count == 0)
            {
                Console.WriteLine("Keine Bücher in der Bibliothek.");
                return;
            }

            Console.WriteLine("Bücher in der Bibliothek:");
            foreach (Buch buch in buecher)
            {
                Console.WriteLine(buch);
            }
        }

        public static void suchen_loeschen()
        {
            Console.Write("Gib den Titel oder Autor des zu löschenden Buches ein: ");
            string suchbegriff = Console.ReadLine();

            Buch buchZuLoeschen = null;
            foreach (Buch buch in buecher)
            {
                if (buch.titel == suchbegriff || buch.autor == suchbegriff)
                {
                    buchZuLoeschen = buch;
                    break;
                }
            }

            if (buchZuLoeschen != null)
            {
                buecher.Remove(buchZuLoeschen);
                Console.WriteLine("Buch erfolgreich gelöscht.");
            }
            else
            {
                Console.WriteLine("Buch nicht gefunden.");
            }
        }

        public static void buecher_nach_autor_auflisten()
        {
            Console.Write("Gib den Namen des Autors ein: ");
            string autor = Console.ReadLine();

            List<Buch> buecherNachAutor = new List<Buch>();
            foreach (Buch buch in buecher)
            {
                if (buch.autor == autor)
                {
                    buecherNachAutor.Add(buch);
                }
            }

            if (buecherNachAutor.Count == 0)
            {
                Console.WriteLine("Keine Bücher von diesem Autor gefunden.");
                return;
            }

            Console.WriteLine("Bücher von" + autor,":" );
            foreach (Buch buch in buecherNachAutor)
            {
                Console.WriteLine(buch);
            }

        }
    }
}
