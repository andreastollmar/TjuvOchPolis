using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolisProjekt
{
    internal class Tjuv
    {
        Person person = new Person("T");
        Sak things = new Sak();

        public void Movement()
        {
            person.Movement();            
        }
        public void Name()
        {
            Console.Write(person.Name);
        }
    }
}
