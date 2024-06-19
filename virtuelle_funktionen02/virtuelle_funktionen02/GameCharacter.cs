using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuelle_funktionen02
{
    internal class GameCharacter
    {
        public string name;
        public int id;
        public int healthpoints;
        private string special_ability;

        public GameCharacter()
        {
            name = "Unknown";
            id = 0;
            healthpoints = 100;
            special_ability = "None";
        }

        public GameCharacter(string name, int id, int healthpoints, string special_ability)
        {
            this.name = name;
            this.id = id;
            this.healthpoints = healthpoints;
            this.special_ability = special_ability;
        }

        public GameCharacter(GameCharacter character)
        {
            name = character.name;
            id = character.id;
            healthpoints = character.healthpoints;
            special_ability = character.special_ability;
        }

        public virtual void fight(GameCharacter gc1, GameCharacter gc2)
        {
            Console.WriteLine(gc1.name + " attacks " + gc2.name , gc2.name + " loses 5 health points.");
            gc2.healthpoints -= 5;
            Console.WriteLine(gc2.name + " now has " + gc2.healthpoints + " health points left.");
        }

        public virtual void printData()
        {
            Console.WriteLine("Name:" + name + " Id:" + id + " HealthPoints:" + healthpoints + " SpecialAbility:" + special_ability);
        }

        public string get_special_ability()
        {
            return special_ability;
        }

        public void set_special_ability(string special_ability)
        {
            this.special_ability = special_ability;
        }
    }
}

 