using System;

namespace virtuelle_funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameCharacter gc1 = new GameCharacter("Hero", 1, 150, "Invisibility");
            GameCharacter gc2 = new GameCharacter("Villain", 2, 120, "Strength");

            gc1.fight(gc1, gc2);
            gc1.printData();

            SuperheroVillain hero = new SuperheroVillain("Superhero", 3, 200, "Flight");
            hero.fight(gc1, gc2);
            hero.printData();

            Enemy enemy = new Enemy("Enemy", 4, 80, "Poison");
            enemy.fight(gc1, gc2);
            enemy.printData();

            // Using GameController
            GameCharacter gc3 = GameController.CreateGameCharacter("New Hero", 5, 180, "Telepathy");
            gc3.printData();
            GameController.fight(gc1, gc3);


        }
    }
}
