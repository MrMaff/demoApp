using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace SnakesOOP
{
    public class DiceRoller
    {
        private bool doubleRule = true;
        public Dice Dice1 { get; } = new Dice();
        public Dice Dice2 { get; } = new Dice();
        public Dice Dice3 { get; } = new Dice();

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

    public class ShakerBoard
    {
        private Image[] dice = new Image[] { Properties.Resources.die1, Properties.Resources.die2, Properties.Resources.die3, Properties.Resources.die4, Properties.Resources.die5, Properties.Resources.die6 };

       
    }
}
