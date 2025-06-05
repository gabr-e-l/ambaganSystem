//using DataLogic;
using static AmbagCommon.AmbagData;


namespace DataLayer
{
    public class AmbagDataService
    {
        IAmbagDataService dataService;

        public AmbagDataService()
        {
            //dataService = new TextFileDataService();
            dataService = new JsonFileDataService();
            //dataService = new InMemoryDataService();
            //dataService = new DBDataService();

        }

        public List<AmbagEntry> GetAllEntries()
        {
            return dataService.GetAllEntries();
        }

        public void AddEntry(AmbagEntry entry)
        {
            dataService.AddEntry(entry);
        }

        public bool RemoveEntry(string listName, string name)
        {
            return dataService.RemoveEntry(listName, name);
        }

        public bool RemoveList(string listName)
        {
            return dataService.RemoveList(listName);
        }
    }
}