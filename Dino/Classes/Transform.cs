using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino.Classes
{
    public class Transform
    {
        public PointF position;
        public Size size;

        public Transform(PointF pos,Size size)
        {
            this.position = pos;
            this.size = size;
        }
    }
}
