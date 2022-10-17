using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolisProjekt
{
    internal class Medborgare
    {
        static List<string> belongings = new List<string>();
        Person person = new Person("M", belongings);
        Sak sak = new Sak();

        public void Movement()
        {
            person.Movement();
        }        
        public void PrintInventory()
        {
            Console.WriteLine(belongings[0]);
            Console.WriteLine(belongings[1]);
            //Console.WriteLine(person.Inventory[2]);
            //Console.WriteLine(person.Inventory[3]);
        }
    }
}
