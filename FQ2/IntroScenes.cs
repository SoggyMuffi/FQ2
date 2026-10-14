using System;
using System.Collections.Generic;
using System.Text;

namespace FQ2
{
    internal class IntroScenes
    {
        /// <summary>
        /// Plays the intro scenes in order. Each scene file is printed to the console,
        /// then the game waits for the player to press Enter before clearing the screen
        /// and moving on to the next scene.
        /// </summary>
        public static void Sceneplayer()
        {
            string[] FileNames = [ "Intro1.txt", ];

          foreach (string FileName in FileNames)
            {
                Utilities.PrintFile(FileName);
                Console.ReadLine();
                Console.Clear();
            }
        }
        



    }
}
