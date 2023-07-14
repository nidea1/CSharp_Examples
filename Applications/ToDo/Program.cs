using System;
using ToDo.Entities.Concrete;
using ToDo.Enums;
using ToDo.Repositories.LineRepository;

namespace ToDo
{
    class Program
    {
        static Board _board = new Board { Id = 1 };

        static List<TeamMember> _teamMembers = new() {
            new TeamMember { Id = "TM1", Name = "Doruk"},
            new TeamMember { Id = "TM2", Name = "Ahmet"},
            new TeamMember { Id = "TM3", Name = "Mehmet"},
        };

        static Line _todo;
        static Line _inProgress;
        static Line _done;

        static LineRepository _todoRepository;
        static LineRepository _inProgressRepository;
        static LineRepository _doneRepository;

        static int cardId = 1;
        static void Main()
        {
            _todo = new Line { Id = "TODO", Name = "To Do", Cards = new List<Card>() };
            _inProgress = new Line { Id = "INPROGRESS", Name = "In Progress", Cards = new List<Card>() };
            _done = new Line { Id = "DONE", Name = "Done", Cards = new List<Card>() };

            _board.Lines.Add(_todo);
            _board.Lines.Add(_inProgress);
            _board.Lines.Add(_done);

            _todoRepository = new LineRepository(_todo);
            _inProgressRepository = new LineRepository(_inProgress);
            _doneRepository = new LineRepository(_done);

            while (true)
            {
                Console.WriteLine("Please select an action :)\n****************************");
                Console.WriteLine("(1) List the Board\n(2) Add a card to the Board\n(3) Update a card\n(4) Delete a card from the Board\n(5) Move Card\n(6) Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ListBoard();
                        break;
                    case "2":
                        AddCard();
                        break;
                    case "3":
                        UpdateCard();
                        break;
                    case "4":
                        DeleteCard();
                        break;
                    case "5":
                        MoveCard();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Select a valid action");
                        return;
                }
            }
        }

