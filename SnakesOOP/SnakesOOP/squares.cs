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
        protected string type;
        protected int action;
        protected List<Player> occupiers = new List<Player>();

        public int Number { get; }

        public Square()
        { }

        public Square(int number, int action)
        {
            this.number = number;
            this.action = action;
        }

        public abstract void Action();

        public void AddPlayer(Player currentPlayer)
        {
            currentPlayer.Location = this.number;
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
            this.type = "N";
        }

        public Normal(int number, int action)
            : base(number, action)
        {
            this.type = "N";
        }

        public override void Action()
        {
            //throw new NotImplementedException();
        }
    }

    public class Snake : Square
    {
        public Snake()
        {
            this.type = "S";
        }

        public Snake(int number, int action)
            : base(number, action)
        {
            this.type = "S";
        }

        public override void Action()
        {
            //throw new NotImplementedException();
        }
    }

    public class Ladder : Square
    {
        public Ladder()
        {
            this.type = "L";
        }

        public Ladder(int number, int action)
            : base(number, action)
        {
            this.type = "L";
        }

        public override void Action()
        {
            //throw new NotImplementedException();
        }
    }

    public class Final : Square
    {
        public Final()
        {
            this.type = "F";
        }

        public Final(int number, int action)
            : base(number, action)
        {
            this.type = "F";
        }

        public override void Action()
        {
            //throw new NotImplementedException();
        }
    }
}
