namespace BackEnd.UserAuth
{
    public class UserAuth
    {
        public required int ID { get; set; }
        public required string Email { get; set; }
        public enum UserRole
        {
            Admin,
            Engineer,
            Client,
            Manager
        }
        public required UserRole Role { get; set; }
    }
}
