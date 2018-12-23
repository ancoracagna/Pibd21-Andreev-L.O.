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
        MultiLevelParking parking;        private const int countLevel = 5;
        private GruzCar samosval;
        public FormCar()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, PicSamosval.Width, PicSamosval.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void FormCar_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            ColorDialog dialog = new ColorDialog();
            if (listBoxLevels.SelectedIndex > -1)
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    samosval = new GruzCar(rnd.Next(100, 300), rnd.Next(1000, 2000), dialog.Color);
                    int place = parking[listBoxLevels.SelectedIndex] + samosval;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(PicSamosval.Width,
                PicSamosval.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                PicSamosval.Image = bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ColorDialog dialog = new ColorDialog();
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new SamosvalCar(100, 1000, dialog.Color, dialogDop.Color, true, 1, true);
                        int place = parking[listBoxLevels.SelectedIndex] + car;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    var car = parking[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox1.Text);
                    if (car != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(-45, 15, pictureBoxTakeCar.Width,
                       pictureBoxTakeCar.Height);
                        car.DrawCar(gr);
                        pictureBoxTakeCar.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                       pictureBoxTakeCar.Height);
                        pictureBoxTakeCar.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > 0)
            {
                int index = listBoxLevels.SelectedIndex;
                listBoxLevels.SelectedIndex = index - 1;
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex < listBoxLevels.Items.Count-1)
            {
                int index = listBoxLevels.SelectedIndex;
                listBoxLevels.SelectedIndex = index + 1;
            }
        }
    }
}