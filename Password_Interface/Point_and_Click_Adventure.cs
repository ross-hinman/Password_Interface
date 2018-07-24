using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Interface
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Greetings traveler! Let's get to know you a little bit.\nWhat is your name?");
            string charName = Console.ReadLine();
            int raceNumber = 0;
            Console.WriteLine($"Hello {charName}!");
            bool i = true;
            int healthMax = 20;
            int health = 20;
            int arcane = 10;
            int charisma = 10;
            int strength = 10;
            int intelegence = 10;
            int luck = 10;

            do
            {
                Trait(ref raceNumber, charName);
                string race = Race(ref raceNumber);
                Console.WriteLine($"So {charName}, it looks like you are a {race}.");

                StatsEdit(ref raceNumber, ref healthMax, ref health, ref arcane, ref charisma, ref strength, ref intelegence, ref luck);
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "Health", "Arcane", "Charisma", "Strength", "Intelegence", "Luck");
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "======", "======", "========", "========", "===========", "====");
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", healthMax, arcane, charisma, strength, intelegence, luck);
                ReRoll(ref i);
            } while (i == false);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Your story begins...");
            string choice1 = Tavern();
            if (choice1 == "1")
            {
                Mill();
            }
            if (choice1 == "2")
            {
                Chat();
            }
        }

        public static void Trait(ref int raceNumber, string charName)
        {
            
            bool repeat = true;

            while (repeat == true)
            {
                Console.WriteLine($"How would you describe yourself? Pick one: Strong, Smart, Clever, or Dumb.");
                string trait = Console.ReadLine();
                trait = trait.ToLower();
                if (trait == "strong")
                {
                    repeat = false;
                    raceNumber = 1; //Orc
                }
                else if (trait == "smart")
                {
                    repeat = false;
                    raceNumber = 2; //Elf
                }
                else if (trait == "clever")
                {
                    repeat = false;
                    raceNumber = 3; //Dwarf
                }
                else if (trait == "dumb")
                {
                    repeat = false;
                    raceNumber = 4; //Human
                }
                else
                {
                    Console.WriteLine("Please pick one of the four options.");
                    repeat = true;
                }
            }
        }

        public static string Race(ref int race)
        {
            if (race == 1)
            {
                return "Orc";
            }
            else if (race == 2)
            {
                return "Elf";
            }
            else if (race == 3)
            {
                return "Dwarf";
            }
            else
            {
                return "Human";
            }
        }

        public static void StatsEdit(ref int raceNumber, ref int healthMax, ref int health, ref int arcane, ref int charisma, ref int strength, ref int intelegence, ref int luck)
        {
            if (raceNumber == 1)
            {
                healthMax = 30;
                health = 30;
                arcane = 5;
                charisma = 3;
                strength = 12;
                intelegence = 4;
                luck = 10;
            }
            if (raceNumber == 2)
            {
                healthMax = 18;
                health = 18;
                arcane = 10;
                charisma = 7;
                strength = 6;
                intelegence = 12;
                luck = 6;
            }
            if (raceNumber == 3)
            {
                healthMax = 25;
                health = 25;
                arcane = 8;
                charisma = 10;
                strength = 8;
                intelegence = 6;
                luck = 5;
            }
            if (raceNumber == 4)
            {
                healthMax = 28;
                health = 28;
                arcane = 8;
                charisma = 8;
                strength = 7;
                intelegence = 6;
                luck = 7;
            }

        }

        public static void ReRoll(ref bool i)
        {
            Console.WriteLine("Do these stats look correct to you? (y/n) If no, you may choose a different option");
            string reroll = Console.ReadLine();
            reroll = reroll.ToLower();

            if (reroll == "y")
            {
                Console.WriteLine("Great! Let's get started!");
                i = true;
            }
            else if (reroll == "n")
            {
                i = false;
            }
        }

        public static string Tavern()
        {
            Console.WriteLine("You find yourself in the middle of a celebration surrounded by a boisterous crowd in the local tavern.\nToday is the day the prince of your region was crowned king.");
            Console.WriteLine("His father, King Brynwolf had fallen ill in the spring and died not long after.\nNow, just in time for harvest, Prince Lorek took his father's place on the throne.");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("In the midst of the clanking tankards and drunken chants,\nyou violently bump into a young man who looks lost and very shaken up.");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("You ask the young man why he looks so bothered and isn't celebrating like everyone else.");
            Console.WriteLine("The man gives you a half glance, and scoffs at your remark.");
            Console.WriteLine("-If you had half an ounce of sense in you, you wouldn't be celebrating either- he replies,\navoiding eye contact the entire time.");
            Console.WriteLine("-What do you mean? What are you not telling me? - you ask.");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("-I can't talk about this here, there's too many ears.\nIf you want to know more, meet me at the mill on the edge of the river. There we can talk.");
            Console.WriteLine("He doesn't give you a chance to respond before he pushes through the rest of the crowd and out the door.");
            Console.WriteLine();
            Console.WriteLine("What do you do? (1/2)\n1: Follow the man immediatly to the mill.\n2: Stay a little longer and see if anyone else will talk.");
            string choice = Console.ReadLine();
            return choice;
        }

        public static void Mill()
        {
            Console.WriteLine("You head for the mill right away.");
        }

        public static void Chat()
        {
            Console.WriteLine("You stay in the tavern for a little longer, seeing if anyone else has information to give you.");
        }
    }
}
    