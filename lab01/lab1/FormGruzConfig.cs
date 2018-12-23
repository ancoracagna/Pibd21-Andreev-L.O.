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
    public partial class FormGruzConfig : Form
    {
        I_Transport car = null;

        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(-50, 25, pictureBoxCar.Width, pictureBoxCar.Height);
                car.DrawCar(gr);
                pictureBoxCar.Image = bmp;
            }
        }        private event carDelegate eventAddCar;
        public FormGruzConfig()
        {
            InitializeComponent();
            panel1.MouseDown += panelColor_MouseDown;
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
            buttonAdd.Click += delegate (System.Object o, System.EventArgs e) {
                eventAddCar?.Invoke(car);
                Close();
            };
        }
        public void AddEvent(carDelegate ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new carDelegate(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Грузовик":
                    car = new GruzCar(100, 500, Color.White);
                    break;
                case "Самосвал":
                    car = new SamosvalCar(100, 500, Color.White, Color.Black, true, 1, true);
                    break;
            }
            DrawCar();
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }        
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                if (car is SamosvalCar)
                {
                    (car as SamosvalCar).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            labelGruz.DoDragDrop(labelGruz.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelSamosval_MouseDown(object sender, MouseEventArgs e)
        {
            labelSamosval.DoDragDrop(labelSamosval.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void pictureBoxCar_Click(object sender, EventArgs e)
        {

        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
