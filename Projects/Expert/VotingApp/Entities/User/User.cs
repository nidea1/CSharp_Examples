namespace VotingApp.Entities.User
{
    public class User : IUser
    {
        public string Username { get; }

        public User(string username)
        {
            Username = username;
        }
    }
}
