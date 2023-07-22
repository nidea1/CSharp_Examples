namespace VotingApp.Services.Voting
{
    public interface IVotingService
    {
        public void DisplayCategories();

        public void Vote(string userName, int choice);

        public void DisplayResults();

    }
}
