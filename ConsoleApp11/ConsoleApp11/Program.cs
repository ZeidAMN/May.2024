using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees e1 = new Employees();
            Employees e2 = new Employees("hansi",1000,0982);   // ich kann mittels konstruktor auf den kontostand zigreifen
                                                              // aber nur den wert initialisieren... 
            Employees e3 = new Employees("Salzburg süd, 231/3"); 

            e1.name = "Hansi";
            // e1.bank_balance = 1;      // ich kann von aussen nicht auf das private Attriut Kontostand zugreifen
            //double k = m2.get_bankbalance;
            // Console.WriteLine(k);
            // e2.get_bankbalance = 1000;
            e2.set_bankbalance(1000);
            e3.set_address("Salzburg süd, 231/3");

            Console.WriteLine("Der Kontostand ist " + e2.get_bankbalance());
           
            Console.WriteLine("die Mitarbeiter-NR lautet " + e2.get_employee_id());

            Console.WriteLine("addresse lautet " + e3.get_address());

        }
    }
}
