namespace VotingApp.Entities.Category
{
    public class Category: ICategory
    {
        public string Name { get; }
        
        public Category(string name)
        {
            Name = name;
        }
    }
}
