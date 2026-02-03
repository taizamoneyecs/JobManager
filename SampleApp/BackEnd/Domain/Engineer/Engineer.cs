using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BackEnd.Domain.Engineer
{
    public class Engineer
    {
        public Guid ID { get; private set; }
        public required string Name { get; set; }

        public enum EngineerType
        {
            Gas,
            WetWork,
            Mechanical,
            Electrical,
            CoreDrilling
        }
        public EngineerType Type { get;private set; }
        public required string Email { get; set; }
        public required long Number { get; set; }

        protected Engineer() { }

        public Engineer(string name,string email, long number)
        {
            ID = Guid.NewGuid();
            Name = name;
            Email = email;
            Number = number;
            
        }

        
    }
}
