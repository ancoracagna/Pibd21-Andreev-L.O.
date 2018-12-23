using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    interface I_Transport
    {
        void SetPosition(int x, int y, int width, int height);        void MoveTransport(Direction direction);
        void DrawCar(Graphics g);
    }
}
