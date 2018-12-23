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
    class SamosvalCar :  GruzCar, IComparable<SamosvalCar>, IEquatable<SamosvalCar>
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
        }        public SamosvalCar(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Toner = Convert.ToBoolean(strs[4]);
                WhellColor = Color.FromName(strs[5]);
                Kuzovsize = Convert.ToInt32(strs[6]);
                Line = Convert.ToBoolean(strs[7]);
            }
        }


        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Pen bpen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            Brush kuzov = new SolidBrush(DopColor);
            Brush whellc = new SolidBrush(DopColor);
            Brush white = new SolidBrush(Color.White);
            Brush toner = new SolidBrush(DopColor);
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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name + ";" + DopColor.Name + ";" + Toner + ";" +
           WhellColor.Name + ";" + Kuzovsize + ";" + Line;
        }

        public int CompareTo(SamosvalCar other)
        {
            var res = (this is GruzCar).CompareTo(other is GruzCar);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Toner != other.Toner)
            {
                return Toner.CompareTo(other.Toner);
            }
            if (Kuzovsize != other.Kuzovsize)
            {
                return Kuzovsize.CompareTo(other.Kuzovsize);
            }
            if (Line != other.Line)
            {
                return Line.CompareTo(other.Line);
            }            
            return 0;
        }
        public bool Equals(SamosvalCar other)
        {
            var res = (this as GruzCar).Equals(other as GruzCar);
            if (!res)
            {
                return res;
            }
       /*     if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Toner != other.Toner)
            {
                return false;
            }
            if (Kuzovsize != other.Kuzovsize)
            {
                return false;
            }
            if (Line != other.Line)
            {
                return false;
            }           */
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            SamosvalCar carObj = obj as SamosvalCar;
            if (carObj == null)
            {
                return Equals(obj as GruzCar);
            }
            else
            {
            return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
