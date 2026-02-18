using System.Xml.Linq;
using BackEnd.Domain.Enums.EngineerType.EngineerType;
using BackEnd.Domain.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BackEnd.Domain.Engineer
{
    public class Engineer
    {
        public Guid ID { get; private set; }
        public required string Name { get; set; }

       
        public EngineerType EngineerType { get;private set; }
        public Engineer(EngineerType Engineertype)
        {
            Engineertype = EngineerType;
        }
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
