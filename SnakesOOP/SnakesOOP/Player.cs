using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesOOP
{
    public class Player
    {
        //Fields
        private string name;
        private string colour;
        private bool winner;
        private Square location;

        // Properties
        public string Name
        { get { return name; } }

        public string Colour
        { get { return colour; } }

        public bool Winner
        {
            get { return winner; }
            set { this.winner = value; }
        }

        public Square Location
        {
            get { return location; }
            set { this.location = value; }
        }

        //Constructors
        public Player()
        {
            this.winner = false;
            location = null;
        }

        public Player(string name, string colour)
            : this()
        {
            this.name = name;
            this.colour = colour;
        }

        //Methods
        public void Move(int roll, Board GameBoard)
        {
            int newSquareNumber;
            if (location == null)
            {
                newSquareNumber = roll;
            }
            else
            {
                newSquareNumber = location.Number + roll;
            }
            if (newSquareNumber > GameBoard.squares.Count)
            {
                newSquareNumber = GameBoard.squares.Count;
                //newSquareNumber =  newSquareNumber - (newSquareNumber - GameBoard.squares.Count);
            }
            if (location != null)
            {
                location.RemovePlayer(this);
            } 
            GameBoard.squares.ElementAt(newSquareNumber - 1).AddPlayer(this);
        }

        public void ApplyActions(Board GameBoard)
        {
            if (location.SqType == "F")
            {
                this.winner = true;
            }
            else
            {
                int newSquareNumber = location.Number + location.Action;
                if (newSquareNumber > GameBoard.squares.Count)
                {
                    newSquareNumber = newSquareNumber - (newSquareNumber - GameBoard.squares.Count);
                }
                location.RemovePlayer(this);
                GameBoard.squares.ElementAt(newSquareNumber - 1).AddPlayer(this);
            }
        }
    }
}
