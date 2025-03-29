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

            double change = amnt - set;
            ambags[listName].Add(new Tuple<double, string, double, double, double>
                                             (set, name, amnt, set, change));
        }

        public static bool RemoveName(string reName, string listName)
        {
            if (ambags.ContainsKey(listName))
            {
                return true;
            }
            return false;  
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

        public static bool VerifyPIN(int pass)
        {
            return pass == pin;
        }
    }
}