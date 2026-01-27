using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BackEnd.Domain.Engineer
{
    public class Engineer
    {
        public int ID { get; private set; }
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

        protected Engineer() { }

        public Engineer(string name,string email, long number)
        {
            Name = name;
            Email = email;
            Number = number;
            
        }

        public void UpdateContactInfo(string email, long number)
        {
            Email = email;
            Number = number;
        }

        public void assignEngineerType(EngineerType type)
        {
            Type = type;
        }
    }
}
