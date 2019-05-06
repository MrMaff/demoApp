using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesOOP
{
    public abstract class Square
    {
        protected int number;
        protected string sqType;
        protected int action;
        protected List<Player> occupiers = new List<Player>();

        public int Action { get { return action; } }
        public int Number { get { return number; } }
        public string SqType { get { return sqType; } }

        public Square()
        { }

        public Square(int number)
        {
            this.number = number;
        }

        public void AddPlayer(Player currentPlayer)
        {
            currentPlayer.Location = this;
            occupiers.Add(currentPlayer);
        }

        public void RemovePlayer(Player currentPlayer)
        {
            occupiers.Remove(currentPlayer);
        }

        

    }

    public class Normal : Square
    {
        public Normal()
        {
            this.sqType = "N";
        }

        public Normal(int number, int action)
            : base(number)
        {
            if (action == 0)
            {
                this.action = action;
            }
            else throw new ArgumentOutOfRangeException(nameof(action), "final action is not a valid value");
            this.sqType = "N";
        }

    }

    public class Snake : Square
    {
        public Snake()
        {
            this.sqType = "S";
        }

        public Snake(int number, int action)
            : base(number)
        {
            if (action < 0)
            {
                this.action = action;
            }
            else throw new ArgumentOutOfRangeException(nameof(action), "snake action is not a negative value");
            this.sqType = "S";
        }

       
    }

    public class Ladder : Square
    {
        public Ladder()
        {
            this.sqType = "L";
        }

        public Ladder(int number, int action)
            : base(number)
        {
            if (action > 0)
            {
                this.action = action;
            }
            else throw new ArgumentOutOfRangeException(nameof(action), "Ladder action is not a positive value");
            this.sqType = "L";
        }

       
    }

    public class Final : Square
    {
        public Final()
        {
            this.sqType = "F";
        }

        public Final(int number, int action)
            : base(number)
        {
            if (action == 0)
            {
                this.action = action;
            }
            else throw new ArgumentOutOfRangeException(nameof(action), "final action is not a valid value");
            this.sqType = "F";
        }

        
    }
}
