using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VideoPoker;


public class Print
{
    public static void Text(string text, Color colorText = Color.White, Color colorBG = Color.Black)
    {
        switch (colorText)
        {
            case Color.Black: Console.ForegroundColor = ConsoleColor.Black; break;
            case Color.White: Console.ForegroundColor = ConsoleColor.White; break;
            case Color.Red: Console.ForegroundColor = ConsoleColor.Red; break;
            case Color.Green: Console.ForegroundColor = ConsoleColor.Green; break;
            case Color.Blue: Console.ForegroundColor = ConsoleColor.Blue; break;
            case Color.Yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
            case Color.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
            case Color.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
            case Color.DarkRed: Console.ForegroundColor = ConsoleColor.DarkRed; break;
            case Color.DarkMagenta: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
            case Color.DarkYellow: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
            case Color.DarkBlue: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
            case Color.DarkGreen: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
            default: Console.ForegroundColor = ConsoleColor.White; break;
        }
        switch (colorBG)
        {
            case Color.Black: Console.BackgroundColor = ConsoleColor.Black; break;
            case Color.White: Console.BackgroundColor = ConsoleColor.White; break;
            case Color.Red: Console.BackgroundColor = ConsoleColor.Red; break;
            case Color.Green: Console.BackgroundColor = ConsoleColor.Green; break;
            case Color.Blue: Console.BackgroundColor = ConsoleColor.Blue; break;
            case Color.Yellow: Console.BackgroundColor = ConsoleColor.Yellow; break;
            case Color.Magenta: Console.BackgroundColor = ConsoleColor.Magenta; break;
            case Color.Cyan: Console.BackgroundColor = ConsoleColor.Cyan; break;
            case Color.DarkRed: Console.BackgroundColor = ConsoleColor.DarkRed; break;
            case Color.DarkMagenta: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
            case Color.DarkYellow: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
            case Color.DarkBlue: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
            case Color.DarkGreen: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
            default: Console.BackgroundColor = ConsoleColor.Black; break;
        }
        Console.Write(text);

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void Text(int text, Color colorText = Color.White, Color colorBG = Color.Black)
    {
        switch (colorText)
        {
            case Color.Black: Console.ForegroundColor = ConsoleColor.Black; break;
            case Color.White: Console.ForegroundColor = ConsoleColor.White; break;
            case Color.Red: Console.ForegroundColor = ConsoleColor.Red; break;
            case Color.Green: Console.ForegroundColor = ConsoleColor.Green; break;
            case Color.Blue: Console.ForegroundColor = ConsoleColor.Blue; break;
            case Color.Yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
            case Color.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
            case Color.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
            case Color.DarkRed: Console.ForegroundColor = ConsoleColor.DarkRed; break;
            case Color.DarkMagenta: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
            case Color.DarkYellow: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
            case Color.DarkBlue: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
            case Color.DarkGreen: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
            default: Console.ForegroundColor = ConsoleColor.White; break;
        }
        switch (colorBG)
        {
            case Color.Black: Console.BackgroundColor = ConsoleColor.Black; break;
            case Color.White: Console.BackgroundColor = ConsoleColor.White; break;
            case Color.Red: Console.BackgroundColor = ConsoleColor.Red; break;
            case Color.Green: Console.BackgroundColor = ConsoleColor.Green; break;
            case Color.Blue: Console.BackgroundColor = ConsoleColor.Blue; break;
            case Color.Yellow: Console.BackgroundColor = ConsoleColor.Yellow; break;
            case Color.Magenta: Console.BackgroundColor = ConsoleColor.Magenta; break;
            case Color.Cyan: Console.BackgroundColor = ConsoleColor.Cyan; break;
            case Color.DarkRed: Console.BackgroundColor = ConsoleColor.DarkRed; break;
            case Color.DarkMagenta: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
            case Color.DarkYellow: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
            case Color.DarkBlue: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
            case Color.DarkGreen: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
            default: Console.BackgroundColor = ConsoleColor.Black; break;
        }
        Console.Write(text);

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void Text(string text1, string text2, Color colorText1 = Color.White, Color colorBG1 = Color.Black, Color colorText2 = Color.White, Color colorBG2 = Color.Black)
    {
        for (int i = 1; i <= 2; i++)
        {
            Color colorText = i == 1 ? colorText1 : colorText2;
            Color colorBG = i == 1 ? colorBG1 : colorBG2;
            string text = i == 1 ? text1 : text2;

            switch (colorText)
            {
                case Color.Black: Console.ForegroundColor = ConsoleColor.Black; break;
                case Color.White: Console.ForegroundColor = ConsoleColor.White; break;
                case Color.Red: Console.ForegroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.ForegroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.ForegroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }
            switch (colorBG)
            {
                case Color.Black: Console.BackgroundColor = ConsoleColor.Black; break;
                case Color.White: Console.BackgroundColor = ConsoleColor.White; break;
                case Color.Red: Console.BackgroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.BackgroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.BackgroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.BackgroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.BackgroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                default: Console.BackgroundColor = ConsoleColor.Black; break;
            }
            Console.Write(text);

        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void Text(int text1, int text2, Color colorText1 = Color.White, Color colorBG1 = Color.Black, Color colorText2 = Color.White, Color colorBG2 = Color.Black)
    {
        for (int i = 1; i <= 2; i++)
        {
            Color colorText = i == 1 ? colorText1 : colorText2;
            Color colorBG = i == 1 ? colorBG1 : colorBG2;
            int text = i == 1 ? text1 : text2;

            switch (colorText)
            {
                case Color.Black: Console.ForegroundColor = ConsoleColor.Black; break;
                case Color.White: Console.ForegroundColor = ConsoleColor.White; break;
                case Color.Red: Console.ForegroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.ForegroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.ForegroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }
            switch (colorBG)
            {
                case Color.Black: Console.BackgroundColor = ConsoleColor.Black; break;
                case Color.White: Console.BackgroundColor = ConsoleColor.White; break;
                case Color.Red: Console.BackgroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.BackgroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.BackgroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.BackgroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.BackgroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                default: Console.BackgroundColor = ConsoleColor.Black; break;
            }
            Console.Write(text);

        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void Text(int text1, string text2, Color colorText1 = Color.White, Color colorBG1 = Color.Black, Color colorText2 = Color.White, Color colorBG2 = Color.Black)
    {
        for (int i = 1; i <= 2; i++)
        {
            Color colorText = i == 1 ? colorText1 : colorText2;
            Color colorBG = i == 1 ? colorBG1 : colorBG2;


            switch (colorText)
            {
                case Color.Black: Console.ForegroundColor = ConsoleColor.Black; break;
                case Color.White: Console.ForegroundColor = ConsoleColor.White; break;
                case Color.Red: Console.ForegroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.ForegroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.ForegroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }
            switch (colorBG)
            {
                case Color.Black: Console.BackgroundColor = ConsoleColor.Black; break;
                case Color.White: Console.BackgroundColor = ConsoleColor.White; break;
                case Color.Red: Console.BackgroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.BackgroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.BackgroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.BackgroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.BackgroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                default: Console.BackgroundColor = ConsoleColor.Black; break;
            }

            if (i == 1) Console.Write(text1);
            if (i == 2) Console.Write(text2);

        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void Text(string text1, int text2, Color colorText1 = Color.White, Color colorBG1 = Color.Black, Color colorText2 = Color.White, Color colorBG2 = Color.Black)
    {
        for (int i = 1; i <= 2; i++)
        {
            Color colorText = i == 1 ? colorText1 : colorText2;
            Color colorBG = i == 1 ? colorBG1 : colorBG2;


            switch (colorText)
            {
                case Color.Black: Console.ForegroundColor = ConsoleColor.Black; break;
                case Color.White: Console.ForegroundColor = ConsoleColor.White; break;
                case Color.Red: Console.ForegroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.ForegroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.ForegroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }
            switch (colorBG)
            {
                case Color.Black: Console.BackgroundColor = ConsoleColor.Black; break;
                case Color.White: Console.BackgroundColor = ConsoleColor.White; break;
                case Color.Red: Console.BackgroundColor = ConsoleColor.Red; break;
                case Color.Green: Console.BackgroundColor = ConsoleColor.Green; break;
                case Color.Blue: Console.BackgroundColor = ConsoleColor.Blue; break;
                case Color.Yellow: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case Color.Magenta: Console.BackgroundColor = ConsoleColor.Magenta; break;
                case Color.Cyan: Console.BackgroundColor = ConsoleColor.Cyan; break;
                case Color.DarkRed: Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case Color.DarkMagenta: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
                case Color.DarkYellow: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case Color.DarkBlue: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                case Color.DarkGreen: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                default: Console.BackgroundColor = ConsoleColor.Black; break;
            }

            if (i == 1) Console.Write(text1);
            if (i == 2) Console.Write(text2);

        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }


    public enum Color
    {
        Black,
        White,
        Red,
        Green,
        Blue,
        Yellow,
        Magenta,
        Cyan,
        DarkRed,
        DarkYellow,
        DarkGreen,
        DarkBlue,
        DarkMagenta
    }
}