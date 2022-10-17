using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolisProjekt
{
    internal class Sak
    {
        static int arrested = 0;
        static int robbed = 0;
        public string[] items = { "Keys", "Money", "Cellphone", "Watch" };

        public List<string> AddInventory(List<string> things)
        {
            things.AddRange(items);
            return things;
        }
        public Sak()
        {
            
        }
        public string StealItem(List<string> inventory)
        {
            Random rnd = new Random();
            int steal = rnd.Next(0, (inventory.Count + 1));
            string taken = inventory[steal];
            inventory.RemoveAt(steal);
            robbed++;
            return taken;
        }
        
    }
}
