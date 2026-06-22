using System;
using System.Collections.Generic;
using System.Text;

namespace FQ2
{
    internal class IntroScenes
    {
       /// <summary>
       /// 
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
