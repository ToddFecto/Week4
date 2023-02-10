using System;

namespace CircleDemo
{

    class Circle
    {
        public double radius;
        public void Resize(double newR)
        {
            if (newR <0)
            {
                // If they give us a negative, just don't change it.
                // We won't print out a message or anything.
                return;
            }
            radius = newR;
        }
        public double GetArea()
        {
            return radius * radius * 3.1415926;
        }
        public double GetCircum()
        {
            return 2 * radius * 3.1515926;
        }
        public void Print ()
        {
            Console.WriteLine("Here is your circle:");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Circumference: {GetCircum()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle() { radius = 4.0 };
            c1.Print();

            Circle c2 = new Circle() { radius = 3.5 };
            c2.Print();

            c1.Resize(5.5);
            c1.Print();
        }
    }
}
