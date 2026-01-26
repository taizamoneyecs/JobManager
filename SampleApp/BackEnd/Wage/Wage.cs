namespace BackEnd.Wage
{
    public class Wage
    {
        public int ID { get; private set; }
        public int EngineerID { get; private set; }
        public required decimal HourlyRate { get; set; }

        protected Wage() { }

        public Wage(int engineerID, decimal hourlyRate)
        {
            EngineerID = engineerID;
            HourlyRate = hourlyRate;
        }

        
    }
}
