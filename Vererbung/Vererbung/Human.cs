using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Human
    {
        public string name;
        public int augen;
        public string haarfarbe;
        private string id;

        public Human()
        {


        }

        public Human(string _name)
        {
            name = _name;

        }

        public void printData()
        {
            Console.WriteLine("Name: " + name + " Augen: " + augen + " Haarfarbe: " + haarfarbe);
         

        }

        public void fight()
        {

            Console.WriteLine("fighting ");

        }



    }
}
