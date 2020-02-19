using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using champi.Interfaces;

namespace champi.Classes
{
    public class Chanterelle : IMushroom
    {
        public int GetWeight()
        {
            return 1;
        }
        public string GetName()
        {
            return "Chanterelle, ou Girolle selon la région,";
        }
        public string GetColor()
        {
            return "Jaune";
        }
        public string GetLabel()
        {
            return GetName().Substring(0, 1);
        }
    }
}

