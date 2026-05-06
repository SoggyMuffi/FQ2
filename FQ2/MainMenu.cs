using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FQ2
{
    internal class MainMenu
    {

        public static void Menu()
        {
            string titleFile = "Title.txt";
            string[] title = File.ReadAllLines(titleFile);

            
            foreach (string line in title)
            {
                Utilities.PrintColored(line, ConsoleColor.DarkRed);
            }

            Boolean KeepRunning = true;
            while (KeepRunning) {
                string playerInput = Console.ReadLine() ?? ("".ToLower());
                switch (playerInput)
                {
                    case "e":
                        Console.WriteLine("Work In Progress");
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Menu();
                        Console.WriteLine("Invalid Input: Please type E or Q");
                        

                        break;
                }

            }

        }



    }
}
