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

        public void RemoveCredit()
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

        public void RemoveCredit(int credits)
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

    
}
