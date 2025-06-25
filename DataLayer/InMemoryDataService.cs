using System;
using System.Collections.Generic;
using static AmbagCommon.AmbagData;

namespace DataLayer
{
    public class InMemoryDataService : IAmbagDataService
    {
        List<AmbagEntry> _entries;

        public InMemoryDataService()
        {
            EnsureInitialized();
        }

        private void EnsureInitialized()
        {
            _entries = new List<AmbagEntry>();
        }

        public List<AmbagEntry> GetAllEntries()
        {
            return new List<AmbagEntry>(_entries);
        }

        public void AddEntry(AmbagEntry entry)
        {
            _entries.Add(entry);
        }

        public bool RemoveEntry(string listName, string name)
        {
            var entry = _entries.Find(e => e.ListName == listName && e.Name == name);
            if (entry != null)
            {
                _entries.Remove(entry);
                return true;
            }
            return false;
        }

        public bool RemoveList(string listName)
        {
            var exists = _entries.Exists(e => e.ListName == listName);
            if (exists)
            {
                _entries.RemoveAll(e => e.ListName == listName);
                return true;
            }
            return false;
        }
    }
}