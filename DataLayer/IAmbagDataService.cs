using System.Collections.Generic;
using static AmbagCommon.AmbagData;

namespace DataLayer
{
    public interface IAmbagDataService
    {
        List<AmbagEntry> GetAllEntries();
        void AddEntry(AmbagEntry entry);
        bool RemoveEntry(string listName, string name);
        bool RemoveList(string listName);

    }
}
