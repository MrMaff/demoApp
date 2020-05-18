using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    

    class Dealer : Player
    {

        public Moves TakeTurn()
        {
            Moves dealerMove = Moves.Stick;

            if (this.hand.ValidHand())
            {
                if (this.hand.Total < 16)
                {
                    dealerMove = Moves.Hit;
                }
                else dealerMove = Moves.Stick;
            }
            else dealerMove = Moves.Bust;

            return dealerMove;
        }
       
    }
}
