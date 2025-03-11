using System;
using System.Speech.Synthesis;

namespace IceAct1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console background and text colors
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // Create a new SpeechSynthesizer instance
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            // Introduction
            Song.PlayIntro();
            Game.PrintWithColor(synth, "Welcome to Farren's Ultimate Food Adventure!", ConsoleColor.White);

            // Start the food adventure
            
            Game.StartAdventure(synth);

            // Farewell message
            Song.PlayIntro();
            Game.PrintWithColor(synth, "Thanks for playing the Food Adventure Game! Stay hungry for more!", ConsoleColor.Magenta);
        }

        public class Song
        {
            public static void PlayIntro()
            {
                Console.Beep(880, 200);
                Console.Beep(880,200);
                Console.Beep(988, 200);
                Console.Beep(1046, 200);
                Console.Beep(988, 200);
                Console.Beep(880, 200);
                Console.Beep(880, 200);
            }
        }
    }
}