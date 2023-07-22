using VotingApp.Entities.User;

namespace VotingApp.Services.Register
{
    public interface IRegisterService
    {
        bool IsRegistered(string username);

        void Register(IUser user);
    }
}
