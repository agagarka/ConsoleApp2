using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            while (i > 7)
            {
                Console.WriteLine(i);
                i--;
            }

            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 7);
        }
    }
}
