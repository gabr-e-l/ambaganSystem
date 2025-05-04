using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLayer.AmbagData;

namespace DataLayer
{
    public class OfficerAccountsService
    {
        List<ManageOfficers> accounts = new List<ManageOfficers>();

        public OfficerAccountsService()
        {
            CreateOfficersAccounts();
        }

        private void CreateOfficersAccounts()
        {
            accounts.Add(new ManageOfficers
            {
                Position = "President",
                Name = "Nadine Lustre",
                Number = "11-22-33",
                PIN = "4466"
            });

            accounts.Add(new ManageOfficers
            {
                Position = "Vice President",
                Name = "Vice Ganda",
                Number = "44-55-66",
                PIN = "5577"
            });

            accounts.Add(new ManageOfficers
            {
                Position = "Secreteray",
                Name = "Kim Chi",
                Number = "77-88-99",
                PIN = "881010"
            });

            accounts.Add(new ManageOfficers
            {
                Position = "Treasurer",
                Name = "Aiello Lastrella",
                Number = "00-01-11",
                PIN = "1111"
            });
        }

        public bool ValidateAccount(string number, string pin)
        {
            foreach (var officer in accounts)
            {
                if (officer.Number == number && officer.PIN == pin)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetOfficerPosition(string number)
        {
            foreach (var officer in accounts)
            {
                if(officer.Number == number)
                {
                    return officer.Position;
                }
            }
            return "unknown";
        }

    }
}
