using System;

namespace Lab4_1
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
            return 2 * Length + 2 * Width;
        }

        public void Print()
        {
            Console.WriteLine("Here are the Parellogram properties:");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Circumference: {GetPerimeter()}");
        }

        public void Resize(double newL, double newW)
        {
            if (newL < 0 || newW < 0)
            {
                return;
            }
            Length = newL;
            Width = newW;
        }
        class Program
        {
            static void Main(string[] args)
            {

                string lengthNew = "";
                string widthNew = "";
                double newL = 0;
                double newW = 0;

                Console.WriteLine("Here are P1's details using initial preset Length and Width:");
                Parallelogram p1 = new Parallelogram() { Length = 10.0, Width = 25 };
                p1.Print();

                Console.Write("Please enter a new P1 Length: ");
                lengthNew = Console.ReadLine();
                double.TryParse(lengthNew, out newL);

                Console.Write("Please enter a new P1 Width: ");
                widthNew = Console.ReadLine();
                double.TryParse(widthNew, out newW);

                Console.WriteLine("Here are P1's resized details, after user input for Length and Width:");
                p1.Resize(newL, newW);
                p1.Print();

                Console.WriteLine("Here are P2's details using initial preset Length and Width:");
                Parallelogram p2 = new Parallelogram() { Length = 30.0, Width = 50 };
                p2.Print();

                Console.Write("Please enter a new P2 Length: ");
                lengthNew = Console.ReadLine();
                double.TryParse(lengthNew, out newL);

                Console.Write("Please enter a new P2 Width: ");
                widthNew = Console.ReadLine();
                double.TryParse(widthNew, out newW);

                Console.WriteLine("Here are P2's resized details, after user input for Length and Width:");
                p2.Resize(newL, newW);
                p2.Print();
            }
        }
    }
}
