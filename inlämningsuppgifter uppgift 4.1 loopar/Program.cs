using System;

namespace loopar
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int x =10; x<=30; x++)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
            for (int y = 200; y>=180; y--)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("\n");
            for (int z = 1000; z <= 1400; z += 50) 
            {
                Console.WriteLine(z);
            }
        }
    }
}
