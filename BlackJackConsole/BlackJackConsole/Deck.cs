using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Deck
    {
        private Stack<Card> cards = new Stack<Card>();
        
        public Deck()
        {
            CreateDeck();
        }

        public Deck(int packs)
        {
            for (int i = 0; i < packs; i++)
            {
                CreateDeck();
            }
        }

        private void CreateDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                int cardNum = (i % 13) + 1;
                int suitNum = i % 4;

                AddCard(new Card((Suits)suitNum, cardNum));
            }
        }

        public void AddCard(Card tempCard)
        {
            cards.Push(tempCard);
        }

        public Card DealCard()
        {
            return cards.Pop();
        }

        public void Shuffle()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            List<Card> tempList = this.cards.ToList();
            this.cards.Clear();
            int tempCount = tempList.Count;

            for (int i = 0; i < tempCount; i++)
            {
                int location = rnd.Next(0, tempList.Count);
                this.cards.Push(tempList[location]);
                tempList.RemoveAt(location);
            }
            
        }
    }
}
