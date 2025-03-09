using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace IceAct1
{
    internal class Game
    {
        public static void StartAdventure(SpeechSynthesizer synth)
        {
            PrintWithColor(synth, "You have two exciting options: Do you want to be a chef in a restaurant or explore a food festival?", ConsoleColor.Cyan);
            Console.WriteLine("Type 'chef' or 'customer': ");
            string choice1 = Console.ReadLine().ToLower();

            if (choice1 == "chef")
            {
                Graphics.DrawChef(); // Display chef ASCII art
                PrintWithColor(synth, "You are now a chef! Do you want to cook a gourmet dish or try an experimental fusion recipe?", ConsoleColor.Cyan);
                Console.WriteLine("Type 'gourmet' or 'fusion': ");
                string choice2 = Console.ReadLine().ToLower();

                if (choice2 == "gourmet")
                {
                    Graphics.DrawGourmet(); // Display gourmet dish ASCII art
                    PrintWithColor(synth, "Your dish is a masterpiece! The customers love it, and you've earned the title of Master Chef!", ConsoleColor.Yellow);
                }
                else if (choice2 == "fusion")
                {
                    Graphics.DrawFail(); // Display failure ASCII art
                    PrintWithColor(synth, "Oops! Your fusion experiment was a disaster. The restaurant critic gave you a terrible review!", ConsoleColor.Red);
                }
                else
                {
                    PrintWithColor(synth, "Invalid choice. Please try again.", ConsoleColor.Red);
                    StartAdventure(synth);
                }
            }
            else if (choice1 == "customer")
            {
                PrintWithColor(synth, "You arrive at the food festival! Do you want to try the spicy chili challenge or indulge in a dessert contest?", ConsoleColor.Cyan);
                Console.WriteLine("Type 'chili' or 'dessert': ");
                string choice2 = Console.ReadLine().ToLower();

                if (choice2 == "chili")
                {
                    PrintWithColor(synth, "Wow! That was the spiciest chili ever! You win the challenge, but your mouth is on fire!", ConsoleColor.Yellow);
                }
                else if (choice2 == "dessert")
                {
                    PrintWithColor(synth, "You devour the most delicious desserts and win the Sweet Tooth Award! Yum!", ConsoleColor.Magenta);
                }
                else
                {
                    PrintWithColor(synth, "Invalid choice. Please try again.", ConsoleColor.Red);
                    StartAdventure(synth);
                }
            }
            else
            {
                PrintWithColor(synth, "Invalid choice. Please restart.", ConsoleColor.Red);
                StartAdventure(synth);
            }
        }

        public static void PrintWithColor(SpeechSynthesizer synth, string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            synth.Speak(message);
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}