using VotingApp.Entities.User;

namespace VotingApp.Services.Register
{
    public class RegisterService : IRegisterService
    {
        private readonly HashSet<IUser> _users = new();

        public bool IsRegistered(string username) => _users.Any(user => user.Username == username);
        public void Register(IUser user) => _users.Add(user);
    }
}
