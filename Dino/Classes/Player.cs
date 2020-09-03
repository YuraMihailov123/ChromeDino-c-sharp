using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dino.Classes
{
    public class Player
    {
        public Physics physics;
        public Player(PointF position, Size size)
        {
            physics = new Physics(position, size);
        }

        public void DrawSprite(Graphics g)
        {

        }
    }
}
