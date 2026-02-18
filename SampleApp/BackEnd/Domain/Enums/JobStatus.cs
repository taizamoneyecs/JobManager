using System;

namespace BackEnd.Domain.Enums
{
    public class JobStatus : Enumeration
    {
        public static readonly JobStatus None = new(0, "None");
        public static readonly JobStatus Raised = new(1, "Raised");
        public static readonly JobStatus Approved = new(2, "Approved");
        public static readonly JobStatus Assigned = new(3, "Assigned");
        public static readonly JobStatus InProgress = new(4, "InProgress");
        public static readonly JobStatus Completed = new(5, "Completed");
        public static readonly JobStatus Cancelled = new(6, "Cancelled");
        private JobStatus() { }
        private JobStatus(int id, string name) : base(id, name)
        {
        }
    }
}


        