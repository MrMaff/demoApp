using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace DrawingAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            float turtleX = e.X - Width / 2 + 8;
            float turtleY = Height / 2 - e.Y - 19;


            string selectedItem = (string)comboBox1.SelectedItem;

            switch (selectedItem)
            {
                case "Draw Triangle":
                    EquilateralTriangle tri = new EquilateralTriangle(turtleX, turtleY, 150);
                    DrawTriangle(tri);
                    break;
                case "Draw Rectangle":
                    Rectangle rec = new Rectangle(turtleX, turtleY, 100, 50);
                    DrawRectangle(rec);
                    break;
                default:
                    break;
            }
        }


        private void DrawTriangle(EquilateralTriangle tri)
        {

            //Set up turtle
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.X = tri.XOrigin;
            Turtle.Y = tri.YOrigin;
            Turtle.Angle = 0;

            //Draw Triangle
            Turtle.Rotate(30);
            for (int i = 1; i <= 3; i++)
            {
                Turtle.Forward(tri.SideLength);
                Turtle.Rotate(120);
            }
        }

        private void DrawRectangle(Rectangle rec)
        {

            //Set up turtle
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.X = rec.XOrigin;
            Turtle.Y = rec.YOrigin;
            Turtle.Angle = 0;

            //Draw Rectangle
            //Turtle.Rotate(90);
            for (int i = 1; i <= 2; i++)
            {
                Turtle.Forward(rec.Height);
                Turtle.Rotate(90);
                Turtle.Forward(rec.Width);
                Turtle.Rotate(90);
            }
        }
    }
}
