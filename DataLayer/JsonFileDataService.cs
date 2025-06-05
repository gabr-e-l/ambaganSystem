using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using static AmbagCommon.AmbagData;


namespace DataLayer
{
    public class JsonFileDataService : IAmbagDataService
    {
        string filePath = "ambags.json";

        public JsonFileDataService()
        {
            //EnsureFileExists();
            LoadFromFile();
        }

        /*private void EnsureFileExists()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }*/

        private List<AmbagDataContainer> LoadFromFile()
        {
            try
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<AmbagDataContainer>>(json) ?? new List<AmbagDataContainer>();
            }
            catch
            {
                return new List<AmbagDataContainer>();
            }
        }

        private void WriteToFile(List<AmbagDataContainer> data)
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));
        }

        public List<AmbagEntry> GetAllEntries()
        {
            return LoadFromFile().SelectMany(container => container.Entries).ToList();
        }

        public ListTotals GetTotals(string listName)
        {
            var data = LoadFromFile().FirstOrDefault(c => c.ListName == listName);
            return data?.Totals ?? new ListTotals();
        }

        public void AddEntry(AmbagEntry entry)
        {
            var data = LoadFromFile();
            var listContainer = data.FirstOrDefault(c => c.ListName == entry.ListName);

            if (listContainer == null)
            {
                listContainer = new AmbagDataContainer
                {
                    ListName = entry.ListName,
                    Entries = new List<AmbagEntry>(),
                    Totals = new ListTotals()
                };
                data.Add(listContainer);
            }

            listContainer.Entries.Add(entry);
            UpdateTotals(listContainer);
            WriteToFile(data);
        }

        public bool RemoveEntry(string listName, string name)
        {
            var data = LoadFromFile();
            var listContainer = data.FirstOrDefault(c => c.ListName == listName);

            if (listContainer == null) return false;

            var entry = listContainer.Entries.FirstOrDefault(e => e.Name == name);
            if (entry == null) return false;

            listContainer.Entries.Remove(entry);
            UpdateTotals(listContainer);
            WriteToFile(data);
            return true;
        }

        public bool RemoveList(string listName)
        {
            var data = LoadFromFile();
            var listContainer = data.FirstOrDefault(c => c.ListName == listName);

            if (listContainer == null) return false;

            data.Remove(listContainer);
            WriteToFile(data);
            return true;
        }

        private void UpdateTotals(AmbagDataContainer listContainer)
        {
            listContainer.Totals.TotalGiven = listContainer.Entries.Sum(e => e.AmountGiven);
            listContainer.Totals.TotalSet = listContainer.Entries.Sum(e => e.SetAmount);
            listContainer.Totals.TotalChange = listContainer.Entries.Sum(e => e.Change);
        }
    }

    public class AmbagDataContainer
    {
        public string ListName { get; set; }
        public List<AmbagEntry> Entries { get; set; } = new List<AmbagEntry>();
        public ListTotals Totals { get; set; } = new ListTotals();
    }
}