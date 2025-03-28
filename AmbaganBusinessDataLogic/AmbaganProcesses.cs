using System;
using System.Collections.Generic;

namespace AmbaganBusinessDataLogic
{
    public class AmbaganProcesses
    {
        public static Dictionary<String, List<Tuple<double, string, double, double, double>>>
        ambags = new();

        static int pin = 11111;

        public static void UpdateList(string listName, double set, string name, double amnt)
        {
            if (!ambags.ContainsKey(listName))
            {
                ambags[listName] = new List<Tuple<double, string, double, double, double>>();
            }

            while (amnt < set)
            {
                Console.WriteLine("\nGiven amount can't be smaller than ambagan.");

                Console.Write("\nEnter an Amount: ");
                amnt = Convert.ToDouble(Console.ReadLine());
            }

            double change = amnt - set;
            ambags[listName].Add(new Tuple<double, string, double, double, double>
                                             (set, name, amnt, set, change));
        }

        public static void DisplayAmbags(string listName)
        {
            if (!ambags.ContainsKey(listName))
            {
                Console.WriteLine("List not found!");
                return;
            }

            if (ambags.Count > 0)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine($"Ambagan: {ambags[listName][0].Item1}");
                Console.WriteLine("\nList of Ambags: ");

                foreach(var ambs in ambags[listName])
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

        public static bool RemoveName(string reName, string listName)
        {
            if (!ambags.ContainsKey(listName))
            {
                return false;
            }

            var toRemove = ambags[listName].FindIndex(ntr => ntr.Item2 == reName);
            if(toRemove != -1)
            {
                ambags[listName].RemoveAt(toRemove);
                Console.WriteLine($"\n{reName} was removed from the list");
                return true;
            }
            return false;
        }

        public static void ManageTotals(string listName)
        {
            double tAmnt = 0, tSet = 0, tChng = 0;
            foreach(var ambs in ambags[listName])
            {
                tAmnt += ambs.Item3;
                tSet += ambs.Item4;
                tChng += ambs.Item5;
            }

            Console.WriteLine($"\nTotal Bigay: {tAmnt}");
            Console.WriteLine($"Total Ambag: {tSet}");
            Console.WriteLine($"Total Sukli: {tChng}");
        }

        public static bool RemoveList(string listName)
        {
            if (ambags.ContainsKey(listName))
            {
                ambags.Remove(listName);
                return true;
            }
            return false;
        }

        public static void DisplayListNames()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("\nAvailable Lists:");
            foreach (var list in ambags.Keys)
            {
                Console.WriteLine($"- {list}");
            }
            return;
        }

        public static bool VerifyPIN(int pass)
        {
            return pass == pin;
        }
    }
}