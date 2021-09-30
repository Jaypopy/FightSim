using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            int LastDamage;
            int RoundCount = 0;
            bool round = true;
            string answer = "";
            Fighter Yanny = new Fighter();
            Fighter Laurel = new Fighter();
            Yanny.weapon = new Weapon();
            Yanny.weapon.Name = "Glock-18";

            Laurel.weapon = new Weapon();
            Laurel.weapon.Name = "Glock-18";

            while (round)
            {
                Console.Clear(); 
                Yanny.Hitpoints = 100;
                Laurel.Hitpoints = 100;

                while (Yanny.getAlive() && Laurel.getAlive())
                {
                    LastDamage = Laurel.weapon.GiveDamage();
                    Yanny.Hitpoints -= LastDamage;
                    Console.WriteLine("Laurel did " + LastDamage + " Damage.");
                    LastDamage = Yanny.weapon.GiveDamage();
                    Laurel.Hitpoints -= LastDamage;
                    Console.WriteLine("Yanny did " + LastDamage + " Damage.");
                    Console.WriteLine("Laurels HP: " + Laurel.Hitpoints);
                    Console.WriteLine("Yannys HP: " + Yanny.Hitpoints);
                    Console.WriteLine();
                    RoundCount++;
                }
                Console.WriteLine("Total amount of rounds: " + RoundCount);
                Console.WriteLine("Play again?");
                Console.WriteLine("y/n");
                while (true)
                {
                    try
                    {
                        answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "y":
                                break;

                            case "Y":
                                break;

                            case "n":
                                round = false;
                                break;

                            case "N":
                                round = false;
                                break;
                        }
                        break;
                    }
                    catch
                    {

                        Console.WriteLine("Wrong input, try again");
                    }
                }

            }
        }
    }
}
