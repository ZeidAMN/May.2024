using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuelle_funktionen
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

        // 2 weitere Konstruktoren einbauen
        // get und set einbauen

        public GameCharacter(string _name, int _id, int _healthPoints, string _specialAbility)
        {
            name= _name;
            id = _id;
            healthpoints = _healthPoints;
            special_ability = _specialAbility;
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
            Console.WriteLine("GameCharacter is fighting");
        }


        public virtual void printData()
        {
            Console.WriteLine("Name: " + name + " Id: " + id + " HealthPoints: " + healthpoints + " SpecialAbility: " + special_ability);
        }


        public string get_special_ability()
        {
            return special_ability;
           
        }

        public void set_special_ability(string _special_ability)
        {
            special_ability = _special_ability;

        }





    }
}
