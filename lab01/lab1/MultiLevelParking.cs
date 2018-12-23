using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class MultiLevelParking
    {
        List<Parking<I_Transport>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<I_Transport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<I_Transport>(countPlaces, pictureWidth,
               pictureHeight));
                // throw here 
            }
        }
        public Parking<I_Transport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    WriteToFile("CountLeveles:" + parkingStages.Count +
                   Environment.NewLine, fs);
                    foreach (var level in parkingStages)
                    {
                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            try
                            {
                                var car = level[i];
                                
                                    if (car.GetType().Name == "GruzCar")
                                    {
                                        WriteToFile(i + ":GruzCar:", fs);
                                    }
                                    if (car.GetType().Name == "SamosvalCar")
                                    {
                                        WriteToFile(i + ":SamosvalCar:", fs);
                                    }
                                    WriteToFile(car + Environment.NewLine, fs);                               
                            }
                            finally { }
                        }
                    }
                }
            }
            return true;
        }        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string path = filename;
            string bufferTextFromFile = "";
            // using (FileStream fs = new FileStream(filename, FileMode.Open)) 
            //{ 

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                int counter = -2;
                while ((bufferTextFromFile = sr.ReadLine()) != null)
                {
                    if (bufferTextFromFile.Contains("CountLeveles"))
                    {
                        //считываем количество уровней 
                        if (parkingStages != null)
                        {
                            parkingStages.Clear();
                        }
                        int count = Convert.ToInt32(bufferTextFromFile.Split(':')[1]);
                        parkingStages = new List<Parking<I_Transport>>(count);
                    }
                    else {
                        throw new Exception("Неверный формат файла");
                    }
                    I_Transport car = null;

                    //идем по считанным записям 
                    if (bufferTextFromFile.Contains("Level"))
                    {
                        //начинаем новый уровень 
                        counter++;
                        parkingStages.Add(new Parking<I_Transport>(countPlaces, pictureWidth,
                        pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(bufferTextFromFile))
                    {
                        continue;
                    }
                    if (bufferTextFromFile.Split(':')[1] == "GruzCar")
                    {
                        car = new GruzCar(bufferTextFromFile.Split(':')[2]);
                    }
                    else if (bufferTextFromFile.Split(':')[1] == "SamosvalCar")
                    {
                        car = new SamosvalCar(bufferTextFromFile.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(bufferTextFromFile.Split(':')[0])] = car;

                }
            }
            return true;
        }
        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}