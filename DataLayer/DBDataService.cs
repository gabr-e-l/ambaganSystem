using AmbagCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBDataService : IAmbagDataService
    {
        public void AddEntry(AmbagData.AmbagEntry entry)
        {
            throw new NotImplementedException();
        }

        public List<AmbagData.AmbagEntry> GetAllEntries()
        {
            throw new NotImplementedException();
        }

        public bool RemoveEntry(string listName, string name)
        {
            throw new NotImplementedException();
        }

        public bool RemoveList(string listName)
        {
            throw new NotImplementedException();
        }
    }
}
