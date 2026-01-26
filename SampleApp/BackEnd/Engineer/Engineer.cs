namespace BackEnd.Engineer
{
    public class Engineer
    {
        public required int ID { get; set; }
        public required string Name { get; set; }

        public enum EngineerType
        {
            Gas,
            WetWork,
            Mechanical,
            Electrical,
            CoreDrilling
        }
        public required EngineerType Type { get; set; }
        public required string Email { get; set; }
        public required long Number { get; set; }
    }
}
