using System;
using static System.Console;

namespace DisplayWithBorder
{
    class BorderDisplay
    {
        static void Main()
        {
            DisplayWithBorder("Ed");
            DisplayWithBorder(3);
            DisplayWithBorder(456);
            DisplayWithBorder(897654);
            DisplayWithBorder("Veronica");

            DisplayWithBorder(-456);
            DisplayWithBorder(-897654);

            DisplayWithBorder(897654.9999999);

            Convert.ToString(22.4);
        }

        private static void DisplayWithBorder(string word)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = word.Length + EXTRA_STARS;
            int x;
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine();
            WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine("\n\n");
        }
        
        private static void DisplayWithBorder(int number)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = EXTRA_STARS + 1;
            int leftOver = number;
            int x;
            if(number >= 0)
            {
                while (leftOver >= 10)
                {
                    leftOver = leftOver / 10;
                    ++size;
                }
            }
            else
            {
                while (leftOver <= -10)
                {
                    leftOver = leftOver / 10;
                    ++size;
                }
                ++size;
            }
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine();
            WriteLine(SYMBOL + " " + number + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine("\n\n");
        }
        

        private static void DisplayWithBorder(double number)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            string word = number.ToString("C"); //Converts to string to get the length

            int size = word.Length + EXTRA_STARS;
            int x;
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine();
            WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Write(SYMBOL);
            WriteLine("\n\n");
        }
    }
}
