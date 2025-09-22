using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Width = 600;
            this.Height = 600;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Opret en blå pen med tykkelse 3
            Pen bluePen = new Pen(Color.Blue, 3);

            // Opret en rød pen med tykkelse 2  
            Pen redPen = new Pen(Color.Red, 2);

            // Firkantens position og størrelse
            int squareX = 150;
            int squareY = 200;
            int squareSize = 100;

            // Cirklens position og størrelse
            int circleX = 350;
            int circleY = 200;
            int circleSize = 80;

            // Tegn firkanten med DrawRectangle
            g.DrawRectangle(bluePen, squareX, squareY, squareSize, squareSize);

            // Tegn cirklen med DrawEllipse
            g.DrawEllipse(redPen, circleX, circleY, circleSize, circleSize);
        }
    }
}