using System;
using System.Collections.Generic;
using champi.Interfaces;
using champi.Exceptions;

namespace champi
{
    public class Picker
    {
        private Stack<IMushroom> bag = new Stack<IMushroom>();
        private int bagCapacity;

        public Picker(int capacity)
        {
            bagCapacity = capacity;
        }

        public void AddItem(IMushroom mush)
        {
            //check si le sac est plein ?
            if (GetBagWeight() + mush.GetWeight() > bagCapacity)
            {
                throw new EBagIsFull(mush.GetName());
            }
            bag.Push(mush);
            Console.WriteLine(mush.GetName() + " dans l'sac, un bon "
                + mush.GetWeight() + " kilo" + (mush.GetWeight() == 1 ? "" : "s"));
        }
        public void PopItem()
        {
            //check si le sac est vide ?
            if (bag.Count == 0)
            {
                throw new EBagIsEmpty();
            }

            IMushroom mush = bag.Pop();
            Console.WriteLine("Bye bye " + mush.GetName() + " et ta belle robe " + mush.GetColor());
        }

        public int GetLastMushWeight()
        {
            return bag.Peek().GetWeight();
        }

        public int GetBagCapacity()
        {
            return bagCapacity;
        }

        public int GetBagWeight()
        {
            int weight = 0;

            foreach (IMushroom mush in bag)
            {
                weight += mush.GetWeight();
            }

            return weight;
        }

        public void PeekBag()
        {
            string view = "";

            foreach (IMushroom mush in bag)
            {
                view += mush.GetLabel();
            }

            Console.WriteLine(view);
        }
    }
}
