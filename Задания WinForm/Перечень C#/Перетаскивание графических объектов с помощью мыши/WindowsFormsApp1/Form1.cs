using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);

        bool RectangleClicked = false;
        bool CircleClicked = false;
        bool SquareClicked = false;

        int RectangleX;
        int RectangleY;
        int CircleX;
        int CircleY;
        int SquareX;
        int SquareY;

        int X, Y, dX, dY;
        int LastClicked = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);

            if (RectangleClicked == true)
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
            else if (CircleClicked == true)
                e.Graphics.FillEllipse(Brushes.Red, Circle);
            else if (SquareClicked == true)
                e.Graphics.FillRectangle(Brushes.Blue, Square);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X) && (e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
            {
                RectangleClicked = true;
                RectangleX = e.X - Rectangle.X;
                RectangleY = e.Y - Rectangle.Y;
                pictureBox1.Invalidate();
            }
            else if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X) && (e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
            {
                CircleClicked = true;
                CircleX = e.X - Circle.X;
                CircleY = e.Y - CircleY;
                pictureBox1.Invalidate();
            }
            else if ((e.X < Square.X + Square.Width) && (e.X > Square.X) && (e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
            {
                SquareClicked = true;
                SquareX = e.X - Square.X;
                SquareY = e.Y - Square.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (RectangleClicked)
            {
                LastClicked = 1;
                RectangleClicked = false;
            } 
            else if (CircleClicked)
            {
                LastClicked = 2;
                CircleClicked = false;
            }
            else if (SquareClicked)
            {
                LastClicked = 3;
                SquareClicked = false;
            }

            if (LastClicked == 2 
                && (label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X) 
                && (label2.Location.Y < Circle.Y + Circle.Height) 
                && (label2.Location.Y > Circle.Y))
            {
                X = Circle.X;
                Y = Circle.Y;
                dX = CircleX;
                dY = CircleY;

                Circle.X = Square.X;
                Circle.Y = Square.Y;
                CircleX = SquareX;
                CircleY = SquareY;

                Square.X = X;
                Square.Y = Y;
                SquareX = dX;
                SquareY = dY;
            }
            else if (LastClicked == 3
                && (label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X)
                && (label2.Location.Y < Square.Y + Square.Height)
                && (label2.Location.Y > Square.Y))
            {
                X = Square.X;
                Y = Square.Y;
                dX = SquareX;
                dY = SquareY;

                Square.X = Circle.X;
                Square.Y = Circle.Y;
                SquareX = CircleX;
                SquareY = CircleY;

                Circle.X = X;
                Circle.Y = Y;
                CircleX = dX;
                CircleY = dY;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (RectangleClicked)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
            }
            else if (CircleClicked)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }
            else if (SquareClicked)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
            }
            pictureBox1.Invalidate();

            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X) && (label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                    label3.Text = "Синий квадрат";
            else if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X) && (label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                    label3.Text = "Красный круг";
            else if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X) && (label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                    label3.Text = "Желтый прямоугольник";

        }
    }
}
