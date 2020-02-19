using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: nettoyer les using

using personnages.Classes;

namespace personnages
{
    class Player
    {
        protected int health;
        protected Stack<Stuff> bag;
        protected int bagCapacity;

        public Player()
        {
            Console.WriteLine("Created :");

            bag = new Stack<Stuff>();
        }

        public void AddItem()
        {
            //check si le sac est plein ?
            if (bag.Count >= bagCapacity)
            {
                //throw exception sac plein
            }

            Stuff stu = new Stuff();

            bag.Push(stu);
        }
        public void PopItem()
        {
            //check si le sac est vide ?
            if (bag.Count <= 0)
            {
                //throw exception sac vide
            }

            Stuff stu = bag.Pop();
        }

        public void WeightBag()
        {
            string msg = bag.Count.ToString() + " stuff" + (bag.Count > 1) ? "s" : "";
            Console.WriteLine(msg);
        }
    }
}
