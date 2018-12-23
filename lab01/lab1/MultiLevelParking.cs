﻿using System;
using System.Collections.Generic;
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
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<I_Transport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<I_Transport>(countPlaces, pictureWidth,
               pictureHeight));
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
    }
}
