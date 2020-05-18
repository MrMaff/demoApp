using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shaker
{
    class BoardDrawer
    {
        private Image[] dotImages = {   Properties.Resources.die1,
                                Properties.Resources.die2,
                                Properties.Resources.die3,
                                Properties.Resources.die4,
                                Properties.Resources.die5,
                                Properties.Resources.die6 };

        private Image felt = Properties.Resources.felt;

        private Bitmap board;

        public BoardDrawer()
        {
            board = new Bitmap(400, 400);
        }

        public BoardDrawer(int x, int y)
        {
            board = new Bitmap(x, y);
        }

        public Bitmap DrawBoard()
        {
            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(felt, 0, 0, board.Width, board.Height);
            }

                return board;
        }

        public Bitmap DrawBoard(int die1)
        {
            using (Graphics g = Graphics.FromImage(board))
            {
                int dieX = board.Width / 3;
                int dieY = board.Height / 3;

                g.DrawImage(felt, 0, 0, board.Width, board.Height);
                g.DrawImage(dotImages[die1 - 1], dieX , dieY, dieX, dieY);
            }

            return board;
        }

        public Bitmap DrawBoard(int die1, int die2)
        {
            using (Graphics g = Graphics.FromImage(board))
            {
                int dieX = board.Width / 3;
                int dieY = board.Height / 3;

                int[] die = { die1, die2 };

                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < 2; i++)
                {
                    g.DrawImage(dotImages[die[i] - 1], dieX * (i), dieY * (i), dieX, dieY);

                }
                
            }

            return board;
        }

        public Bitmap DrawBoard(int die1, int die2, int die3)
        {
            using (Graphics g = Graphics.FromImage(board))
            {
                int dieX = board.Width / 3;
                int dieY = board.Height / 3;

                int[] die = { die1, die2, die3};

                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < 3; i++)
                {
                    g.DrawImage(dotImages[die[i] - 1], dieX * (i), dieY * (i), dieX, dieY);
                }

            }

            return board;
        }


    }
}
