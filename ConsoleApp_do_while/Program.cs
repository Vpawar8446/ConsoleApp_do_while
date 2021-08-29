using System;

namespace ConsoleApp_do_while
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("Element = {0}", i);
                i++;
            }
            while (i <= 10);
        }
    }
}
