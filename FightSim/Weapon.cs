using System;

namespace FightSim
{
    class Weapon
    {
        Random random = new Random();

        public string Name = "";
        public int GiveDamage()
        {
            if (Name == "Glock-18")
            {
                return random.Next(1, 10);
            }
            else if (Name == "AK-47")
            {
                return random.Next(5, 10);
            }
            else if (Name == "AWP")
            {
                return random.Next(1, 20);
            }
            else
            {
                return random.Next(1, 5);
            }
        }
    }
}
