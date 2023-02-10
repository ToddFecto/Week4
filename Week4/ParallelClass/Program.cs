using System;

namespace ParallelClass
{
    class Program
    {
        class Parallelogram
        {
            public double Length;
            public double Width;

            public double GetArea()
            {
                return Length * Width;
            }

            public double GetPerimeter()
            {
                return Length + Length + Width + Width;
            }

            public void Print()
            {
                Console.WriteLine("Here is your Parallelogram:");
                Console.WriteLine($"Length: {Length}, Width: {Width}");
                Console.WriteLine($"Area: {GetArea()}, Perimeter: {GetPerimeter()}");
            }

            public void Resize(double _Length, double _Width)
            {
                if (Length >= 0 && Width >= 0)
                {
                    Length = _Length;
                    Width = _Width;
                }

            }

        }


        static void Main(string[] args)
        {
            Parallelogram p1 = new Parallelogram() { Length = 20.5, Width = 30.2 };
            //Console.WriteLine(p1.GetArea());
            //Console.WriteLine(p1.GetPerimeter());
            p1.Print();

            p1.Resize(11, 20);
            p1.Print();
        }
    }
}
