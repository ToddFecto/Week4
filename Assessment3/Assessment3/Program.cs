using System;
using System.Collections.Generic;
namespace Assessment3
{
    class SiftMember
    {
        private string prName;
        private string prAnniversaryDate;
        private string prTitle;
        private string prEmail;
        private string prListOfSkills;

        public SiftMember(string _Name, string _AnniversaryDate, string _Title, string _Email, string _ListOfSkills)
        {
            SetName(_Name);
            SetAnniversaryDate(_AnniversaryDate);
            SetTitle(_Title);
            SetEmail(_Email);
            SetListOfSkills(_ListOfSkills);
        }

        public string GetName()
        {
            return prName;
        }
        public void SetName(string _Name)
        {
            prName = _Name;
        }
        public string GetprAnniversaryDate()
        {
            return prAnniversaryDate;
        }

        public void SetAnniversaryDate(string _AnniversaryDate)
        {
            prAnniversaryDate = _AnniversaryDate;
        }

        public string GetTitle()
        {
            return prTitle;
        }
        public void SetTitle(string _Title)
        {
            prTitle = _Title;
        }
        public string GetEmail()
        {
            return prEmail;
        }

        public void SetEmail(string _Email)
        {
            prEmail = _Email;
        }

        public string GetListOfSkills()
        {
            return prEmail;
        }

        public void SetListOfSkills(string _ListOfSkills)
        {
            prListOfSkills = _ListOfSkills;
        }

        public override string ToString()
        {
            return $" Name: {prName}\n Anniversary :   {prAnniversaryDate}\n Title: {prTitle}\n Email:  {prEmail}\n Skills:  {prListOfSkills}\n";
        }
    }

    class Program
    {
        static bool searchLookups()
        {
            while (true)
            {
                Console.Write("\n\nContinue using Sift? (y/n): ");              //Prompts for user input to continue or not
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
        static void ListSift(List<SiftMember> siftlist)                 // Does a complete list of all information
        {
            foreach (SiftMember next in siftlist)
            {
                Console.WriteLine(next);
            }
        }

        static SiftMember SearchForName(List<SiftMember> siftlist, string _Name)  // Does a search based on company name
        {
            foreach (SiftMember next in siftlist)
            {
                if (next.GetName() == _Name)
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

            List<SiftMember> siftlist = new List<SiftMember>();

            SiftMember theName = new SiftMember("Todd Fecto", "AnnivDate 02172020", "Associate Software Engineer", "toddfecto@rocketmortgage.com", "C#, Java, JavaScript, bowling, running");
            siftlist.Add(theName);

            theName = new SiftMember("Jeff Metzner", "AnnivDate 01012015", "Associate Software Engineer", "jeffmetzner@rocketmortgage.com", "C#, Windows 10, Azure");
            siftlist.Add(theName);

            Dictionary<string, string> actions = new Dictionary<string, string>();
            actions.Add("Add a Team Member                      ", "A");
            actions.Add("Search for a Team Member and Add Skills", "B");
            actions.Add("List all Team Members                  ", "C");
            actions.Add("Quit                                   ", "Q");

            Console.WriteLine("================");
            Console.WriteLine("Welcome to Sift!");
            Console.WriteLine("================");

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
                    Console.WriteLine("\nYou chose to add a new sift member.");

                    bool menuCancel = true;
                    while (menuCancel)
                    {
                        Console.Write("\nEnter the new member name (or type CANCEL to return to the main menu): ");
                        string addSift = Console.ReadLine();
                        theName = SearchForName(siftlist, addSift);

                        if (addSift == "CANCEL")
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            menuCancel = false;
                        }
                        else
                        {
                            if (siftlist != null)
                            {
                                Console.WriteLine("\nFound that customer! Below is the customer information:");
                                Console.WriteLine(theName);
                                Console.WriteLine("\nPlease try another name!");
                                menuCancel = false;
                            }
                            else
                            {
                                Console.Write("\nEnter anniversary date: \n");
                                string addAnnDate = Console.ReadLine();
                                Console.Write("\nEnter Title: ");
                                string addTitle = Console.ReadLine();
                                Console.Write("\nEmail address: ");
                                string addEmail = Console.ReadLine();
                                Console.Write("\nEnter some skills: ");
                                string addSkills = Console.ReadLine();
                                theName = new SiftMember(addSift, addAnnDate, addTitle, addEmail, addSkills);
                                siftlist.Add(theName);
                                ListSift(siftlist);
                            }
                        }
                    }
                }

                else if (choice == "b")
                {
                    bool menuCancel = true;
                    while (menuCancel)
                    {
                        Console.Write("\nEnter a member to add skills to (or type CANCEL to return to the main menu): ");
                        string updSkills = Console.ReadLine();
                        theName = SearchForName(siftlist, updSkills);

                        if (updSkills == "CANCEL")
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            menuCancel = false;
                        }
                        else
                        {
                            if (theName != null)
                            {
                                Console.WriteLine("\nFound that customer! Below is the customer information:");
                                Console.WriteLine(theName);
                                Console.Write("\nEnter some skills: ");
                                string addSkills = Console.ReadLine();
                                //theName = new SiftMember(updSkills, addAnnDate, addTitle, addEmail, addSkills);
                                siftlist.Add(theName);
                                ListSift(siftlist);
                            }
                            else
                            {
                                Console.WriteLine("\nThat customer was not found!\n");
                            }
                        }
                    }
                }

                //else if
                if (choice == "c")
                {
                    Console.WriteLine("Here is the customer list:\n");
                    ListSift(siftlist);
                }
                else if (choice == "q")
                {
                // Added prompts so "Logic" for searchLookups would be correct to exit menu completely or continue
                Console.WriteLine("You chose to Quit.");
                Console.WriteLine("Please confirm choice: Continue using Sift? (Y) or (N)?");
                }
        }while (searchLookups());

            Console.WriteLine("Thank you for stopping by!!");
            //ListSift(siftlist);
        }
    }
}
