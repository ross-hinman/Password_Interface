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
            Console.WriteLine($"Hello {charName}! How would you describe yourself? Pick one: Strong, Smart, Clever, or Dumb.");
            string trait = Console.ReadLine();           
            string race = Character(trait);
            Console.WriteLine($"Okay {charName}, it looks like you are a {race}.");



        }

        public static string Character(string trait)
        {
            string race = null;
            if (trait == "strong")
            {
                race = "Orc";
            }
            if (trait == "smart")
            {
                race = "Elf";
            }
            if (trait == "clever")
            {
                race = "Dwarf";
            }
            else if (trait == "dumb")
            {
                race = "Human";
            }
            return race;
        }
    }
}    