namespace AmbagCommon
{
    public class AmbagData
    {
        public static List<AmbagEntry> ambags = new List<AmbagEntry>();

        public class AmbagEntry
        {
            public string ListName { get; set; }
            public double SetAmount { get; set; }
            public string Name { get; set; }
            public double AmountGiven { get; set; }
            public double Change { get; set; }

            public AmbagEntry(string listName, double setAmount, string name,
                              double amountGiven, double change)
            {
                ListName = listName;
                SetAmount = setAmount;
                Name = name;
                AmountGiven = amountGiven;
                Change = change;
            }

            public AmbagEntry() { }
        }

        public class ListTotals
        {
            public double TotalGiven { get; set; }
            public double TotalSet { get; set; }
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
