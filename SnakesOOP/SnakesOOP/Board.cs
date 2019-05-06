using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakesOOP
{
    public class Board
    {
        public List<Square> squares = new List<Square>();

        public Board()
        {
            TestBoard();
        }

        public void TestBoard()
        {
            squares.Add(new Normal(1, 0));
            squares.Add(new Ladder(2, 10));
            squares.Add(new Normal(3, 0));
            squares.Add(new Normal(4, 0));
            squares.Add(new Normal(5, 0));
            squares.Add(new Snake(6, -3));
            squares.Add(new Normal(7, 0));
            squares.Add(new Normal(8, 0));
            squares.Add(new Normal(9, 0));
            squares.Add(new Ladder(10, 6));
            squares.Add(new Normal(11, 0));
            squares.Add(new Ladder(12, 4));
            squares.Add(new Normal(13, 0));
            squares.Add(new Normal(14, 0));
            squares.Add(new Snake(15, -3));
            squares.Add(new Normal(16, 0));
            squares.Add(new Normal(17, 0));
            squares.Add(new Snake(18, -7));
            squares.Add(new Normal(19, 0));
            squares.Add(new Normal(20, 0));
            squares.Add(new Normal(21, 0));
            squares.Add(new Normal(22, 0));
            squares.Add(new Normal(23, 0));
            squares.Add(new Normal(24, 0));
            squares.Add(new Normal(25, 0));
            squares.Add(new Normal(26, 0));
            squares.Add(new Normal(27, 0));
            squares.Add(new Normal(28, 0));
            squares.Add(new Normal(29, 0));
            squares.Add(new Normal(30, 0));
            squares.Add(new Normal(31, 0));
            squares.Add(new Normal(32, 0));
            squares.Add(new Normal(33, 0));
            squares.Add(new Final(34, 0));
        }
    }


}
