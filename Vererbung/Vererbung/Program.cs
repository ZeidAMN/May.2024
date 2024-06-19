using System;

namespace Vererbung
{
    public class Program
    {
        static void Main(string[] args)
        {

            Human h1 = new Human();
            Human h2 = new Human("hansi");
            SuperHuman s1 = new SuperHuman();           // Human ise die Elternklasse (parent). Es werden alle public Attribute vererbt
                                                        // private attribute werden nicht vererbt...
                                                        // für private braucht man methode um zu verwenden

            h1.printData();
            h1.fight();                                 // um auf die methode fight zuzugreifen brauche ich kein objekt!!!
            s1.fight();

            // wie greifen wir auf fight in der Klasse gamecontroller zu??? :
            GameController.fight(h1, s1);

            // Console c = new Console();
            // c.writeline("Hello World!");

           
            //Console.WriteLine("Hello World!");
        }
    }
}
