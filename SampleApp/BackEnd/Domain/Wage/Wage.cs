using BackEnd.Domain.ValueObjects;

namespace BackEnd.Domain.Wage
{
    public class Wage
    {
        public int ID { get; private set; }
        public int EngineerID { get; private set; }
        public required Money HourlyRate { get; set; }

        protected Wage() { }

        public Wage(int engineerID, Money hourlyRate)
        {
            EngineerID = engineerID;
            HourlyRate = hourlyRate;
        }


       
    }
}
