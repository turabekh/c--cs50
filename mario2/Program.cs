using System;

namespace mario2
{
    // a program that prints out a double half-pyramid of a specified height
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
            // draw the half pyramid based on user input
            int track = height - 1;
            for (int i = 1; i <= height; i++)
            {
                string space = new String(' ', track);
                string hash = new String('#', i);
                Console.WriteLine(space + hash + "  " + hash + space);
                track -= 1;
            }
        }
    }
}
