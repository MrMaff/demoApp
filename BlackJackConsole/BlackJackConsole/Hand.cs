using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Hand
    {
        public List<Card> cards = new List<Card>();

        public int Total
        {
            get
            {
                int highValue = 0;
                int lowValue = 0;
                int totalValue;

                foreach (var card in cards)
                {
                    highValue = card.HighValue + highValue;
                    lowValue = card.LowValue + lowValue;
                }
                if (highValue <= 21)
                {
                    totalValue = highValue;
                }
                else
                {
                    totalValue = lowValue;
                }

                return totalValue;
            }
        }

        public void AddCard(Card tempCard)
        {
            cards.Add(tempCard);
        }

        public bool ValidHand()
        {
            bool valid;
            if (Total > 0 && Total <= 21) valid = true;
            else valid = false;

            return valid;
        }

        public void ClearHand()
        {
            this.cards = new List<Card>();
        }
    }
}
