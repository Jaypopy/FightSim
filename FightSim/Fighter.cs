using System;

namespace FightSim
{
    class Fighter
    {
        public int Hitpoints = 100;

        public Weapon weapon;

        public bool getAlive()
        {
            if (this.Hitpoints <= 0)
            {
                Hitpoints = 0;
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
