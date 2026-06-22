using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FQ2
{
    internal class Utilities
    {
        /// <summary>
        /// Prints text in a specified color and resets to default color when finished.
        /// </summary>
        /// <param name="text"> The test to print</param>
        /// <param name="color"> The color to print the text in</param>
        public static void PrintColored(string text, ConsoleColor color)
        {
            Console.ForegroundColor =  color;
            Console.WriteLine(text);
            Console.ResetColor();
            //
        }

        /// <summary>
        /// Prints the contents of a file in a specified color.
        /// </summary>
        /// <param name="fileName"> The name of the file to print</param>
        /// <param name="color"> The color to print the text in</param>
        public static void PrintFile(string fileName, ConsoleColor color = ConsoleColor.Gray) 
        {
            string[] lines = File.ReadAllLines(fileName);
            Console.ForegroundColor = color;

            foreach (string line in lines) 
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }

    }
}
