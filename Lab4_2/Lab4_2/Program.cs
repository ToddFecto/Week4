using System;

namespace Lab4_2
{
    class Rectangle
    {
        // NOTES FROM THREE COMPARISON TESTS:
            //In the first comparison test the expected outcome that the areas
            //would be "Different" proved to be true since the IF statement
            //is comparing the two calculated Areas' results so mathematically
            //they are "not equal (!==)".
            //In the second comparison the expected result of both Areas' being the 
            // "Same" proved true, again because the IF is comparing them mathematically.
            //In the third comparison the expected results were what I expected them
            // to be (Results = Same) because you are writing the value of area R1
            // into R2 so it would have to be the same value and thus would mathematically
            // prove to be equal.


        public double Length;
        public double Width;

        public Rectangle(double _Length, double _Width)
        {
            Length = _Length;
            Width = _Width;
        }

        public double getLength()
        {
            return Length;
        }

        public double getWidth()
        {
            return Width;
        }


        public double GetArea()
        {
        return Length * Width;
        }

        public void Print(double areaR1, double areaR2)
        {
            if (areaR1 == areaR2)
            {
                Console.WriteLine("Area R1 and Area R2 have the 'Same' areas.");
            }
            else
            {
                Console.WriteLine("Area R1 and Area R2 have 'Different' areas.");
            }
        }

    }

