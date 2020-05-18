using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    public enum Suits { Heart, Spade, Diamond, Club};
    public enum Faces { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King}

    class Card
    {
        public int HighValue { get; }
        public int LowValue { get; }
        public  Suits Suit { get; }

        public Faces Face { get; }

        public Card()
        { }

        public Card(Suits suit, int cardNumber)
        {
            this.Suit = suit;
            switch (cardNumber)
            {
                case 1:
                    HighValue = 11;
                    LowValue = 1;
                    break;
                case 11:
                    HighValue = 10;
                    LowValue = 10;
                    break;
                case 12:
                    HighValue = 10;
                    LowValue = 10;
                    break;
                case 13:
                    HighValue = 10;
                    LowValue = 10;
                    break;

                default:
                    HighValue = cardNumber;
                    LowValue = cardNumber;
                    break;
            }
            this.Face = (Faces)cardNumber;
        }

    }
}
