using System;
using ToDo.Entities.Concrete;

namespace ToDo.Repositories.LineRepository
{
    public interface ILineRepository
    {
        List<Card> GetAllCards();

        void AddCard(Card card);

        void DeleteCard(Card card);

        void MoveCard(Card card, Line newLine);
    }
}
