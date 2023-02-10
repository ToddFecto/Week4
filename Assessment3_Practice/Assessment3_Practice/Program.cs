using System;
using System.Collections.Generic;

namespace Assessment3_Practice
{
    class Pants
    {
        private string prStyle;
        private List<int> prSizes;

        public Pants(string _Style, List<int> _Sizes)
        {
            SetStyle(_Style);
            //prSizes = _Sizes;
            SetSizes(_Sizes);
        }

        public string GetStyle()
        {
            return prStyle;
        }

        public void SetStyle(string _Style)
        {
            prStyle = _Style;
        }

        //public int GetSizes()
        //{
        //   return List<int> prSizes;
        //}

        public void SetSizes(List<int> _Sizes)
        {
            prSizes = _Sizes;
        }

        public override string ToString()
        {
            string sizesList = "";
            foreach (var size in prSizes)
            {
                sizesList = sizesList + prSizes + ", ";
            }
            return $"The style is: {prStyle} and it comes in sizes {prSizes}";
        }

    }
    class Program
    {
        static bool searchLookups()
        {
            while (true)
            {
                Console.Write("\n\nContinue searching? (y/n): ");              //Prompts for user input to continue or not
                string moreLookups = Console.ReadLine();
                moreLookups = moreLookups.ToLower();                           //Converts input case to only lower case

                if (moreLookups == "y" || moreLookups == "yes")                //Checks the condition to continue searching customer info or quit
                {
                    return true;
                }
                else if (moreLookups == "n" || moreLookups == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }
        static void ListPants(List<Pants> pantsList)
        {
            foreach (Pants next in pantsList)
            {
                Console.WriteLine(next);
            }
        }


        static void Main(string[] args)
        {
            do    // Starts the searchLoops method to keep menu going or to exit completely
            {
                List<Pants> pantsList = new List<Pants>();

                List<int> chinoSizes = new List<int> { 30, 32, 34, 38, 40 };

                Console.WriteLine(String.Join(" ", chinoSizes));

                Pants chinoStyle = new Pants(_Style: "Chinos", chinoSizes);

                List<int> capriSizes = new List<int> { 4, 6, 8, 10, 12, 14, 16 };
                Pants capriStyle = new Pants(_Style: "Capris", capriSizes);

                List<int> khakiSizes = new List<int> { 28, 30, 32, 34, 36, 38, 40 };
                Pants khakiStyle = new Pants(_Style: "Khakis", khakiSizes);

                List<int> sweatsSizes = new List<int> { 8, 12, 16, 28, 32, 36, 40 };
                Pants sweatsStyle = new Pants(_Style: "SweatPants", sweatsSizes);

                pantsList.Add(chinoStyle);
                pantsList.Add(capriStyle);
                pantsList.Add(khakiStyle);
                pantsList.Add(sweatsStyle);

                Dictionary<string, string> actions = new Dictionary<string, string>();
                actions.Add("Add A Pair Of Pants       ", "A");
                actions.Add("Check Pants Availablity   ", "B");
                actions.Add("Delete A Pair of Pants    ", "C");
                actions.Add("List Pants In Inventory   ", "D");
                actions.Add("Quit                      ", "Q");

                Console.WriteLine("======================");
                Console.WriteLine("Welcome to Pants World");
                Console.WriteLine("======================");

                string choice;
                do
                {
                    Console.WriteLine("\nPlease choose an option from our system menu:");
                    foreach (var pair in actions)
                    {
                        Console.WriteLine($"To {pair.Key} press\t'{pair.Value}'");
                    }
                    Console.Write("\nEnter choice: ");
                    choice = Console.ReadLine().ToLower();
                } while (choice != "a" && choice != "b" && choice != "c" && choice != "d" && choice != "q");

                if (choice == "d")
                {
                    Console.WriteLine("Here is the inventory list:\n");
                    ListPants(pantsList);
                }
                else if (choice == "c")
                {
                    Console.WriteLine("\nYou chose to delete a pants style.");
                    bool menuCancel = true;
                    while (menuCancel)
                    {
                        Console.Write("Enter the pants style to delete (or type CANCEL to return to the main menu): ");
                        string delPants = Console.ReadLine();
                        theCustomer = SearchForCompany(pants, delPants);

                        if (compLookup == "CANCEL")         // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            menuCancel = false;             // Changed menuCancel state so that it breaks out of the while {menuCancel loop below
                        }
                        else
                        {
                            if (theCustomer != null)
                            {
                                Console.WriteLine("\nFound that company! Below is the customer information:");
                                Console.WriteLine(theCustomer);
                                menuCancel = false;
                            }
                            else
                            {
                                Console.WriteLine("\nThat company was not found!\n");
                            }
                        }
                    }
                }
            } while (searchLookups());
        }
    }
}
