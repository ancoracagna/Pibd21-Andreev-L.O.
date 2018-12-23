using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class FormCar : Form
    {
        private GruzCar samosval;
        public FormCar()
        {
            InitializeComponent();
        }

        private void FormCar_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            samosval = new GruzCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow);
           samosval.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), PicSamosval.Width,
           PicSamosval.Height);
            Draw();          }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(PicSamosval.Width, PicSamosval.Height);
            Graphics gr = Graphics.FromImage(bmp);
            samosval.DrawCar(gr);
            PicSamosval.Image = bmp;
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    samosval.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    samosval.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    samosval.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    samosval.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            samosval = new SamosvalCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,
           Color.Yellow, true, 2, true);
            samosval.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), PicSamosval.Width,
           PicSamosval.Height);
            Draw();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            samosval = new SamosvalCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,
           Color.Yellow, true, 2, true);
            samosval.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), PicSamosval.Width,
           PicSamosval.Height);
            Draw();
        }
    }
}
