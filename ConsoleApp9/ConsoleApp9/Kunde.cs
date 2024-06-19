using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Kunde
    {
        public string name;
        public int age;
        public double konto_inhalt;
        public string firmen_status;
        public double zinssatz;
        public int soz_nr;
        public bool is_super_customer;
        public bool is_boss;
        private string kundenkennwort;


        public static void geldabheben()            // methode .. ist eine funktion, die sich innerhalb einer klasse befindet
        {

        }

        public static void kennwort_aendern()
        {

        }
        public void print_data()            
        {

            Console.WriteLine("Name: " + name + " Firmenstatus: " + firmen_status);
            name = Console.ReadLine();
            firmen_status = Console.ReadLine();
        }

        public static void name_wechseln()
        {

        }

        

    }
}
