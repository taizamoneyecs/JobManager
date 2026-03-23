namespace BackEnd.Domain.UserAuth

    // I might not be using this 
{
    public class UserAuth
    {
        public Guid ID { get; private set; }
        public enum UserRole
        {
            Admin,
            Engineer,
            Client,
            Manager
        }
        public required UserRole Role { get; set; }

        protected UserAuth() { }
        public UserAuth(UserRole role)
        {
            Role = role;
        }

      
    }
    }
