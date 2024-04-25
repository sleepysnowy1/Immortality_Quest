using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public static class ColorDisplay
    {
        /// <summary>
        /// Set of overloads which ask for a color for the following string argument, for up to 4 different combinations
        /// of colors and strings. 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="text"></param>
        public static void WriteLine(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteLine(ConsoleColor color1, string text1, ConsoleColor color2, string text2)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color2;
            Console.Write(" " + text2 + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void WriteLine(ConsoleColor color1, string text1, ConsoleColor color2, string text2, ConsoleColor color3, string text3)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color2;
            Console.Write(" " + text2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color3;
            Console.Write(" " + text3 + "\n");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void WriteLine(ConsoleColor color1, string text1, ConsoleColor color2, string text2,
            ConsoleColor color3, string text3, ConsoleColor color4, string text4)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color2;
            Console.Write(" " + text2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color3;
            Console.Write(" " + text3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color4;
            Console.Write(" " + text4 + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Write(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(ConsoleColor color1, string text1, ConsoleColor color2, string text2)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color2;
            Console.Write(" " + text2);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Write(ConsoleColor color1, string text1, ConsoleColor color2, string text2, ConsoleColor color3, string text3)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color2;
            Console.Write(" " + text2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color3;
            Console.Write(" " + text3);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(ConsoleColor color1, string text1, ConsoleColor color2, string text2,
            ConsoleColor color3, string text3, ConsoleColor color4, string text4)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color2;
            Console.Write(" " + text2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color3;
            Console.Write(" " + text3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = color4;
            Console.Write(" " + text4);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
