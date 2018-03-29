using System;

namespace credit
{
    class Program
    {
        static void Main(string[] args)
        {
            // set card_number at the top to keep it in the context
            ulong card_number;
            // set message outside while loop and change it inside loop if needed
            string message = "Card Number: ";
            // Validate User Input for non-negative number
            while (true)
            {
                Console.WriteLine(message);
                string inputString = Console.ReadLine();
                bool converted = UInt64.TryParse(inputString, out card_number);
            if (converted && card_number > 0)
            {
                break;
            }
            else
            {
                message = "Please enter card number\nCard Number: ";
                continue;
            }
            }             
        }
    }
}
