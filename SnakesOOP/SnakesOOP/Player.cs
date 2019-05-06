using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesOOP
{
    class Player
    {
        //Fields
        private string name;
        private string colour;
        private bool winner;
        private int location;

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

        public int Location
        {
            get { return location; }
            set { this.location = value; }
        }

        //Constructors
        public Player()
        {
            this.winner = false;
        }

        public Player(string name, string colour)
            : this()
        {
            this.name = name;
            this.colour = colour;
        }

        //Methods
    }
}
