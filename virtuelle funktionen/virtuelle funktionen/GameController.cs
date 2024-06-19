using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuelle_funktionen
{
    internal class GameController
    {
        public static GameCharacter CreateGameCharacter(string name, int id, int healthpoints, string special_ability)
        {
            return new GameCharacter(name, id, healthpoints, special_ability);
        }

        public static void fight(GameCharacter gc1, GameCharacter gc2)
        {
            gc1.fight(gc1, gc2);
        }
    }
}
