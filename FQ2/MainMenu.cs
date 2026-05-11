using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FQ2
{
    internal class MainMenu
    {
        /// <summary>
        /// Reads and displays the title screen, then prompts the player to either
        /// start the game or quit. Calls ScenePlayer when E is entered.
        /// </summary>
        public static void Menu()
        {
            string titleFile = "Title.txt";
            string[] title = File.ReadAllLines(titleFile);

            
            foreach (string line in title)
            {
                Utilities.PrintColored(line, ConsoleColor.DarkRed);
            }

            bool KeepRunning = true;
            while (KeepRunning) {
                string playerInput = (Console.ReadLine() ??"").ToLower();
                switch (playerInput)
                {
                    case "e":
                        KeepRunning = false;
                        Console.Clear();
                        IntroScenes.Sceneplayer();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        
                    
                        Console.WriteLine("Invalid Input: Please type E or Q");
                        break;
                }

            }

        }



    }
}
