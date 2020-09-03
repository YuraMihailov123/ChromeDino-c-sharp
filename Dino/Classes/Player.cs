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
        Transform transform;
        public Player(PointF position, Size size)
        {
            transform = new Transform(position, size);
        }

        public void DrawSprite(Graphics g)
        {

        }
    }
}
