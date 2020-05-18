using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Deck
    {
        private List<Card> cards = new List<Card>();
        
        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                int cardNum = (i % 13) + 1;
                int suitNum = i % 4;

                AddCard(new Card((Suit)suitNum, cardNum));
            }
        }

        public void AddCard(Card tempCard)
        {
            cards.Add(tempCard);
        }

        public Card DealCard()
        {
            Card tempCard = cards[0];
            cards.RemoveAt(0);
            return tempCard;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            List<Card> tempList = new List<Card>();
            int tempCount = cards.Count;

            for (int i = 0; i < tempCount; i++)
            {
                int location = rnd.Next(0, cards.Count);
                tempList.Add(cards[location]);
                cards.RemoveAt(location);
            }
            cards = tempList;
        }
    }
}
