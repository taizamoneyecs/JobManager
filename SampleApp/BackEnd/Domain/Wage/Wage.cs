using BackEnd.Domain.ValueObjects;
using BackEnd.Domain.Engineer;
using BackEnd.Domain.Enums;


namespace BackEnd.Domain.Wage
{
    public class Wage
    {
        public int WageID { get; private set; }

        [ForeignKey("Engineer")]
        public int EngineerID { get; private set; }
        public Engineer Engineer { get; private set; } // navigation property map to EngineerID in model builder

        public required Balance Salary { get; set; }

        public required WageStatus Status { get; set; }


        protected Wage() { }

        public Wage(int wageID, int EngineerID, Balance salary, WageStatus status)
        {
            WageID = wageID;
            EngineerID = EngineerID;
            Balance = new Balance(salary);
            WageStatus = status;
        }

        // map hourly rate to engineer type enum 

    }
}
