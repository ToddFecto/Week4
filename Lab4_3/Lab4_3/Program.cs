using System;
using System.Collections.Generic;
namespace Lab4_3
{
    class Customer
    {
        private string prCompany;
        private string prContactName;
        private string prContactEmail;
        private string prPhone;

        public Customer(string _Company, string _ContactName, string _ContactEmail, string _Phone)
        {
            SetCompany(_Company);
            SetContactName(_ContactName);
            SetContactEmail(_ContactEmail);
            SetPhone(_Phone);
        }
        public string GetCompany()
        {
            return prCompany;
        }

        public void SetCompany(string _Company)
        {
            prCompany = _Company;
        }

        public string GetContactName()
        {
            return prContactName;
        }

        public void SetContactName(string _ContactName)
        {
            prContactName = _ContactName;
        }

        public string GetContactEmail()
        {
            return prContactEmail;
        }

        public void SetContactEmail(string _ContactEmail)
        {
            prContactEmail = _ContactEmail;
        }

        public string GetPhone()
        {
            return prPhone;
        }

        public void SetPhone(string _Phone)
        {
            prPhone = _Phone;
        }

        public override string ToString()
        {
            return $" Company: {prCompany}\n Name:   {prContactName}\n Email:  {prContactEmail}\n Phone:  {prPhone}\n";
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
        static void ListCustomers(List<Customer> customerlist)                 // Does a complete list of all information
        {
            foreach (Customer next in customerlist)
            {
                Console.WriteLine(next);
            }
        }

        static Customer SearchForCompany(List<Customer> customerlist, string _Company)  // Does a search based on company name
        {
            foreach (Customer next in customerlist)
            {
                if (next.GetCompany() == _Company)
                {
                    return next;
                }
            }
            return null;
        }

        static Customer SearchForContact(List<Customer> customerlist, string _Contactname)  // Does a search based on customer/contact name
        {
            foreach (Customer next in customerlist)
            {
                if (next.GetContactName() == _Contactname)
                {
                    return next;
                }
            }
            return null;
        }

        static Customer SearchForPhone(List<Customer> customerlist, string _Phone)  // Does a search by phone number
        {
            foreach (Customer next in customerlist)
            {
                if (next.GetPhone() == _Phone)
                {
                    return next;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            do    // Starts the searchLoops method to keep menu going or to exit completely
            {

                List<Customer> customers = new List<Customer>();

                Customer theCustomer = new Customer("Microsoft", "Tom Brady", "tombrady@microsoft.com", "440-555-1234");
                customers.Add(theCustomer);

                theCustomer = new Customer("Oracle", "Steve Young", "steveyoung@oracle.com", "501-232-6789");
                customers.Add(theCustomer);

                theCustomer = new Customer("Amazon", "Aaron Rogers", "aaronrogers@amazon.com", "216-333-4567");
                customers.Add(theCustomer);

                theCustomer = new Customer("Google", "Joe Montana", "joemontana@google.com", "802-255-5432");
                customers.Add(theCustomer);


                Dictionary<string, string> actions = new Dictionary<string, string>();
                actions.Add("List All Customers   ", "A");
                actions.Add("Search By Company    ", "B");
                actions.Add("Search By Customer   ", "C");
                actions.Add("Search By Phone#     ", "D");
                actions.Add("Quit                 ", "Q");

                Console.WriteLine("====================");
                Console.WriteLine("Welcome to the CMS!");
                Console.WriteLine("====================");

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

                    if (choice == "a")
                    {
                        Console.WriteLine("Here is the customer list:\n");
                        ListCustomers(customers);
                    }
                    else if (choice == "b")
                    {
                        bool menuCancel = true;
                        while (menuCancel)
                        {
                            Console.Write("\nEnter a company name to look up (or type CANCEL to return to the main menu): ");
                            string compLookup = Console.ReadLine();
                            theCustomer = SearchForCompany(customers, compLookup);

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
                    else if (choice == "c")
                    {
                        bool menuCancel = true;
                        while (menuCancel)
                        {
                            Console.Write("\nEnter a customer name to look up (or type CANCEL to return to the main menu): ");
                            string custLookup = Console.ReadLine();
                            theCustomer = SearchForContact(customers, custLookup);

                            if (custLookup == "CANCEL")
                            {
                                Console.WriteLine("You chose to Cancel this action and start again.");
                                menuCancel = false;
                            }
                            else
                            {
                                if (theCustomer != null)
                                {
                                    Console.WriteLine("\nFound that customer! Below is the customer information:");
                                    Console.WriteLine(theCustomer);
                                    menuCancel = false;
                            }
                                else
                                {
                                    Console.WriteLine("\nThat customer was not found!\n");
                                }
                            }
                        }
                    }
                    else if (choice == "d")
                    {
                        bool menuCancel = true;
                        while (menuCancel)
                        {
                            Console.Write("\nEnter a phone number to look up (or type CANCEL to return to the main menu): ");
                            string phoneLookup = Console.ReadLine();
                            theCustomer = SearchForPhone(customers, phoneLookup);

                            if (phoneLookup == "CANCEL")
                            {
                                Console.WriteLine("You chose to Cancel this action and start again.");
                                menuCancel = false;
                            }
                            else
                            {
                                if (theCustomer != null)
                                {
                                    Console.WriteLine("\nFound that phone number! Below is the customer information:");
                                    Console.WriteLine(theCustomer);
                                    menuCancel = false;
                            }
                                else
                                {
                                    Console.WriteLine("\nThat phone number was not found!\n");
                                    Console.WriteLine("Be sure that you entered it in this format: 111-222-3333");
                                }
                            }
                        }
                    }
                    else if (choice == "q")
                    {
                        // Added prompts so "Logic" for searchLookups would be correct to exit menu completely or continue
                        Console.WriteLine("You chose to Quit.");
                        Console.WriteLine("Please confirm choice: Continue searching? (Y) or (N)?");
                    }
            }while (searchLookups());

            Console.WriteLine("Thank you for stopping by!!");
        }
    }
}

