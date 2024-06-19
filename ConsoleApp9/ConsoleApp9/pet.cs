using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class pet              // klasse immer groß schreiben
    {
        public string name;
        public int age;
        public double weight;              // immer klein
        public double hight;
        public string skin_colour;
        public string animal_type;
        public bool is_alive;
        public bool is_dangerous;
        public bool is_friendly;




        public static void laufen()         // methode .. ist eine funktion, die sich innerhalb einer klasse befindet
        {

        }

        public static void dangerous()            
        {
            
        }

        public void CheckAliveStatus()
        {
            if (is_alive)
            {
                Console.WriteLine(name + " ist noch am Leben.");
            }
            else
            {
                Console.WriteLine(name + " ist nicht mehr am Leben.");
            }
        }

        public static void bewegen()
        {

        }

        public static void essen()
        {

        }

    }
}
