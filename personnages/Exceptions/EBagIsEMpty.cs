using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace champi.Exceptions
{
    public class EBagIsEmpty : Exception
    {
        public EBagIsEmpty()
        {
            Console.WriteLine("Ya R");
        }
    }
}
