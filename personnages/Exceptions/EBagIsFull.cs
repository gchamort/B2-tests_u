using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace champi.Exceptions
{
    public class EBagIsFull : Exception
    {
        public EBagIsFull (string e)
        {
            Console.WriteLine("Ya plus la place pour lô " + e);
        }
    }
}
