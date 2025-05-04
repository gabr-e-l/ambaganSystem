using System;
using System.Collections.Generic;
using DataLayer;
//using static DataLayer.AmbagData;

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
            //var entry = AmbagData.ambags.Find(e => e.ListName == listName && e.Name == reName);

            AmbagData.AmbagEntry entry = null;
            foreach (var e in AmbagData.ambags)
            {
                if (e.ListName == listName && e.Name == reName)
                {
                    entry = e;
                }
            }

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
            //return AmbagData.ambags.FindAll(e => e.ListName == listName);

            var result = new List<AmbagData.AmbagEntry>();

            foreach (var entry in AmbagData.ambags)
            {
                if (entry.ListName == listName)
                {
                    result.Add(entry);
                }
            }
            return result;

        }

        public static bool VerifyEntryExistence(string listName, string name)
        {
            //return AmbagData.ambags.Any(e => e.ListName == listName && e.Name == name);

            foreach (var entry in AmbagData.ambags)
            {
                if (entry.ListName == listName && entry.Name == name)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool VerifyLNExistence(string listName)
        {
            //return AmbagData.ambags.Any(e => e.ListName == listName);

            foreach (var entry in AmbagData.ambags)
            {
                if (entry.ListName == listName)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<string> GetListNames()
        {
            var listNames = new List<string>();

            foreach (var entry in AmbagData.ambags)
            {
                if (!listNames.Contains(entry.ListName)) 
                     listNames.Add(entry.ListName);
            }
            return listNames;
        }

        public static AmbagData.ListTotals CalculateTotals(List<AmbagData.AmbagEntry> entries)
        {
            var totals = new AmbagData.ListTotals();

            foreach (var entry in entries)
            {
                totals.TotalGiven += entry.AmountGiven;
                totals.TotalSet += entry.SetAmount;
                totals.TotalChange += entry.Change;
            }
            return totals;

        }

        /*public static bool VerifyPIN(int pass)
        {
            return pass == pin;
        }*/

        public static List<AmbagData.AmbagEntry> GetAllRecords(string searchName)
        {
            var allRecords = new List<AmbagData.AmbagEntry>();

            foreach (var listName in GetListNames())
            {
                var entries = GetAllLists(listName);

                foreach (var entry in entries)
                {
                    if (entry.Name.ToLower() == searchName)
                    {
                        allRecords.Add(entry);
                    }
                }
            }
            return allRecords;
        }


    }
}