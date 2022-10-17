using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolisProjekt
{
    internal class Polis
    {
        Person person = new Person("P");
        Sak things = new Sak();        

        public void Movement()
        {
            person.Movement();
        }
        public string Name()
        {
            return person.Name;
        }
        public int SeePlacementY()
        {
            int placementY = person.PlacementY;
            if (placementY < 0)
            {
                person.PlacementY = 99;
                placementY = 99;
            }
            else if (placementY > 99)
            {
                person.PlacementY = 0;
                placementY = 0;
            }
            return placementY;
        }
        public int SeePlacementX()
        {
            int placementX = person.PlacementX;
            if (placementX < 0)
            {
                person.PlacementX = 24;
                placementX = 24;
            }
            else if (placementX > 24)
            {
                person.PlacementX = 0;
                placementX = 0;
            }
            return placementX;
        }
        public int SetPlacementzeroX(int Position)
        {
            if (Position > 24)
            {
                Position = 0;
            }
            else if (Position < 0)
            {
                Position = 24;
            }
            return Position;
        }
        public int SetPlacementZeroY(int position)
        {
            if (position > 100)
            {
                position = 0;
            }
            else if (position < 0)
            {
                position = 100;
            }
            return position;
        }
    }
}
