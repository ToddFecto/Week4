using System;

namespace ObjectDemo3
{

    // Created a "model" of some concept called "rectangle".
    // A model is a computer erpresentation of some real-world thing.
    class Rectangle
    {
        public int L;
        public int W;

        public int Area()
        {
            return L * W;
        }

        public void Resize(int newL, int newW)
        {
            if (newL < 0)
            {
                newL = 0;
            }
            L = newL;
            W = newW;
        }

    }
    class Program
    {
        static void TestParams (int n)  //Pass by value
        {
            // Pass by value means the value, not the original
            // variable itself, get passed into the function
            n++; // n = n+1 - incremented n
            Console.WriteLine(n); ;
        }
        static void PrintRect(Rectangle r)
        {
            Console.WriteLine("Here is your rectangle:");
            // This is a "destructive" operation because we're breaking or destroying
            // the object that was sent in. Be careful with that! People using your code
            // might not realise you're doing it. The alternative is todo what's called
            //"non-destructive". We don't change the objects we received.
            r.W = r.W + 1;
            Console.WriteLine(r.W);
            Console.WriteLine(r.L);
            Console.WriteLine(r.Area());
        }

        static void PrintRect2(Rectangle r)
        {
            //Let's do a non=destructive approach
            Rectangle mycopy = new Rectangle() { L = r.L, W = r.W };
            mycopy.W = mycopy.W + 1;
            Console.WriteLine(mycopy.W);
            Console.WriteLine(mycopy.L);
            Console.WriteLine(mycopy.Area());


        }

        static void Main(string[] args)
        {
            int x = 10;
            TestParams(x);
            Console.WriteLine(x);

            Rectangle first = new Rectangle() { L = 15, W = 10 };
            PrintRect(first);

            //Console.WriteLine("Here's the original rectangle. It changed!!!");
            //Console.WriteLine(first.L);
            //Console.WriteLine(first.W);
            //Console.WriteLine(first.Area());

            //Rectangle first = new Rectangle() { L = 15, W = 10 };
            //PrintRect2(first);

            Console.WriteLine("Here's the original rectangle. It changed!!!");
            Console.WriteLine(first.L);
            Console.WriteLine(first.W);
            Console.WriteLine(first.Area());

            first.Resize(150, 100);
            PrintRect2(first);
        }
    }
}
