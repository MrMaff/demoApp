using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    public enum Moves { Bust, Hit, Stick};
    public enum GameStates { Win = 1, InPlay = 0, Lost = -1};

    class Game
    {
        private Deck deck;

        private HumanPlayer player1 = new HumanPlayer();
        private Dealer dealer = new Dealer();

        public GameStates GameState { get
            {
                GameStates tempState = GameStates.InPlay;
                if (player1.Credits >= 10)
                {
                    tempState = GameStates.Win;
                }
                if (player1.Credits == 0)
                {
                    tempState = GameStates.Lost;
                }

                return tempState;
            } }

        public Game()
        {
            deck = new Deck(3);
            deck.Shuffle();
        }

        public void PlayRound()
        {
            int playerStake = 1;
            Moves playerStatus;

            player1.RemoveCredit();

            //Deal 1st Card
            dealer.AddCard(deck.DealCard());
            player1.AddCard(deck.DealCard());

            Console.WriteLine(" The Dealer Holds: ");
            Console.WriteLine("{0} {1}\n", dealer.hand.cards[0].Face, dealer.hand.cards[0].Suit);
            Console.WriteLine("You Hold: ");
            DisplayHand(player1.hand);
            //Players Place Bets
            playerStake = IncreaseStake(playerStake, player1.Credits) + playerStake;

            //Deal 2nd Card
            dealer.AddCard(deck.DealCard());
            player1.AddCard(deck.DealCard());
            Console.WriteLine("You Hold: ");
            DisplayHand(player1.hand);

            //Player Hits or Sticks
            playerStatus = PlayerMove();

            if (playerStatus != Moves.Bust)
            //If Player is bust - round ends
            {
                if (player1.hand.Total == 21)
                {
                    //if Player is 21 then Player gets stake X 3
                    Console.WriteLine("21! You win the Hand");
                    player1.AddCredits(playerStake * 3);

                }
                else
                {
                    //Else Dealer Hits or Sticks

                    DealerMove();

                    if (dealer.hand.ValidHand())
                    {
                        if (player1.hand.Total > dealer.hand.Total)
                        {
                            player1.AddCredits(playerStake * 2);
                            Console.WriteLine("You win the Hand");
                        }
                        else { Console.WriteLine("The Dealer wins the hand."); }
                    }
                    else
                    {
                        Console.WriteLine("The Dealer is Bust.");
                        player1.AddCredits(playerStake);
                    }
                }
            }
            else { Console.WriteLine("You are Bust!"); }

            player1.hand.ClearHand();
            dealer.hand.ClearHand();
        }

        private void DisplayHand(Hand tempHand)
        {
            foreach (var card in tempHand.cards)
            {
                Console.WriteLine("{0} {1}", card.Face, card.Suit);
            }

        }

        public void DisplayPlayerCredits()
        {
            Console.WriteLine("Player 1 has {0} credits.", player1.Credits);
        }

        private Moves PlayerChoice()
        {
            int choice;

            do
            {
                Console.WriteLine("Do you want to:");
                Console.WriteLine("1 - Hit");
                Console.WriteLine("2 - Stick");

            } while (int.TryParse(Console.ReadLine(), out choice) == false || choice < 1 || choice > 2);


            return (Moves)choice;
        }

        private Moves PlayerMove()
        {
            Moves playerAction = PlayerChoice();

            while (player1.hand.ValidHand() && playerAction == Moves.Hit)
            {
                player1.AddCard(deck.DealCard());
                DisplayHand(player1.hand);
                if (player1.hand.ValidHand())
                {
                    playerAction = PlayerChoice();
                }
                else playerAction = Moves.Bust;
            }
            return playerAction;
        }

        private void DealerMove()
        {
            Console.WriteLine(" The Dealer Holds: ");
            DisplayHand(dealer.hand);

            Moves dealerStatus = dealer.TakeTurn();

            while (dealerStatus == Moves.Hit)
            {
                Console.WriteLine("The dealer will: {0}", dealerStatus);
                dealer.AddCard(deck.DealCard());
                DisplayHand(dealer.hand);
                dealerStatus = dealer.TakeTurn();
            }
            Console.WriteLine("The dealer will: {0}", dealerStatus);
        }

        private int IncreaseStake(int stake, int creditsAvailable)
        {
            int increase = 0;
            if (creditsAvailable > 0)
            {
                do
                {
                    Console.Write("Enter how much you want to increase your stake by (currently {0} - Max increase = {1}: ", stake, creditsAvailable);
                } while (int.TryParse(Console.ReadLine(), out increase)==false || increase < 0 || increase > creditsAvailable);
            }

            player1.RemoveCredit(increase);
            return increase;
        }

    }
}
