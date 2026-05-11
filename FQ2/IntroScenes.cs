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

            foreach (string introfile in FileNames)
            {
                string[] intro = File.ReadAllLines(introfile);

               foreach (string line in intro)
                {
                    Console.WriteLine(line);
                }
                Console.ReadLine();
            }
        }
        



    }
}