    //--------------------------MenueItem Program is below this line---------------------------------------------------------------------

    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;

        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            setID(_ID);
            setName(_Name);
            setDescription(_Description);
            setPrice(_Price);
        }

        //public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        //{
        //    setID(_ID);
        //    setName(_Name);
        //    setDescription("EMPTY");
        //    setPrice(_Price);
        //}

        //// Default Constructor
        //public MenuItem()
        //{
        //    ID = 1;
        //    Name = "";
        //    Description = "";
        //    Price = 0.00m;
        //}

        public void setID(int _ID)
        {
            if (_ID < 0)
            {
                _ID = 0;
            }
            if (_ID > 100)
            {
                _ID = 100;
            }
            ID = _ID;
        }
        public void setName(string _Name)
        {
            if (_Name == "")
            {
                _Name = "EMPTY";
            }
            Name = _Name;
        }

        public void setDescription(string _Description)
        {
            if (_Description == "")
            {
                _Description = "EMPTY";
            }
            Description = _Description;
        }

        public void setPrice(decimal _Price)
        {
            if (_Price < 0.50m)
            {
                _Price = 0.50m;
            }
            if (_Price > 10.00m)
            {
                _Price = 10.00m;
            }
            Price = _Price;
        }

        public int getID()
        {
            return ID;
        }

        public string getName()
        {
            return Name;
        }

        public string getDescription()
        {
            return Description;
        }

        public decimal getPrice()
        {
            return Price;
        }

        public void Print()
        {
            Console.WriteLine("\nDetails:");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: ${Price}");
        }

        public override string ToString()
        {
            return $"\nDetails Object:\nID: {ID}\nName: {Name}\nDescription: {Description}\nPrice: ${Price}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("  Here is where the MenuItem program begins:  ");
            Console.WriteLine("============================================");

            Console.Write("\nThis is checking for condition 1 where the Name member is an empty string:");
            MenuItem mymenu1 = new MenuItem(11, "", "Turkey Sandwich", 7.50m);
            mymenu1.Print();

            Console.Write("\nThis is checking for condition 2 where the Description member is an empty string:");
            MenuItem mymenu2 = new MenuItem(11, "Turkey", "", 7.50m);
            mymenu2.Print();

            Console.Write("\nThis is checking for condition 3 where the Price member is less than $0.50 and sets it to the low limit value:");
            MenuItem mymenu3 = new MenuItem(11, "Turkey", "Turkey Sandwich", 0.49m);
            mymenu3.Print();

            Console.Write("\nThis is checking for condition 4 where the Price member is more than $10.00 and sets it to the upper limit value:");
            MenuItem mymenu4 = new MenuItem(11, "Turkey", "Turkey Sandwich", 107.50m);
            mymenu4.Print();

            Console.Write("\nThis doesn't find any issues and so it prints all values entered:");
            MenuItem mymenu5 = new MenuItem(11, "Turkey", "Turkey Sandwich", 7.50m);
            mymenu5.Print();

            Console.Write("\nThis creates an object and prints it out using the Print ToString object method:");
            string details = mymenu5.ToString();
            Console.WriteLine(mymenu5);

            /* Below is an attempt to create and use MenuItem() instance without using a default constructor.
            // It produces an error for the MenuItem() stating that "There is no argument given that corresponds
            //  to the required formal parameter '_ID' of 'MenuItem.MenuItem(int, string, string, decimal)'.
            // All of the MenuItems error because they are private and thus inaccessable without the default constructor created.
            MenuItem mymenu = new MenuItem() { ID = 1, Name = "Turkey", Description = "Turkey sandwich", Price = 7.50 };
            mymenu.Print();*/

            Console.WriteLine("\n=============================================");
            Console.WriteLine("  Here is where the Rectangle program begins:  ");
            Console.WriteLine("=============================================");

            //NOTE: Comment out/Uncomment each section to run the different cases

            // SECTION 1:
            Console.WriteLine("\n=======================================");
            Console.WriteLine("  Lengths and Widths are set not alike:  ");
            Console.WriteLine("=======================================");

            Rectangle r1 = new Rectangle(10, 200);
            Console.WriteLine($"Rectangle 1 Length: {r1.getLength()}");
            Console.WriteLine($"Rectangle 1 Width: {r1.getWidth()}");
            Console.WriteLine($"Rectangle 1 Area: {r1.GetArea()}");
            double areaR1 = r1.GetArea();

            Rectangle r2 = new Rectangle(20, 300);
            Console.WriteLine($"Rectangle 2 Length: {r2.getLength()}");
            Console.WriteLine($"Rectangle 2 Width: {r2.getWidth()}");
            Console.WriteLine($"Rectangle 2 Area: {r2.GetArea()}");
            double areaR2 = r2.GetArea();

            //SECTION 2:
            //Console.WriteLine("\n===============================================");
            //Console.WriteLine("  Lengths and Widths are set the same manually:  ");
            //Console.WriteLine("===============================================");

            //Rectangle r1 = new Rectangle(10, 200);
            //Console.WriteLine($"Rectangle 1 Length: {r1.getLength()}");
            //Console.WriteLine($"Rectangle 1 Width: {r1.getWidth()}");
            //Console.WriteLine($"Rectangle 1 Area: {r1.GetArea()}");
            //double areaR1 = r1.GetArea();

            //Rectangle r2 = new Rectangle(10, 200);
            //Console.WriteLine($"Rectangle 2 Length: {r2.getLength()}");
            //Console.WriteLine($"Rectangle 2 Width: {r2.getWidth()}");
            //Console.WriteLine($"Rectangle 2 Area: {r2.GetArea()}");
            //double areaR2 = r2.GetArea();

            //SECTION 3:
            //Console.WriteLine("\n=======================================================");
            //Console.WriteLine("  Lengths and Widths are set the same using assignment:  ");
            //Console.WriteLine("=======================================================");

            //Rectangle r1 = new Rectangle(30, 300);
            //Console.WriteLine($"Rectangle 1 Length: {r1.getLength()}");
            //Console.WriteLine($"Rectangle 1 Width: {r1.getWidth()}");
            //Console.WriteLine($"Rectangle 1 Area: {r1.GetArea()}");
            //double areaR1 = r1.GetArea();
            //Rectangle r2 = r1;

            // Results of the comparison are printed out here
            Console.WriteLine("\n===========================================================");
            Console.Write("Here is the comparison results between R1 and R2: ");

            if (r1 == r2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.WriteLine("===========================================================");
        }
    }
}
