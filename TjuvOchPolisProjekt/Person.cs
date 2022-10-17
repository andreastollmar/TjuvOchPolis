using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolisProjekt
{
    internal class Person
    {
        public int MovementY { get; set; }
        public int MovementX { get; set; }
        public int PlacementY { get; set; }
        public int PlacementX { get; set; }
        public List<string> Inventory { get; set; }
        public string Name { get; set; }


        public Person(string name, List<string> belongnings)
        {
            Sak sak = new Sak();
            Random rnd = new Random();
            MovementX = rnd.Next(-1, 2);
            MovementY = rnd.Next(-1, 2);
            PlacementX = rnd.Next(0, 25);
            PlacementY = rnd.Next(0, 100);
            Name = name;
            belongnings.AddRange(sak.items);
        }
        public Person(string name)
        {            
            Random rnd = new Random();
            MovementX = rnd.Next(-1, 2);
            MovementY = rnd.Next(-1, 2);
            PlacementX = rnd.Next(0, 25);
            PlacementY = rnd.Next(0, 100);
            Name = name;
            Inventory = new List<string>();
        }

        public void Movement()
        {            
            PlacementY += MovementY;
            PlacementX += MovementX;
        }


    }
}
