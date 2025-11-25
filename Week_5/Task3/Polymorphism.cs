using System;

namespace Week_5.Task3
{
    public class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"Printing message: {message}");
        }

        public void Print(int number)
        {
            Console.WriteLine($"Printing number: {number}");
        }

        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {message}");
            }
        }
    }
}
