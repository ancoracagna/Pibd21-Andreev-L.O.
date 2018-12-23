using NLog;
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
        MultiLevelParking parking;        FormGruzConfig form;        private const int countLevel = 5;        private Logger logger;
        private GruzCar samosval;
        public FormCar()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            form = new FormGruzConfig();
            form.AddEvent(AddCar);
            form.Show();
        }
        private void AddCar(I_Transport car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                try {
                    int place = parking[listBoxLevels.SelectedIndex] + car;
                    logger.Info("Добавлен автомобиль " + car.ToString() + " на место " +
                    place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}