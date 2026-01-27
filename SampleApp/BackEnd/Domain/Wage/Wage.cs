namespace BackEnd.Domain.Wage
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

        public void UpdateHourlyRate(decimal hourlyRate)
        {
            HourlyRate = hourlyRate;
        }

        public void AssignToEngineer(int engineerID)
        {
            EngineerID = engineerID;
        }

        public decimal CalculateWage(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }

       
    }
}
