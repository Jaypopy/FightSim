using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter Yanny = new Fighter();
            Fighter Laurel = new Fighter();
            Weapon Gun = new Weapon();
            Gun.Namn = "Glock-18";
            Console.WriteLine(Gun.Namn);
            Console.ReadLine();
            
        }
    }
}
