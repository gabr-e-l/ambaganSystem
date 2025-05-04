namespace DataLayer
{
    public class AmbagData
    {
        public static List<AmbagEntry> ambags = new List<AmbagEntry>();

        public class AmbagEntry
        {
            public string ListName { get; }
            public double SetAmount { get; }
            public string Name { get; }
            public double AmountGiven { get; }
            public double Change { get; }

            public AmbagEntry(string listName, double setAmount, string name, 
                              double amountGiven, double change)
            {
                ListName = listName;
                SetAmount = setAmount;
                Name = name;
                AmountGiven = amountGiven;
                Change = change;
            }
        }

        public class ListTotals
        {
            public double TotalGiven { get; set; }
            public double TotalSet { get; set;  }
            public double TotalChange { get; set; }
        }

        public class ManageOfficers
        {
            private string _pin = "1234";
            public string PIN
            {
                get { return _pin; }
                set
                {
                    if (value.Length == 4 || value.Length == 6)
                    {
                        _pin = value;
                    }
                }
            }

            public string Position { get; set; }
            public string Name { get; set; }
            public string Number { get; set; }
        }


    }
}
