using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            int LastDamage;
            Fighter Yanny = new Fighter();
            Fighter Laurel = new Fighter();
            Yanny.weapon = new Weapon();
            Yanny.weapon.Name = "Glock-18";

            Laurel.weapon = new Weapon();
            Laurel.weapon.Name = "Glock-18";

            Console.WriteLine(Yanny.Hitpoints + Laurel.Hitpoints);
            while (Yanny.getAlive() && Laurel.getAlive())
            {
                LastDamage = Laurel.weapon.GiveDamage();
                Yanny.Hitpoints -= LastDamage;
                Console.WriteLine("Laurel did " + LastDamage + " Damage.");
                LastDamage = Yanny.weapon.GiveDamage();
                Laurel.Hitpoints -= LastDamage;
                Console.WriteLine("Yanny did " + LastDamage + " Damage.");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
