using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesOOP
{
    public class dice
    {
        int min;
        int max;
        int faceValue;
        public int FaceValue { get { return faceValue; } }

        public dice()
        {
            min = 1;
            max = 6;
            Roll();
        }

        //public dice(int max)
        //    :this()
        //{
        //    if (max > min && max< 21)
        //    {
        //        this.max = max;
        //    }
        //    else throw new ArgumentOutOfRangeException(nameof(max), "maximum is not a valid value");
        //}

        //public dice(int min, int max)
        //    :this(max)
        //{
        //    if (min > 0 && min < this.max)
        //    {
        //        this.min = min;
        //    }
        //    else throw new ArgumentOutOfRangeException(nameof(min), "minimum is not a valid value");

        //}

        public void Roll()
        {
            Random rng = new Random();

            this.faceValue = rng.Next(min, max + 1);
        }
    }
}
