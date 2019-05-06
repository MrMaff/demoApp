using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesOOP
{
    public class DiceRoller
    {
        private bool doubleRule = true;
        public dice Dice1 { get; } = new dice();
        public dice Dice2 { get; } = new dice();
        public dice Dice3 { get; } = new dice();

        public DiceRoller()
        {
        }

        public DiceRoller(bool doubleRule)
        {
            this.doubleRule = doubleRule;
        }

        public int GetDiceRoll()
        {
            int total;
            Dice1.Roll();
            Dice2.Roll();
            total = Dice1.FaceValue + Dice2.FaceValue;

            if (doubleRule == true)
            {
                if (Dice1.FaceValue == Dice2.FaceValue)
                {
                    Dice3.Roll();
                    total = total + Dice3.FaceValue;
                }
            }

            return total;
        }
    }
}
