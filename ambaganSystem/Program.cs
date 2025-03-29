using System;
using System.Collections.Generic;
using AmbaganBusinessDataLogic;

namespace ambaganSystem
{
    internal class Program
    {
        static string[] make = new string[] { "\n[1] List", "[2] View", "[3] Remove" };
        
        static char chooseAgain = 'Y', addAgain = 'Y';

        public static void Main(string[] args)
        {
            int pass = 0;
            
            do
            {
                Console.Write("Enter a Pin: ");
                pass = Convert.ToInt16(Console.ReadLine());

                if (!AmbaganProcesses.VerifyPIN(pass))
                {
                    Console.WriteLine("\nIncorrect Pin! Please try again.");
                }

            } while (!AmbaganProcesses.VerifyPIN(pass));

            Console.WriteLine("\nLogin Successful");

                while (chooseAgain == 'Y')
                {
                    showMenu();
                    int options = toDo();

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

                    else
                    {
                        Console.WriteLine("\nInvalid Case!");
                    }

                    Console.Write("\n-------------------------");
                    Console.Write("\nBack to Main Menu? (Y/N): ");
                    chooseAgain = char.ToUpper(Console.ReadLine()[0]);
                } 
        }


        static void showMenu()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("~ Main Menu ~");
            foreach (var mk in make)
            {
                Console.WriteLine(mk);
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

            if (!AmbaganProcesses.ambags.ContainsKey(listName))
            {
                Console.WriteLine($"Created new list: {listName}");
            }

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

            if (AmbaganProcesses.ambags[listName].Count == 0)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("List not found.");
            }

            Console.Write("\nDelete a Name (N) or Delete the List (L)? (N/L): ");
            char deleteNL = char.ToUpper(Console.ReadLine()[0]);

            if (deleteNL == 'L')
            {
                if (AmbaganProcesses.RemoveList(listName))
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
                    Console.WriteLine("\n-------------------------");
                    Console.Write("Enter a Name to Remove: ");
                    string reName = Console.ReadLine().ToLower();

                    var toRemove = AmbaganProcesses.ambags[listName].FindIndex(ntr => ntr.Item2 == reName);
                    if (AmbaganProcesses.RemoveName(reName, listName))
                    {
                        
                        if (toRemove != -1)
                        {
                            AmbaganProcesses.ambags[listName].RemoveAt(toRemove);
                            Console.WriteLine($"\n{reName} was removed from the list");
                            
                        }
                    }
                    else {
                        Console.WriteLine($"\n{reName} is not in the list");
                    }

                    Console.Write("\nFind another person? (Y/N): ");
                    addAgain = char.ToUpper(Console.ReadLine()[0]);

                } while (addAgain == 'Y');
            }
        }



        static void DisplayAmbags(string listName)
        {
            if (!AmbaganProcesses.ambags.ContainsKey(listName))
            {
                Console.WriteLine("List not found!");
                return;
            }

            if (AmbaganProcesses.ambags.Count > 0)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine($"Ambagan: {AmbaganProcesses.ambags[listName][0].Item1}");
                Console.WriteLine("\nList of Ambags: ");

                foreach (var ambs in AmbaganProcesses.ambags[listName])
                {
                    Console.WriteLine($"Name: {ambs.Item2}, Bigay: {ambs.Item3}, " +
                                     $"Ambag: {ambs.Item4}, Sukli: {ambs.Item5}");
                }
                ManageTotals(listName);
            }
            else
            {
                Console.WriteLine("\nThere are no available lists.");
            }
        }


        static void ManageTotals(string listName)
        {
            double tAmnt = 0, tSet = 0, tChng = 0;
            foreach (var ambs in AmbaganProcesses.ambags[listName])
            {
                tAmnt += ambs.Item3;
                tSet += ambs.Item4;
                tChng += ambs.Item5;
            }

            Console.WriteLine($"\nTotal Bigay: {tAmnt}");
            Console.WriteLine($"Total Ambag: {tSet}");
            Console.WriteLine($"Total Sukli: {tChng}");
        }


        static void DisplayListNames()
        {
            if (AmbaganProcesses.ambags.Count == 0)
            {
                Console.WriteLine("\nNo lists available.");

                Console.Write("\nBack to Main Menu? (Y/N): ");
                chooseAgain = char.ToUpper(Console.ReadLine()[0]);

                if (chooseAgain == 'Y')
                {
                    showMenu();
                    toDo();
                }
            }

            else
            { 
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("\nAvailable Lists:");
                foreach (var list in AmbaganProcesses.ambags.Keys)
                {
                    Console.WriteLine($"- {list}");
                }
                return;
            }
            
        }


    }
}
