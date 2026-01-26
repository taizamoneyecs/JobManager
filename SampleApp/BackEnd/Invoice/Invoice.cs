namespace BackEnd.Invoice
{
    public class Invoice
    {
        public required int ID { get; set; }
        public required int ClientID { get; set; }
        public required int EngineerID { get; set; }
        public required DateOnly Date { get; set; }
        public required decimal Amount { get; set; }
        public required bool Paid { get; set; }
    }
}
