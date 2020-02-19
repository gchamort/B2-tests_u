using champi.Interfaces;

namespace champi.Classes
{
    public class Amanite : IMushroom
    {
        public int GetWeight()
        {
            return 2;
        }
        public string GetName()
        {
            return "Amanite Phalloïde";
        }
        public string GetColor()
        {
            return "Beige";
        }
        public string GetLabel()
        {
            return GetName().Substring(0, 1);
        }
    }
}
