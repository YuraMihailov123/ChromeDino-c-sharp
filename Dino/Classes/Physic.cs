using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dino.Classes
{
    public class Physics
    {
        public Transform transform;
        float gravity;
        float a;

        public bool isJumping;
        public bool isCrouching;

        public Physics(PointF position, Size size)
        {
            transform = new Transform(position, size);
            gravity = 0;
            a = 0.4f;
            isJumping = false;
            isCrouching = false;
        }

        public void ApplyPhysics()
        {
            CalculatePhysics();
        }

        public void CalculatePhysics()
        {
            if (transform.position.Y < 150 || isJumping)
            {
                transform.position.Y += gravity;
                gravity += a;

                //Collide();
            }
            if (transform.position.Y >= 150)
                isJumping = false;
        }

        /*public void Collide()
        {
            for (int i = 0; i < PlatformController.platforms.Count; i++)
            {
                var platform = PlatformController.platforms[i];
                if (transform.position.X + transform.size.Width / 2 >= platform.transform.position.X && transform.position.X + transform.size.Width / 2 <= platform.transform.position.X + platform.transform.size.Width)
                {
                    if (transform.position.Y + transform.size.Height >= platform.transform.position.Y && transform.position.Y + transform.size.Height <= platform.transform.position.Y + platform.transform.size.Height)
                    {
                        if (gravity > 0)
                        {
                            AddForce();
                            if (!platform.isTouchedByPlayer)
                            {
                                PlatformController.score += 20;
                                PlatformController.GenerateRandomPlatform();
                                platform.isTouchedByPlayer = true;
                            }
                        }
                    }
                }
            }
        }*/

        public void AddForce()
        {
            if (!isJumping)
            {
                isJumping = true;
                gravity = -10;
            }
        }
    }

}
