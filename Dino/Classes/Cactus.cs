using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.Classes
{
    public class Cactus
    {
        public Transform transform;
        int srcX = 0;

        public Cactus(PointF pos,Size size)
        {
            transform = new Transform(pos, size);
            ChooseRandomPic();
        }

        public void ChooseRandomPic()
        {
            Random r = new Random();
            int rnd = r.Next(0, 4);
            switch (rnd)
            {
                case 0:
                    srcX = 754;
                    break;
                case 1:
                    srcX = 804;
                    break;
                case 2:
                    srcX = 704;
                    break;
                case 3:
                    srcX = 654;
                    break;
            }
        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), srcX, 0, 48, 100, GraphicsUnit.Pixel);
        }
    }
}
