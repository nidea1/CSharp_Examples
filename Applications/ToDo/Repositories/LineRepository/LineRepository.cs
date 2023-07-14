using System;
using ToDo.Entities.Concrete;

namespace ToDo.Repositories.LineRepository
{
    public class LineRepository : ILineRepository
    {
        private Line _line;

        public LineRepository(Line line)
        {
            _line = line;
        }

        public void AddCard(Card card)
        {
            _line.Cards.Add(card);
        }

        public void DeleteCard(Card card)
        {
            _line.Cards.Remove(card);
        }

        public List<Card> GetAllCards()
        {
            return _line.Cards;
        }

        public void MoveCard(Card card, Line newLine)
        {
            newLine.Cards.Add(card);
            DeleteCard(card);
        }
    }
}
