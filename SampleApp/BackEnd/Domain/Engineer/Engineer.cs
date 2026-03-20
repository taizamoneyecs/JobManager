using System.Xml.Linq;
using System;
using BackEnd.Domain.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BackEnd.Domain.Enums.EngineerType;

namespace BackEnd.Domain.Engineer
{
    public class Engineer
    {
        public int EngineerID { get; private set; }
        public required string Name { get; set; }

        public EngineerType Type { get;private set; }
        
        public required string Email { get; set; }
        public required long Number { get; set; }

        protected Engineer() { }

        public Engineer(int engineerID,string name,string email, long number, EngineerType type)
        {
            EngineerID = engineerID
            Name = name;
            Type = type;
            Email = email;
            Number = number;
            =
            
        }

       



    }
}
