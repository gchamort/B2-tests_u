using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnages.Classes
{
    class Mage : Player
    {
        public Mage()
        {
            bagCapacity = 3;
            Console.WriteLine($"Mage, capacity : {bagCapacity} stuffs");
        }
    }
}
