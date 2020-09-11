using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.Classes
{
    public class Bird
    {
        public Transform transform;
        int framesCount = 0;
        int animationCount = 0;

        public Bird(PointF pos, Size size)
        {
            transform = new Transform(pos, size);
        }

        public void DrawSprite(Graphics g)
        {
            framesCount++;
            if (framesCount <= 10)
                animationCount = 0;
            else if (framesCount > 10 && framesCount <= 20)
                animationCount = 1;
            else if (framesCount > 20)
                framesCount = 0;

            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), 264+92*animationCount, 6, 83, 71, GraphicsUnit.Pixel);
        }
    }
}
