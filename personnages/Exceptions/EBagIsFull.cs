using System;

namespace champi.Exceptions
{
    public class EBagIsFull : Exception
    {
        public EBagIsFull (string e)
        {
            Console.WriteLine("Nope, y a plus la place pour lô " + e);
        }
    }
}
