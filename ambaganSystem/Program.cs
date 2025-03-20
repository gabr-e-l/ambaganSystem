using System;
using System.Collections.Generic;

namespace ambaganSystem
{
    internal class Program
    {
        static string[] make = new string[] { "\n[1] List", "[2] View", "[3] Remove" };
        static List<Tuple<int, string, int, int, int>> ambags = new List<Tuple<int, string, int, int, int>>();

        static int ccc, set, amnt, change;
        static string name, reName;
        static char chs = 'Y', yy = 'Y';

        static void Main(string[] args)
        {
            int pin = 11111, pass;
            
            do
            {
                Console.Write("Enter a Pin: ");
                pass = Convert.ToInt16(Console.ReadLine());

                if (pass != pin)
                {
                    Console.WriteLine("\nIncorrect Pin! Please try again.");
                }

            } while (pass != pin);

            Console.WriteLine("\nLogin Successful");

                do
                {
                    showMenu();
                    int ccc = toDo();

                    if (ccc == 1)
                    {
                        createList(); 
                    }

                    else if (ccc == 2)
                    {
                        viewList();
                    }

                    else if (ccc == 3)
                    {
                        removeFromList();
                    }

                    else
                    {
                        Console.WriteLine("Invalid Case!");
                    }

                    chs = answerYN("Do Another (Y/N): ");
                    
                } while (chs == 'Y');
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
            int ccc = Convert.ToInt16(Console.ReadLine());

            return ccc;
        }

        static void createList()
        {
            Console.WriteLine("\n-------------------------");
            Console.Write("Set an Amount: ");
            set = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.Write("\nEnter a Name: ");
                name = Console.ReadLine().ToLower();

                Console.Write("Enter an Amount: ");
                amnt = Convert.ToInt16(Console.ReadLine());

                verifySetAmount();

                change = amnt - set;

                ambags.Add(new Tuple<int, string, int, int, int>
                                   (set, name, amnt, set, change));

                Console.WriteLine("\nAmbag Added!");

                Console.Write("\nAdd another Ambag? (Y/N): ");
                yy = char.ToUpper(Console.ReadLine()[0]);

            } while (yy == 'Y');
        }

        static void viewList()
        {
            if (ambags.Count > 0)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine($"Ambagan: {ambags[0].Item1}");

                Console.WriteLine("\nList of Ambags: ");

                foreach (var ambs in ambags)
                {
                    Console.WriteLine($"Name: {ambs.Item2}, Bigay: {ambs.Item3}, Ambag: {ambs.Item4}, Sukli: {ambs.Item5}");
                }

                manageTotals();
            }
            else
            {
                Console.WriteLine("\nThere are no available list.");
            }
        }

        static void removeFromList()
        {
            if (ambags.Count == 0)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("There are no available list.");
                return;
            }

            do
            {
                Console.WriteLine("\n-------------------------");
                Console.Write("Enter a Name to Remove: ");
                reName = Console.ReadLine().ToLower();

                var toRemove = ambags.FindIndex(ntr => ntr.Item2 == reName);

                if (toRemove != -1)
                {
                    ambags.RemoveAt(toRemove);
                    Console.WriteLine($"\n{reName} was removed from the list.");
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{reName} is not in the list");
                }

                Console.Write("\nFind another person? (Y/N): ");
                yy = char.ToUpper(Console.ReadLine()[0]);

            } while (yy == 'Y');
        }

        static char answerYN(string YN)
        {
            Console.Write($"\n{YN}");
            return char.ToUpper(Console.ReadLine()[0]);
        }

        static void manageTotals()
        {
            int tAmnt = 0, tSet = 0, tChng = 0;
            foreach (var ambs in ambags)
            {
                tAmnt += ambs.Item3;
                tSet += ambs.Item4;
                tChng += ambs.Item5;

            }

            Console.WriteLine($"\nTotal Bigay: {tAmnt} ");
            Console.WriteLine($"Total Ambag: {tSet} ");
            Console.WriteLine($"Total Sukli: {tChng} ");
            Console.WriteLine("-------------------------");
        }

        static void verifySetAmount()
        {
            while (amnt < set) {

                Console.WriteLine("\nGiven amount cannot be smaller than ambagan.");
                
                Console.Write("\nEnter an Amount: ");
                amnt = Convert.ToInt16(Console.ReadLine());
            }
        }

    }
}
