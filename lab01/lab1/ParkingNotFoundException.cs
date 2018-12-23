using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    // exception: не найден авто по месту
    class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден автомобиль по месту " +
i)
        { }
    }
}
