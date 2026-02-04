using BackEnd.Domain.ValueObjects;

namespace BackEnd.Domain.Wage
{
    public class Wage
    {
        public Guid ID { get; private set; }
        public Guid EngineerID { get; private set; }

        public required decimal Amount { get; set; }
        public required decimal HourlyRate { get; set; }

        protected Wage() { }

        public Wage(Guid engineerID, decimal hourlyRate, decimal amount)
        {
            EngineerID = engineerID;
            HourlyRate = hourlyRate;
            Amount = amount;
        }



    }
}
