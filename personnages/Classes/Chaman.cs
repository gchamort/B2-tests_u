using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnages.Classes
{
    class Chaman : Player
    {
        public Chaman()
        {
            bagCapacity = 2;
            Console.WriteLine($"Chaman, capacity : {bagCapacity} stuffs");
        }
    }
}
