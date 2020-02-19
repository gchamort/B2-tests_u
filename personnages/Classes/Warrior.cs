using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnages.Classes
{
    class Warrior : Player
    {
        public Warrior()
        {
            bagCapacity = 1;
            Console.WriteLine($"Warrior, capacity : {bagCapacity} stuffs");
        }
    }
}
