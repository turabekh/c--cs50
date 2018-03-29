using System;

namespace mario
{
    // a program that prints out a half-pyramid of a specified height
    class Program
    {
        static void Main(string[] args)
        {
            // set height at the top to keep it in the context
            int height;
            // set message outside while loop and change it inside loop if needed
            string message = "Height: ";
            // Validate User Input for integer greater than 0 and less than 23
            while (true)
            {
                Console.WriteLine(message);
                string inputString = Console.ReadLine();
                bool converted = Int32.TryParse(inputString, out height);
            if (converted && (height > 0 && height < 24))
            {
                break;
            }
            else
            {
                message = "Please enter a height greater than zero and less than 23\nHeight:";
                continue;
            }
            }
            int track = height - 1;
            // draw the half pyramid based on user input
            for (int i = 2; i <= (height + 1); i++)
            {
                string space = new String(' ', track);
                string hash = new String('#', i);
                Console.WriteLine(space + hash);
                track -= 1;
            }
        }
    }
}
