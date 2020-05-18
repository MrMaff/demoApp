using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Player
    {
        public readonly Hand hand = new Hand();

        public void AddCard(Card tempCard)
        {
            this.hand.AddCard(tempCard);
        }
    }

    class HumanPlayer : Player
    {
       
        private int credits;
        public int Credits { get { return credits; } }

        public HumanPlayer()
        {
            this.credits = 5;
        }

        public void removeCredit()
        {
            if (credits > 0)
            {
                this.credits --;
            }
            else
            {
                throw new ArgumentOutOfRangeException("credits");
            }
        }

        public void removeCredit(int credits)
        {
            if (this.credits >= credits)
            {
                this.credits = this.credits - credits;
            }
            else
            {
                throw new ArgumentOutOfRangeException("credits");
            }
        }


        public void AddCredits()
        {
            this.credits++;
        }

        public void AddCredits(int credits)
        {
            this.credits = this.credits + credits;
        }

        
    }

    class Hand
    {
        public List<Card> cards = new List<Card>();

        public int Total { get
            {
                int highValue = 0;
                int lowValue = 0;
                int totalValue;

                foreach (var card in cards)
                {
                    highValue = card.highValue + highValue;
                    lowValue = card.lowValue + lowValue;
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
            } }

        public void AddCard(Card tempCard)
        {
            cards.Add(tempCard);
        }

        public bool validHand()
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
