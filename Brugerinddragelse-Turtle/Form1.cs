using System;
using System.Drawing;
using System.Windows.Forms;

namespace Brugerinddragelse_Turtle
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

            // TODO: Opret en blå pen med tykkelse 3
            Pen bluePen = new Pen(______, ______);

            // TODO: Opret en rød pen med tykkelse 2  
            Pen redPen = new Pen(______, ______);

            // Firkantens position og størrelse
            int squareX = 150;
            int squareY = 200;
            int squareSize = 100;

            // Cirklens position og størrelse
            int circleX = 350;
            int circleY = 200;
            int circleSize = 80;

            // TODO: Tegn firkanten med DrawRectangle
            g.DrawRectangle(______, ______, ______, ______, ______);

            // TODO: Tegn cirklen med DrawEllipse
            g.DrawEllipse(______, ______, ______, ______, ______);
        }
    }
}