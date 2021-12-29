using System;

namespace Legeng
{
    class Program
    {
        //use of global variables for character selection
        public static int Selection { get; private set; }
        public static string PlayerName { get; private set; }
        public static int Age { get; private set; }                    
        public static string CharacterData = "";

        static void Main(string[] args)
        {
            //Color Settings
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            //introduction 
            Console.WriteLine("\nWelcome to Elroz, Land of Monsters and Quest!\n" +
                "\nBefore continuing, we must understand your role young hero." +
                "\nCurrently in our World, there exist Three Guilds; 'The Shield', 'The Sword', and 'The Elixir'." +
                "\nUnderstand that each Guild breaks down their classes into sub-categories.\n");
            Console.WriteLine("-----------------------------------------------------------------------------");

            //character information with while loop to verify player preference
            while (CharacterData != "Yes" && CharacterData != "yes") {
                Console.WriteLine("\nLet's make sure all information is correct. Please tell us your name: ");
                string PlayerName = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Alright " + PlayerName + ", How old are you? ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------");

                Console.WriteLine("\nBefore we continue, you have chosen '" + PlayerName + "' as your adventurer name " +
                    "you have stated to be " + age + " years old.");

                Console.WriteLine("Is your information correct:  Yes or No");
                CharacterData = Console.ReadLine();                
            }

            //Do-While loop to verify selection.
            //Selection to call different class with story configuration
            Console.WriteLine("\nPlease select a Guild to join: \n");
            do
            {
                Console.WriteLine("To Join the Shield Guild, Enter option '1'.\n" +
                                  "To Join the Sword Guild, Enter option '2'.\n" +
                                  "To Join the Elixir Guild, Enter option '3'.\n");
                int Selection = int.Parse(Console.ReadLine());
                if (Selection == 1)
                {
                    ShieldStory.ShieldGuild();
                    break;
                }
                else if (Selection == 2)
                {
                    SwordStory.SwordGuild();
                    break;
                }
                else if (Selection == 3)
                {
                    ElixirStory.ElixirGuild();
                    break;
                }
            }
            while (Selection != 1 && Selection != 2 && Selection != 3);            
            { }
            Console.WriteLine("-----------------------------------------------------------------------------");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Legeng
{
    class ShieldStory
    {

        public static string ShieldGuild()
        {
            //Console.Clear();

            Console.WriteLine("");
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Legeng
{
    class SwordStory
    {
        public static string SwordGuild()
        {
            Console.WriteLine("");
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Legeng
{
    class ElixirStory
    {
        public static string ElixirGuild()
        {
            Console.WriteLine("");
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Legeng
{
    class LootClass
    {
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Legeng
{
    class MonsterClass
    {
    }
}
