using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaker
{
    class Roller
    {
        public int Total
        {
            get
            {

                int tempTotal = die1.Face + die2.Face;
                if (IsADouble())
                {
                    tempTotal = tempTotal + die3.Face;
                }
                return tempTotal;
            }
        }

        public readonly Die die1 = new Die();
        public readonly Die die2 = new Die();
        public readonly Die die3 = new Die();

        public void RollDice()
        {
            die1.Roll();
            die2.Roll();
            die3.Roll();
        }

        public bool IsADouble()
        {
            return die1.Face == die2.Face;
        }

    }

    class Die
    {
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public int Face { get; private set; }
        private byte sides = 6;

        public Die()
        {
            Roll();
        }

        public Die(byte sides)
        {
            if (sides > 1)
            {
                this.sides = sides;
                Roll();
            }
            else
            {
                throw new ArgumentOutOfRangeException("sides");
            }
        }

        public void Roll()
        {
            this.Face = rnd.Next(1, sides + 1);
        }
    }
}
