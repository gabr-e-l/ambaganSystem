using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AmbaganBusinessDataLogic;
using static AmbagCommon.AmbagData;


namespace AmbaganAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class AmbaganController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<string>/*List<string>*/ GetLists()
        {
            var result = AmbaganProcesses.GetListNames();
            return result;
        }

        [HttpPost]
        public bool AddEntry(AmbagEntry entry)
        {
            AmbaganProcesses.UpdateList(entry.ListName, entry.SetAmount, entry.Name, entry.AmountGiven);
            return true;
        }

        [HttpGet("view")]
        public List<AmbagEntry> ViewList(string listName)
        {
            var view = AmbaganProcesses.GetListEntries(listName);
            return view;
        }

        [HttpDelete("remove-entry")]
        public bool RemoveEntry(string listName, string name)
        {
            var removeE = AmbaganProcesses.RemoveNameFromList(name, listName);
            return removeE;
        }

        [HttpDelete("remove-list")]
        public bool RemoveList(string listName)
        {
            var removeL = AmbaganProcesses.RemoveWholeList(listName);
            return removeL;
        }

        [HttpGet("search")]
        public List<AmbagEntry> Search(string name)
        {
            var search = AmbaganProcesses.GetAllRecords(name);
            return search;
        }

    }
}
