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

            public AmbagEntry(string listName, double setAmount, string name, double amountGiven, double change)
            {
                ListName = listName;
                SetAmount = setAmount;
                Name = name;
                AmountGiven = amountGiven;
                Change = change;
            }
        }

    }
}
