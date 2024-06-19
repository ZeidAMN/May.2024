using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuelle_funktionen02
{
    internal class Enemy: GameCharacter
    {
        public Enemy()
        {
            name = "Default Enemy";
            id = 0;
            healthpoints = 100;
            set_special_ability("None");
        }

        public Enemy(string name, int id, int healthpoints, string special_ability)
        {
            this.name = name;
            this.id = id;
            this.healthpoints = healthpoints;
            set_special_ability(special_ability);
        }

        public override void fight(GameCharacter gc1, GameCharacter gc2)
        {
            Console.WriteLine(gc1.name + " is attacking " + gc2.name + " with a special move as an Enemy.");
            gc2.healthpoints -= 10;
            Console.WriteLine(gc2.name + " loses 10 health points and now has " + gc2.healthpoints + "health points left.");
        }

        public override void printData()
        {
            Console.WriteLine("Enemy Data: Name: " + name + "Id: " + id + " HealthPoints: " + healthpoints + " SpecialAbility: " + get_special_ability());
        }
    }
}