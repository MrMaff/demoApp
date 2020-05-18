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

            if (this.hand.validHand())
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
        //Deal 1st Cards
        //Deal Dealer 2nd Card
        //Players Place Bets
        //Deal 2nd Card
        //Player Hits or Sticks

        //if Player is 21 then Player gets stake X 2.5
        //If Player is bust - round ends
        //Else Dealer Hits or Sticks

    }
}
