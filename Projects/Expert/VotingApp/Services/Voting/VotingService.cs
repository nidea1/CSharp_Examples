using VotingApp.Entities.Category;

namespace VotingApp.Services.Voting
{
    public class VotingService : IVotingService
    {
        private readonly List<ICategory> _categories = new() { 
            new Category("Movie"),
            new Category("Tech Stack"),
            new Category("Sport")
        };

        private Dictionary<ICategory, int> _votes = new();

        public void DisplayCategories()
        {
            for (int i = 0; i < _categories.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {_categories[i].Name}");
            }
        }

        public void DisplayResults()
        {
            int totalVotes = _votes.Values.Sum();

            foreach (var category in _categories)
            {
                int voteCount = _votes.GetValueOrDefault(category, 0);
                double percentage = (double)voteCount / totalVotes * 100;

                Console.WriteLine($"{category.Name}: {voteCount} votes ({percentage:0.00}%)");
            }
        }

        public void Vote(string userName, int choice)
        {
            if (choice < 1 || choice > _categories.Count) return;
            ICategory category = _categories[choice - 1];
            if (!_votes.ContainsKey(category)) _votes[category] = 0;
            _votes[category]++;
        }
    }
}
