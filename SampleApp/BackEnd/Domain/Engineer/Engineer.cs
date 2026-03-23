using System.Xml.Linq;
using System;
using BackEnd.Domain.Enums;
using BackEnd.Domain.ValueObjects;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BackEnd.Domain.Engineer
{
    public class Engineer
    {
        public int EngineerID { get; private set; }
        public required string Name { get; private set; }

        public EngineerType Type { get; private set; }
        
        public required Email EngineerEmail { get; private set; }
        public required Number EngineerNumber { get; private set; }

        protected Engineer() { }

        public Engineer(int engineerID,string name, Email EngineerEmail, Number EngineerNumber, EngineerType type)
        {
            EngineerID = engineerID
            Name = name;
            EngineerType = type;
            Email = new Email(email);
            Number = new Number(number);
            
            
        }

       



    }
}
