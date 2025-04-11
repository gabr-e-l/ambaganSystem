using System;
using System.Collections.Generic;
using DataLayer;

namespace AmbaganBusinessDataLogic
{
    public class AmbaganProcesses
    {
        static int pin = 11111;

        public static void UpdateList(string listName, double setAmount, string name, double amountGiven)
        {
            if (!VerifyEntryExistence(listName, name))
            {
                double change = amountGiven - setAmount;
                AmbagData.ambags.Add(new AmbagData.AmbagEntry(listName, setAmount, name, amountGiven, change));
            }
        }

        public static bool RemoveNameFromList(string reName, string listName)
        {
            var entry = AmbagData.ambags.Find(e => e.ListName == listName && e.Name == reName);
            if (entry != null)
            {
                AmbagData.ambags.Remove(entry);
                return true;
            }
            return false;
        }

        public static bool RemoveWholeList(string listName)
        {
            if (VerifyLNExistence(listName))
            {
                AmbagData.ambags.RemoveAll(e => e.ListName == listName);
                return true;
            }
            return false;
        }

        public static List<AmbagData.AmbagEntry> GetAllLists(string listName)
        {
            return AmbagData.ambags.FindAll(e => e.ListName == listName);
        }

        public static bool VerifyEntryExistence(string listName, string name)
        {
            return AmbagData.ambags.Any(e => e.ListName == listName && e.Name == name);
        }

        public static bool VerifyLNExistence(string listName)
        {
            return AmbagData.ambags.Any(e => e.ListName == listName);
        }

        public static bool VerifyPIN(int pass)
        {
            return pass == pin;
        }
    }
}