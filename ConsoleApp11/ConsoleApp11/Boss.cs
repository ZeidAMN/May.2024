using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Boss: Employees
    {

        public double bonus; // Special bonus for the boss
        public string department; // Department the boss oversees
        public string office_number; // Office number of the boss
        public double bonus_percentage; // Percentage of bonus based on performance
        public int years_of_experience; // Years of experience the boss has


        // Basiskonstruktor 
        public Boss()
        {


        }

        // special functions ...
        // mitarbeiter_feuern()...  gehaltskürung()...  befördern()...  
    }
}
