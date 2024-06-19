using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Human
    {
        public static string name;            // Eigenschaften .... Attribute!!!!!
        public static double weight;
        public static double hight;
        public string soz_number;
        public string eye_colour;
        public string skin_colour;
        public string hair_colour;
        public double feet_size;
        public string gender;
        public string nationality;
        public static int age;
        public bool is_alive;
        public bool is_customer;
        public bool is_pregnant;
        public bool have_kids;


        public void daten()         // methode .. ist eine funktion, die sich innerhalb einer klasse befindet
        {
            Console.WriteLine("Name: " + name + " Alter: " + age);
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());

        }

        public void hightandweight()           
        {
            Console.WriteLine("Groesse " + hight + " Gewicht " + weight);
            hight = Convert.ToInt32(Console.ReadLine());
            weight = Convert.ToInt32(Console.ReadLine());
        }

        public static void schlafen()
        {

        }

        public static void bewegen()
        {

        }

        public static void essen()
        {

        }

    }
}
