using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuelle_funktionen
{
    internal class SuperheroVillain:GameCharacter
    {
        // additional attributes !!

        public string name;
        public int id;
        public int healthpoints;
        private string special_ability;

        public SuperheroVillain()
        {
            name = "Default SuperheroVillain";
            id = 0;
            healthpoints = 100;
            special_ability = "None";
            
        }

        public SuperheroVillain(string name, int id, int healthpoints, string special_ability)
        {
            name = name;
            id = id;
            healthpoints = healthpoints;
            special_ability = special_ability;
        }

        // 2 weitere Konstruktoren einbauen
        // virtuelle methoden in c#,  Polymorphismus,  Kapselung... 
        // statische Klasse GameController zu ersatellen, die dann das spiel verwaltet mit statischen methoden wie zu create_GC zu fight.. a.o.
        public override void fight(GameCharacter gc1, GameCharacter gc2)
        {
            // random mit zufalls zahlen gegner gegeneinander antreten lassen
            // Console.WriteLine("i am fighting");
            // diese methode macht etwas anderes als die methode fight in der ElternKlasse (GameCharacter)
            Random rand = new Random();
            int result = rand.Next(2); // 0 or 1

            if (result == 0)
                Console.WriteLine(gc1.name + " wins!");
            else
                Console.WriteLine(gc2.name + " wins!");

        }

        public override void printData()
        {
            Console.WriteLine("\nSuperheroVillain Data: Name: " + name + " Id: " + id + " HealthPoints: " + healthpoints + " SpecialAbility: " + special_ability);
        }

    
    }
}
