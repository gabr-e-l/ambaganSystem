using System;
using System.Collections.Generic;
using AmbaganBusinessDataLogic;
using DataLayer;
using AmbagCommon;

namespace ambaganSystem
{
    internal class Program
    {
        static string[] make = new string[] { "\n[1] Creat List", "[2] View Lists", "[3] Remove Function", "[4] Search Records", "[5] Logout" };
        
        static char chooseAgain = 'Y', addAgain = 'Y';

        public static void Main(string[] args)
        {
            OfficerAccountsService accountService = new OfficerAccountsService();
            string accountNumber, userPin, officerPosition;
            
            do
            {
                Console.WriteLine("\n-------------------------");
                Console.Write("Enter Account Number: ");
                accountNumber = Console.ReadLine();

                Console.Write("Enter a PIN: ");
                userPin = Console.ReadLine();

                officerPosition = accountService.GetOfficerPosition(accountNumber);

                if (!accountService.ValidateAccount(accountNumber, userPin))
                {
                    Console.WriteLine("\nIncorrect Credentials! Please try again.");
                }

            } while (!accountService.ValidateAccount(accountNumber, userPin));

            Console.WriteLine("\nLogin Successful");

                while (chooseAgain == 'Y')
                {
                    showMenu(officerPosition);
                    int options = toDo();

                    if (officerPosition == "Treasurer")
                    {
                        if (options == 1)
                        {
                            createList();
                        }

                        else if (options == 2)
                        {
                            viewList();
                        }

                        else if (options == 3)
                        {
                            removeFromList();
                        }

                        else if (options == 4)
                        {
                            searchRecords();
                        }

                        else if (options == 5)
                        {
                            Console.WriteLine("\nAccount Closed.");
                                Main(args);
                                break;
                        }

                        else
                        {
                            Console.WriteLine("\nInvalid Case!");
                        }
                    } 
                
                    else
                    {
                        if (options == 1)
                        {
                            viewList();
                        }

                        else if (options == 2)
                        {
                            searchRecords();
                        }

                        else if (options == 3)
                        {
                            Console.WriteLine("\nAccount Closed.");
                                Main(args);
                                break;
                        }
                    }

                    Console.Write("\n-------------------------");
                    Console.Write("\nBack to Main Menu? (Y/N): ");
                    chooseAgain = char.ToUpper(Console.ReadLine()[0]);
                } 
        }


        static void showMenu(string officerPosition)
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("~ Main Menu ~");

            if (officerPosition == "Treasurer")
            {
                foreach (var mk in make)
                {
                    Console.WriteLine(mk);
                }
            }
            else
            {
                Console.WriteLine("[1] View\n" +
                                  "[2] Search Records\n" +
                                  "[3] Logout");
            }
        }


        static int toDo()
        {
            Console.Write("To Do: ");
            int options = Convert.ToInt16(Console.ReadLine());

            return options;
        }


        static void createList()
        {
            Console.Write("\nEnter List Name: ");
            string listName = Console.ReadLine().ToLower();

            Console.WriteLine("\n-------------------------");
            Console.Write("Set an Amount: ");
            double set = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("\n-------------------------");
                Console.Write("Enter a Name: ");
                string name = Console.ReadLine().ToLower();

                Console.Write("Enter an Amount: ");
                double amnt = Convert.ToDouble(Console.ReadLine());

                while (amnt < set)
                {
                    Console.WriteLine("\nGiven amount can't be smaller than ambagan.");

                    Console.Write("\nEnter an Amount: ");
                    amnt = Convert.ToDouble(Console.ReadLine());
                }

                AmbaganProcesses.UpdateList(listName, set, name, amnt);

                Console.WriteLine("\nAmbag Added!");

                Console.Write("\nAdd another Ambag? (Y/N): ");
                addAgain = char.ToUpper(Console.ReadLine()[0]);

            } while (addAgain == 'Y');
        }


        static void viewList()
        {
            DisplayListNames();
       
            Console.Write("\nEnter list name to view: ");
            string listName = Console.ReadLine().ToLower();

            DisplayAmbags(listName);
        }


        static void removeFromList()
        {
            DisplayListNames();

            Console.Write("\nEnter the list name: ");
            string listName = Console.ReadLine().ToLower();

            Console.Write("\nDelete a Name (N) or Delete the List (L)? (N/L): ");
            char deleteNL = char.ToUpper(Console.ReadLine()[0]);

            if (deleteNL == 'L')
            {
                if (AmbaganProcesses.RemoveWholeList(listName))
                {
                    Console.WriteLine($"\nList '{listName}' has been deleted.");
                }
                else
                {
                    Console.WriteLine("\nList not found or already removed.");
                }

            }
            else if (deleteNL == 'N')
            {
                DisplayAmbags(listName);

                do
                {
                    Console.Write("\nEnter a Name to Remove: ");
                    string reName = Console.ReadLine().ToLower();

                    if (AmbaganProcesses.RemoveNameFromList(reName, listName))
                    {
                        Console.WriteLine($"\n{reName} was removed from the list.");
                    }
                    else
                    {
                        Console.WriteLine($"\n{reName} is not in the list.");
                    }

                    Console.Write("\nFind another person? (Y/N): ");
                    addAgain = char.ToUpper(Console.ReadLine()[0]);

                } while (addAgain == 'Y');
            }
        }


        static void DisplayAmbags(string listName)
        {
            var entries = AmbaganProcesses.GetListEntries(listName);

            if (entries.Count == 0)
            {
                Console.WriteLine("\nList not found or empty!");
                return;
            }

            Console.WriteLine("\n-------------------------\nList of Ambags:");

            foreach (var entry in entries)
            {
                Console.WriteLine($"Name: {entry.Name}, Bigay: {entry.AmountGiven}, " +
                                  $"Ambag: {entry.SetAmount}, Sukli: {entry.Change}");
            }

            ManageTotals(entries);
        }


        static void ManageTotals(List<AmbagCommon.AmbagData.AmbagEntry> entries)
        {
            var listTotals = AmbaganProcesses.CalculateTotals(entries);

            Console.WriteLine($"\nTotal Bigay: {listTotals.TotalGiven}\n" +
                              $"Total Ambag: {listTotals.TotalSet}\n" +
                              $"Total Sukli: {listTotals.TotalChange}");
        }


        static void DisplayListNames()
        {
            var listNames = AmbaganProcesses.GetListNames();

            if (listNames.Count == 0)
            {
                Console.WriteLine("\nNo lists available.");
                return;
            }

            Console.WriteLine("\n-------------------------");
            Console.WriteLine("\nAvailable Lists:");
            foreach (var list in listNames)
            {
                Console.WriteLine($"- {list}");
            }
        }

        static void searchRecords()
        {
            Console.WriteLine("\nEnter a Name to Search: ");
            string searchName = Console.ReadLine().ToLower();

            var allRecords = AmbaganProcesses.GetAllRecords(searchName);

            if (allRecords.Count == 0)
            {
                Console.WriteLine("\nNo Records Found");
            }

            else
            {
                Console.WriteLine($"\nRecords of '{searchName}':");

                foreach (var record in allRecords)
                {
                    Console.WriteLine($"List: {record.ListName}, Name: {record.Name}, Given: {record.AmountGiven}, " +
                                      $"Set: {record.SetAmount}, Change: {record.Change}");
                }
            }
        }


    }
}
