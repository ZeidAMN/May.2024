using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuelle_funktionen
{
    internal class Enemy:GameCharacter
    {
        // additional attributes !!

        public string name;
        public int id;
        public int healthpoints;
        private string special_ability;

        public Enemy()
        {
            name = "Default Enemy";
            id = 0;
            healthpoints = 100;
            special_ability = "None";
        }

        public Enemy(string name, int id, int healthpoints, string special_ability)
        {
            name = name;
            id = id;
            healthpoints = healthpoints;
            special_ability = special_ability;
        }

        // methods

        public override void fight(GameCharacter gc1, GameCharacter gc2)
        {
            // Console.WriteLine("i am fighting");
            // diese methode macht etwas anderes als die methode fight in der ElternKlasse (GameCharacter)
            Console.WriteLine(gc1.name + gc2.name + "are fighting differently as enemies.");

        }

        public override void printData()
        {
            Console.WriteLine("\nEnemy Data: Name: " + name + " Id: " + id + " healthpoints: " + healthpoints + " SpecialAbility: " + special_ability);

        }

    }
}
