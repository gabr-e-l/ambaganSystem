using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static AmbagCommon.AmbagData;


namespace DataLayer
{
    public class TextFileDataService : IAmbagDataService
    {
        string filePath = "ambags.txt";

        List<AmbagEntry> entriies = new List<AmbagEntry>();

        public TextFileDataService()
        {
            LoadFromFile();
        }

        private List<AmbagEntry> LoadFromFile()
        {
            var list = new List<AmbagEntry>();

            if (!File.Exists(filePath))
                return list;

            string currentListName = "";
            foreach (var line in File.ReadLines(filePath))
            {
                if (line.StartsWith("List:"))
                {
                    currentListName = line.Substring("List:".Length).Trim();
                }
                else if (line.StartsWith("Name:"))
                {

                    var parts = line.Split(',');
                    var name = parts[0].Split(':')[1].Trim();
                    var bigay = double.Parse(parts[1].Split(':')[1].Trim());
                    var ambag = double.Parse(parts[2].Split(':')[1].Trim());
                    var sukli = double.Parse(parts[3].Split(':')[1].Trim());

                    list.Add(new AmbagEntry(currentListName, ambag, name, bigay, sukli));


                }
            }

            return list;
        }



        private void WriteToFile(List<AmbagEntry> entries)
        {
            var grouped = entries.GroupBy(e => e.ListName);
            using (var writer = new StreamWriter(filePath, false))
            {
                foreach (var group in grouped)
                {
                    double totalGiven = 0, totalSet = 0, totalChange = 0;

                    writer.WriteLine($"List: {group.Key}");

                    foreach (var entry in group)
                    {
                        writer.WriteLine($"Name: {entry.Name}, Bigay: {entry.AmountGiven}, Ambag: {entry.SetAmount}, Sukli: {entry.Change}");
                        totalGiven += entry.AmountGiven;
                        totalSet += entry.SetAmount;
                        totalChange += entry.Change;
                    }

                    writer.WriteLine();
                    writer.WriteLine($"Total Bigay: {totalGiven}");
                    writer.WriteLine($"Total Ambag: {totalSet}");
                    writer.WriteLine($"Total Sukli: {totalChange}");
                    writer.WriteLine(); 
                }
            }
        }


        public List<AmbagEntry> GetAllEntries() => LoadFromFile(); 

        public void AddEntry(AmbagEntry entry)
        {
            var entries = LoadFromFile();
            entries.Add(entry);
            WriteToFile(entries);
        }

        public bool RemoveEntry(string listName, string name)
        {
            var entries = LoadFromFile();
            var entry = entries.FirstOrDefault(e => e.ListName == listName && e.Name == name);

            if (entry != null)
            {
                entries.Remove(entry);
                WriteToFile(entries);
                return true;
            }

            return false;
        }

        public bool RemoveList(string listName)
        {
            var entries = LoadFromFile();
            bool exists = entries.Any(e => e.ListName == listName);

            if (exists)
            {
                entries.RemoveAll(e => e.ListName == listName);
                WriteToFile(entries);
                return true;
            }

            return false;
        }
    }
}