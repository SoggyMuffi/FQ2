using System;
using System.Collections.Generic;
using System.Text;

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
        }

    }
}
