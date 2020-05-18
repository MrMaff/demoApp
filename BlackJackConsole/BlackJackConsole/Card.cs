using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    public enum Suit { Heart, Spade, Diamond, Club};
    public enum Face { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King}

    class Card
    {
        public int highValue { get; }
        public int lowValue { get; }
        public  Suit suit { get; }

        public Face face { get; }

        public Card()
        { }

        public Card(Suit suit, int cardNumber)
        {
            this.suit = suit;
            switch (cardNumber)
            {
                case 1:
                    highValue = 11;
                    lowValue = 1;
                    break;
                case 11:
                    highValue = 10;
                    lowValue = 10;
                    break;
                case 12:
                    highValue = 10;
                    lowValue = 10;
                    break;
                case 13:
                    highValue = 10;
                    lowValue = 10;
                    break;

                default:
                    highValue = cardNumber;
                    lowValue = cardNumber;
                    break;
            }
            this.face = (Face)cardNumber;
        }

    }
}
