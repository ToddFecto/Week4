using System;

namespace ObjectDemo2
{

    class Rectangle
    {
        public int L;
        public int W;

        public int Area()
        {
            return L * W;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Let's try copying object variables around

            // But first do it with integers to compare

            int x;
            x = 10;
            int y;
            y = x;
            //So now y has 10

            // Now change x
            x = 15;

            // Now what is in y?
            // We didnt' change y, so it still has a 10 in it

            Rectangle first;
            first = new Rectangle() { L = 15, W = 20 };    // Member initialization (Shorthand for next two line assignments)
            // first.L = 15;
            // first.W = 20;
            Console.WriteLine(first.Area());

            Rectangle second;
            second = first;
            Console.WriteLine(second.Area());

            second.L = 25;
            Console.WriteLine(first.L);


        }
    }
}
