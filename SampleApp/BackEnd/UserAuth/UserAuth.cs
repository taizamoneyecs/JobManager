namespace BackEnd.UserAuth
{
    public class UserAuth
    {
        public int ID { get; private set; }
        public required string Email { get; set; }
        public enum UserRole
        {
            Admin,
            Engineer,
            Client,
            Manager
        }
        public required UserRole Role { get; set; }

        protected UserAuth() { }
        public UserAuth(string email, UserRole role)
        {
            Email = email;
            Role = role;
        }
        
        
    }
}
