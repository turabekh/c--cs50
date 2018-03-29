using System;

namespace mario3
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            bool converted;
            do
            {
                Console.WriteLine("Height: ");
                string height_string = Console.ReadLine();
                converted = Int32.TryParse(height_string, out height);
            } while (!converted || height <= 0);
            for (int i = 0; i < height; i++)
            {
                for (int space = height; space > i; space--)
                {
                    Console.Write(' ');
                }
                for (int hash = 0; hash < i + 2; hash++)
                {
                    Console.Write('#');
                }
                Console.Write('\n');
            }
        }
    }
}
