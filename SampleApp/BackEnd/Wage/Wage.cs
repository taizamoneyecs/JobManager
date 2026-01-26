namespace BackEnd.Wage
{
    public class Wage
    {
        public required int ID { get; set; }
        public required int EngineerID { get; set; }
        public required decimal HourlyRate { get; set; }
    }
}
