using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Employees
    {
        public string name;
        public string social_security_number;
        private double bankbalance;
        public int hierarchy_level;
        private double employee_id;
        private string address;


        public Employees()
        {


        }

        public Employees(string _name, double _bankbalance, double _employee_id)
        {
            name = _name;
            bankbalance = _bankbalance;
            employee_id = _employee_id;

        }

        public Employees(string _address)
        {
            address = _address;

        }

        // ein getter hat nie parameter.. und hat immer einen rückgabewert
        // der datentyp vom rückgabewert ist abhängig vom datentyp den ich "return" will
        public double get_bankbalance() 
        {

            return bankbalance;

        }

        public double get_employee_id()
        {
            return employee_id;

        }
        
        
        // ein setter kann jeder zeit einen bestimmten wert setzen
        // setter hat immer !! parameter und hat nie!! einen rückgabewert // hat immer void!!
        public void set_bankbalance(double _bankbalance)
        {
            bankbalance = _bankbalance;

        }
        // mit Funktionen befüllen
        // get and set .. getter und setter... 

        public string get_address()
        {
            return address;

        }

        public void set_address(string _address)
        {
            address= _address;

        }



    }
}
