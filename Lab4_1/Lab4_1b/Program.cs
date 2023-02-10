using System;

namespace Lab4_1b
{
    class Book
    {
        public string lastName;
        public string firstName;
        public string Title;
        public string ISBN;
        public string pubName;
        public int copiesSold;

        public void Sell(int curSold, int newSales)
        {
            copiesSold = curSold + newSales;
        }
        public void Print()
        {
            Console.WriteLine($"Author: {firstName} {lastName}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publisher: {pubName}");
            Console.WriteLine($"Copies sold: {copiesSold}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string newSold = "";
            int newSales = 0;
            int curSold = 0;

            Book b1 = new Book() { lastName = "Rowling", firstName = "J.K.", Title = "Harry Potter and the Sorcerer's Stone", ISBN = "9780439554930", pubName = "Bloomsbury Publishing", copiesSold = 120000000 };
            Console.WriteLine($"Here are the details for the book {b1.Title}:\n");
            b1.Print();

            Console.Write($"\nEnter the number of NEW COPIES sold for {b1.Title}: ");
            newSold = Console.ReadLine();
            int.TryParse(newSold, out newSales);
            curSold = b1.copiesSold;
            Console.WriteLine($"\nYou entered new sales of {b1.Title} = {newSales} books.");
            b1.Sell(curSold, newSales);

            Console.WriteLine($"\nHere are the updated details for {b1.Title}:\n");
            b1.Print();


            Book b2 = new Book() { lastName = "Rowling", firstName = "J.K.", Title = "Harry Potter and the Chamber of Secrets", ISBN = "9780439064873", pubName = "Bloomsbury Publishing", copiesSold = 77000000 };
            Console.WriteLine($"Here are the details for the book {b2.Title}:\n");
            b2.Print();

            Console.Write($"\nEnter the number of NEW COPIES sold for {b2.Title}: ");
            newSold = Console.ReadLine();
            int.TryParse(newSold, out newSales);
            curSold = b2.copiesSold;
            Console.WriteLine($"\nYou entered new sales of {b2.Title} = {newSales} books.");
            b2.Sell(curSold, newSales);

            Console.WriteLine($"\nHere are the updated details for {b2.Title}:\n");
            b2.Print();


            Book b3 = new Book() { lastName = "Rowling", firstName = "J.K.", Title = "Harry Potter and the Prisoner of Azkaban", ISBN = "9780439136358", pubName = "Bloomsbury Publishing", copiesSold = 65000000 };
            Console.WriteLine($"Here are the details for the book {b3.Title}:\n");
            b3.Print();

            Console.Write($"\nEnter the number of NEW COPIES sold for {b3.Title}: ");
            newSold = Console.ReadLine();
            int.TryParse(newSold, out newSales);
            curSold = b3.copiesSold;
            Console.WriteLine($"\nYou entered new sales of {b3.Title} = {newSales} books.");
            b3.Sell(curSold, newSales);

            Console.WriteLine($"\nHere are the updated details for {b3.Title}:\n");
            b3.Print();


            Book b4 = new Book() { lastName = "Rowling", firstName = "J.K.", Title = "Harry Potter and the Goblet of Fire", ISBN = "9781408855928", pubName = "Bloomsbury Publishing", copiesSold = 65000000 };
            Console.Write($"\nEnter the number of NEW COPIES sold for {b4.Title}: ");
            newSold = Console.ReadLine();
            int.TryParse(newSold, out newSales);
            curSold = b4.copiesSold;
            Console.WriteLine($"\nYou entered new sales of {b4.Title} = {newSales} books.");
            b4.Sell(curSold, newSales);

            Console.WriteLine($"\nHere are the updated details for {b4.Title}:\n");
            b4.Print();

            Book b5 = new Book() { lastName = "Rowling", firstName = "J.K.", Title = "Harry Potter and the Order of the Phoenix", ISBN = "9780439567626", pubName = "Bloomsbury Publishing", copiesSold = 65000000 };
            Console.Write($"\nEnter the number of NEW COPIES sold for {b5.Title}: ");
            newSold = Console.ReadLine();
            int.TryParse(newSold, out newSales);
            curSold = b5.copiesSold;
            Console.WriteLine($"\nYou entered new sales of {b5.Title} = {newSales} books.");
            b5.Sell(curSold, newSales);

            Console.WriteLine($"\nHere are the updated details for {b5.Title}:\n");
            b5.Print();

            Book b6 = new Book() { lastName = "Rowling", firstName = "J.K.", Title = "Harry Potter and the Half-Blood Prince", ISBN = "9780439784542", pubName = "Bloomsbury Publishing", copiesSold = 65000000 };
            Console.Write($"\nEnter the number of NEW COPIES sold for {b6.Title}: ");
            newSold = Console.ReadLine();
            int.TryParse(newSold, out newSales);
            curSold = b6.copiesSold;
            Console.WriteLine($"\nYou entered new sales of {b6.Title} = {newSales} books.");
            b6.Sell(curSold, newSales);

            Console.WriteLine($"\nHere are the updated details for {b6.Title}:\n");
            b6.Print();

            Book b7 = new Book() { lastName = "Rowling", firstName = "J.K.", Title = "Harry Potter and the Deathly Hallows", ISBN = "9780545010221", pubName = "Bloomsbury Publishing", copiesSold = 65000000 };
            Console.Write($"\nEnter the number of NEW COPIES sold for {b7.Title}: ");
            newSold = Console.ReadLine();
            int.TryParse(newSold, out newSales);
            curSold = b7.copiesSold;
            Console.WriteLine($"\nYou entered new sales of {b7.Title} = {newSales} books.");
            b7.Sell(curSold, newSales);

            Console.WriteLine($"\nHere are the updated details for {b7.Title}:\n");
            b7.Print();
        }
    }
}
