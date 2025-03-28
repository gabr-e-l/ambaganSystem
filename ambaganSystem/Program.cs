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
            Console.WriteLine("\n-------------------------");
            Console.Write("Set an Amount: ");
            double set = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.WriteLine("\n-------------------------");
                Console.Write("Enter a Name: ");
                string name = Console.ReadLine().ToLower();

                Console.Write("Enter an Amount: ");
                double amnt = Convert.ToInt16(Console.ReadLine());

                AmbaganProcesses.VerifySetAmount(set, amnt);
                AmbaganProcesses.UpdateList(set, name, amnt);

                Console.WriteLine("\nAmbag Added!");

                Console.Write("\nAdd another Ambag? (Y/N): ");
                addAgain = char.ToUpper(Console.ReadLine()[0]);

            } while (addAgain == 'Y');
        }

        static void viewList()
        {
            AmbaganProcesses.DisplayAmbags();
        }

        static void removeFromList()
        {
            if (AmbaganProcesses.ambags.Count == 0)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("There are no available list.");
                return;
            }

            do
            {
                Console.WriteLine("\n-------------------------");
                Console.Write("Enter a Name to Remove: ");
                string reName = Console.ReadLine().ToLower();

                if (!AmbaganProcesses.RemoveName(reName))
                {
                    Console.WriteLine($"\n{reName} is not in the list");
                }
                
                Console.Write("\nFind another person? (Y/N): ");
                addAgain = char.ToUpper(Console.ReadLine()[0]);

            } while (addAgain == 'Y');
        }

    }
}
