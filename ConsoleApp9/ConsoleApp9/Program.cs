using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde1 = new Kunde();             // erzeugt mir einen neuen Kunde, kunde1 ist ein Objekt!!!!!!
            Kunde kunde2 = new Kunde();


            // kunde1.name = "Florent Rahimi";
            // kunde1.soz_nr = "230136";

            Console.WriteLine("Wie heißt dein Kunde ?");
            // kunde1.name = Console.ReadLine();

            kunde1.print_data();            // über das objekt greife ich auf die methode print_data zu!!!!



            Console.WriteLine("Gib mir die Geburtsdatum des Kundes");
            kunde1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib mir die Soz nummer des Kundes");
            kunde1.soz_nr = Convert.ToInt32(Console.ReadLine());




            Human human1 = new Human();
            Human human2 = new Human();

           // Console.WriteLine("Wie heißt der Mensch? ");
            // human1.name = Console.ReadLine();

           // Console.WriteLine("gib mir das Gewicht ");
            //human1.weight = Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("Gib mir die Höhe ");
            // human1.hight = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Gib mir die Geburtsdatum ");
           // human1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib mir das Geschlecht");
            human1.gender = Console.ReadLine();


            human1.daten();
            human1.hightandweight();
          
            
            pet pet1 = new pet();
            pet pet2 = new pet();

            Console.WriteLine("Gib mir den Namen des Haustieres");
            pet1.name = Console.ReadLine();

            Console.WriteLine("Gib mir das Alter des Haustieres");
            pet1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welche Art von Tier besitzen Sie?");
            pet1.animal_type = Console.ReadLine();




            Haus haus1 = new Haus();
            Haus haus2 = new Haus();

            Console.WriteLine("geben sie die größe des Hauses in m3");
            haus1.groesse_in_m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie viele Schlafzimmer hat das Haus?");
            haus1.schlafzimmer = Convert.ToInt32(Console.ReadLine());



        }
    }
}
