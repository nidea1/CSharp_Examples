using ATMApp.Models;

namespace ATMApp.Services
{
    public class AuthenticationService
    {
        private List<User> _users = new()
        {
            new User("user1", "pass1"),
            new User("user2", "pass2")
        };

        public bool Authenticate(string username, string password)
        {
            foreach (var user in _users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
