using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class SamosvalCar :  GruzCar
    {        
        public Color DopColor { private set; get; }
        public bool Toner { private set; get; }
        public Color  WhellColor { private set; get; }
        public double Kuzovsize { private set; get; }
        public bool Line { private set; get; }

        public SamosvalCar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       toner, double kuzovsize, bool line) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Toner = toner;
            Kuzovsize = kuzovsize;
            Line = line;
        }       
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Pen bpen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            Brush kuzov = new SolidBrush(DopColor);
            Brush whellc = new SolidBrush(WhellColor);
            Brush white = new SolidBrush(Color.White);
            Brush toner = new SolidBrush(Color.Black);
            base.DrawCar(g);
            //g.DrawRectangle(pen, _startPosX + 80, _startPosY -6, 80, 40);
            //g.FillRectangle(brush, _startPosX + 80, _startPosY -6, 80, 40);
            if (Toner)
            {
                g.DrawRectangle(pen, _startPosX + 55, _startPosY, 15,15);
                g.FillRectangle(toner,_startPosX + 55, _startPosY, 15, 15);
            }
            if (Line)
            {
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 15, 80, 10);
                g.FillRectangle(kuzov, _startPosX + 80, _startPosY + 15, 80, 10);
            }
            if (Kuzovsize != 0)
            {
                g.DrawRectangle(pen, _startPosX + 80, _startPosY - 6, 80 * (int)Kuzovsize, 40);
                g.FillRectangle(brush, _startPosX + 80, _startPosY - 6, 80 * (int)Kuzovsize, 40);
            }
        }
    }
}