        static void ListBoard()
        {
            var lines = _board.Lines;
            foreach (var line in lines)
            {
                Console.WriteLine($"{line.Name} Line\n*****************");
                var cards = line.Cards;

                if (cards.Count != 0)
                {
                    foreach (var card in cards)
                    {
                        Console.WriteLine($"Title: {card.Title}");
                        Console.WriteLine($"Desc: {card.Description}");
                        Console.WriteLine($"Assigned Member: {card.AssignedMember.Name}");
                        Console.WriteLine($"Size: {card.CardSize}");
                        Console.WriteLine("-------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("~ EMPTY ~");
                }
            }
        }
    
        static void AddCard()
        {
            try{
                Console.Write("Card Title: ");
                string title = Console.ReadLine();

                Console.Write("Card Description: ");
                string description = Console.ReadLine();

                CardSize size = SelectSize();

                Console.Write("Assign to Member: ");

                TeamMember assignedMember = SelectMember();

                if (assignedMember == null)
                {
                    throw new Exception();
                }

                Card newCard = new Card{
                    Id = cardId,
                    Title = title,
                    Description = description,
                    CardSize = size,
                    AssignedMember = assignedMember,
                };

                _todoRepository.AddCard(newCard);
                cardId++;
            }
            catch
            {
                Console.WriteLine("Wrong input!");
                AddCard();
            }
        }
    
        static void UpdateCard()
        {
            try
            {
                LineRepository currentLineRepository = GetCurrentLineRepository();

                var cards = currentLineRepository.GetAllCards();

                if(cards.Count == 0)
                {
                    throw new Exception("There is no card to delete!");
                }

                for (int i = 0; i < cards.Count; i++)
                {
                    Console.WriteLine($"({cards[i].Id}) {cards[i].Title}");
                }

                Console.Write("Select card to update: ");
                string cardInput = Console.ReadLine();

                int cardId;
                bool isNumeric = int.TryParse(cardInput, out cardId);

                if (!isNumeric || !cards.Exists(c => c.Id == cardId))
                {
                    throw new Exception("Wrong card input!");
                }

                Card card = cards.Find(c => c.Id == cardId);

                Console.Write("New card title: ");
                card.Title = Console.ReadLine();

                Console.Write("New card description: ");
                card.Description = Console.ReadLine();

                Console.Write("New assigned member: ");

                TeamMember assignedMember = SelectMember();

                if (assignedMember == null)
                {
                    throw new Exception();
                }

                card.AssignedMember = assignedMember;

                card.CardSize = SelectSize();

                Console.WriteLine("Card updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred!\n{ex.Message}");
                UpdateCard();
            }
        }

        static void DeleteCard()
        {
            try
            {
                LineRepository currentLineRepository = GetCurrentLineRepository();

                var cards = currentLineRepository.GetAllCards();

                if(cards.Count == 0)
                {
                    throw new Exception("There is no card to delete!");
                }

                for (int i = 0; i < cards.Count; i++)
                {
                    Console.WriteLine($"({cards[i].Id}) {cards[i].Title}");
                }

                Console.Write("Select card to delete: ");
                string cardInput = Console.ReadLine();

                int cardId;
                bool isNumeric = int.TryParse(cardInput, out cardId);

                if (!isNumeric || !cards.Exists(c => c.Id == cardId))
                {
                    throw new Exception("Wrong card input!");
                }

                Card card = cards.Find(c => c.Id == cardId);

                currentLineRepository.DeleteCard(card);

                Console.WriteLine("Card deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred!\n{ex.Message}");
                DeleteCard();
            }
            
        }

        static void MoveCard()
        {
            try
            {
                LineRepository currentLineRepository = GetCurrentLineRepository();

                var cards = currentLineRepository.GetAllCards();

                if(cards.Count == 0)
                {
                    throw new Exception("There is no card to delete!");
                }

                for (int i = 0; i < cards.Count; i++)
                {
                    Console.WriteLine($"({cards[i].Id}) {cards[i].Title}");
                }

                Console.Write("Select card to delete: ");
                string cardInput = Console.ReadLine();

                int cardId;
                bool isNumeric = int.TryParse(cardInput, out cardId);

                if (!isNumeric || !cards.Exists(c => c.Id == cardId))
                {
                    throw new Exception("Wrong card input!");
                }

                Card card = cards.Find(c => c.Id == cardId);

                Console.Write("Which Line to Move -> To Do(1), In Progress(2), Done(3): ");
                string newLineInput = Console.ReadLine();

                Line newLine;

                switch(newLineInput)
                {
                    case "1":
                        newLine = _todo;
                        break;
                    case "2":
                        newLine = _inProgress;
                        break;
                    case "3":
                        newLine = _done;
                        break;
                    default:
                        Console.WriteLine("Wrong Input!");
                        return;
                }

                currentLineRepository.MoveCard(card, newLine);

                Console.WriteLine("Card moved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred!\n{ex.Message}");
                MoveCard();
            }
        }

        static TeamMember SelectMember()
        {
                foreach (var member in _teamMembers)
                {
                    Console.WriteLine($"{member.Name} ({member.Id})");
                }

                string memberInput = Console.ReadLine();

                return _teamMembers.Find(member => member.Id == memberInput);
        }

        static CardSize SelectSize()
        {
            while (true)
            {
                Console.Write("New card size -> XS(1),S(2),M(3),L(4),XL(5): ");
                string sizeInput = Console.ReadLine();

                switch(sizeInput)
                {
                    case "1":
                        return CardSize.XS;
                    case "2":
                        return CardSize.S;
                    case "3":
                        return CardSize.M;
                    case "4":
                        return CardSize.L;
                    case "5":
                        return CardSize.XL;
                    default:
                        Console.WriteLine("Wrong Input! Try again.");
                        break;
                }
            }
        }

        static LineRepository GetCurrentLineRepository()
        {
            while(true)
            {
                Console.Write("Which Line -> To Do(1), In Progress(2), Done(3): ");
                string lineInput = Console.ReadLine();

                switch(lineInput)
                {
                    case "1":
                        return _todoRepository;
                    case "2":
                        return _inProgressRepository;
                    case "3":
                        return _doneRepository;
                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }
            }
        }
    }
}
