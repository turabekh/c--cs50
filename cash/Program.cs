using System;

namespace cash
{
    //  a program that calculates the minimum number of 
    // coins required to give a user change
    // coins considered: 25, 10, 5, 1 cents
    class Program
    {
        static void Main(string[] args)
        {
            // set changeOwed at the top to keep it in the context
            float changeOwed;
            // set message outside while loop and change it inside loop if needed
            string message = "Change Owed: ";
            // Validate User Input for non-negative number
            while (true)
            {
                Console.WriteLine(message);
                string inputString = Console.ReadLine();
                bool converted = Single.TryParse(inputString, out changeOwed);
            if (converted && changeOwed >= 0)
            {
                break;
            }
            else
            {
                message = "Please enter positive change in dollars\nChange Owed: ";
                continue;
            }
            }  
            changeOwed = (float)(Math.Round((double)changeOwed, 2)) * 100;
            int coin_counter = 0;  
            while (changeOwed >= 25) 
            {
                coin_counter += 1;
                changeOwed -= 25;
            }
            while (changeOwed >= 10) 
            {
                coin_counter += 1;
                changeOwed -= 10;
            }  
            while (changeOwed >= 5) 
            {
                coin_counter += 1;
                changeOwed -= 5;
            }
            while (changeOwed >= 1) 
            {
                coin_counter += 1;
                changeOwed -= 1;
            }
            Console.WriteLine(coin_counter);                                  
  
        }
    }
}
