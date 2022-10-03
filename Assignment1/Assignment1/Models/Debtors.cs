namespace Assignment1.Models
{
    public class Debtors
    {
        string? name;
        int? amount;

        public Debtors()
        {
        }

        public Debtors(string aName, int aAmount)
        {
            name = aName;
            amount = aAmount;

        }

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int? Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
    }
}
