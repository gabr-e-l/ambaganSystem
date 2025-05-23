using System;
using System.Collections.Generic;
//using DataLayer;
//using AmbagCommon;
//using static DataLayer.AmbagData;
using DataLayer;

namespace AmbaganBusinessDataLogic
{
    public class AmbaganProcesses
    {
        static int pin = 11111;
        static AmbagDataService ambagService = new AmbagDataService();

        public static void UpdateList(string listName, double setAmount, string name, double amountGiven)
        {
            if (!VerifyEntryExistence(listName, name))
            {
                double change = amountGiven - setAmount;
                var entry = new AmbagCommon.AmbagData.AmbagEntry(listName, setAmount, name, amountGiven, change);
                ambagService.AddEntry(entry);
            }
        }

        public static bool RemoveNameFromList(string reName, string listName)
        {

            var allEntries = ambagService.GetAllEntries();
            AmbagCommon.AmbagData.AmbagEntry entryToRemove = null;

            foreach (var entry in allEntries)
            {
                if (entry.ListName == listName && entry.Name == reName)
                {
                    entryToRemove = entry;
                }
            }

            if (entryToRemove != null)
            {
                return ambagService.RemoveEntry(listName, reName);
                
            }
            return false;
        }

        public static bool RemoveWholeList(string listName)
        {
            if (VerifyLNExistence(listName))
            {
                return ambagService.RemoveList(listName);
            }
            return false;
        }

        public static List<AmbagCommon.AmbagData.AmbagEntry> GetListEntries(string listName)
        {
            var entries = ambagService.GetAllEntries();
            var resultEntries = new List<AmbagCommon.AmbagData.AmbagEntry>();

            foreach (var entry in entries)
            {
                if (entry.ListName == listName)
                {
                    resultEntries.Add(entry);
                }
            }
            return resultEntries;

        }

        public static bool VerifyEntryExistence(string listName, string name)
        {
            var entries = ambagService.GetAllEntries();

            foreach (var entry in entries)
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
            var entries = ambagService.GetAllEntries();

            foreach (var entry in entries)
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
            var entries = ambagService.GetAllEntries();
            var listNames = new List<string>();

            foreach (var entry in entries)
            {
                if (!listNames.Contains(entry.ListName))
                { 
                    listNames.Add(entry.ListName);
                }
            }
            return listNames;
        }

        public static AmbagCommon.AmbagData.ListTotals CalculateTotals(List<AmbagCommon.AmbagData.AmbagEntry> entries)
        {
            var totals = new AmbagCommon.AmbagData.ListTotals();

            foreach (var entry in entries)
            {
                totals.TotalGiven += entry.AmountGiven;
                totals.TotalSet += entry.SetAmount;
                totals.TotalChange += entry.Change;
            }
            return totals;

        }

        public static List<AmbagCommon.AmbagData.AmbagEntry> GetAllRecords(string searchName)
        {
            var allEntries = ambagService.GetAllEntries();
            var resultEntries = new List<AmbagCommon.AmbagData.AmbagEntry>();

            foreach (var entry in allEntries)
            {
                if (entry.Name.ToLower() == searchName.ToLower())
                {
                    resultEntries.Add(entry);
                }
            }

            return resultEntries;
        }


    }
}