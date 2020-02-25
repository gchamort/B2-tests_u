using System;

namespace champi.Exceptions
{
    public class EBagIsEmpty : Exception
    {
        public EBagIsEmpty()
        {
            Console.WriteLine("Nope, y a R");
        }
    }
}
