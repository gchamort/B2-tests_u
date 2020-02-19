using champi.Interfaces;

namespace champi.Classes
{
    public class Bolet : IMushroom
    {
        public int GetWeight()
        {
            return 4;
        }
        public string GetName()
        {
            return "Bolet Chauve";
        }
        public string GetColor()
        {
            return "Marron";
        }
        public string GetLabel()
        {
            return GetName().Substring(0, 1);
        }
    }
}
