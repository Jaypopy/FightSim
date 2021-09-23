using System;

namespace FightSim
{
    class Weapon
    {
        Random random = new Random();

        public string Name = "";
        public int GiveDamage()
        {
            return RandomNumber(1, 10);
        }
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
