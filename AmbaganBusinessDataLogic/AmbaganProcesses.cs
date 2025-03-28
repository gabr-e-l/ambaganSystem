using System;
using System.Collections.Generic;

namespace AmbaganBusinessDataLogic
{
    public class AmbaganProcesses
    {
        public static List<Tuple<double, string, double, double, double>>
        ambags = new();

        static int pin = 11111;

        public static void UpdateList(double set, string name, double amnt)
        {
            double change = amnt - set;

            ambags.Add(new Tuple<double, string, double, double, double>
                (set, name, amnt, set, change));
        }

        public static void DisplayAmbags()
        {
            if(ambags.Count > 0)
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine($"Ambagan: {ambags[0].Item1}");
                Console.WriteLine("\nList of Ambags: ");

                foreach(var ambs in ambags)
                {
                    Console.WriteLine($"Name: {ambs.Item2}, Bigay: {ambs.Item3}, " +
                                     $"Ambag: {ambs.Item4}, Sukli: {ambs.Item5}");
                }
                ManageTotals();
            }

            else
            {
                Console.WriteLine("\nThere are no available lists.");
            }
        }

        public static bool RemoveName(string reName)
        {
            var toRemove = ambags.FindIndex(ntr => ntr.Item2 == reName);
            if(toRemove != -1)
            {
                ambags.RemoveAt(toRemove);
                Console.WriteLine($"\n{reName} was removed from the list");
                return true;
            }
            return false;
        }

        public static void VerifySetAmount(double set, double amnt)
        {
            while (amnt < set)
            {
                Console.WriteLine("\nGiven amount can't be smaller than ambagan.");

                Console.Write("\nEnter an Amount: ");
                amnt = Convert.ToInt16(Console.ReadLine());
            }
        }

        public static void ManageTotals()
        {
            double tAmnt = 0, tSet = 0, tChng = 0;
            foreach(var ambs in ambags)
            {
                tAmnt += ambs.Item3;
                tSet += ambs.Item4;
                tChng += ambs.Item5;
            }

            Console.WriteLine($"\nTotal Bigay: {tAmnt}");
            Console.WriteLine($"Total Ambag: {tSet}");
            Console.WriteLine($"Total Sukli: {tChng}");
        }

        public static bool VerifyPIN(int pass)
        {
            return pass == pin;
        }

    }
}