using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnages.Classes
{
    class Thief : Player
    {
        public Thief()
        {
            bagCapacity = 4;
            Console.WriteLine($"Thief, capacity : {bagCapacity} stuffs");
        }
    }
}
