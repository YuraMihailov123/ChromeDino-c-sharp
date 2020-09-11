using Dino.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    public partial class Form1 : Form
    {
        Player player;
        Timer mainTimer;

        public Form1()
        {
            InitializeComponent();

            this.Width = 700;
            this.Height = 300;
            this.Text = "Chrome Dino";
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(DrawGame);
            this.KeyUp += new KeyEventHandler(OnKeyboardUp);
            this.KeyDown += new KeyEventHandler(OnKeyboardDown);
            mainTimer = new Timer();
            mainTimer.Interval = 10;
            mainTimer.Tick += new EventHandler(Update);
            GameController.Init();
            Init();
        }

        private void OnKeyboardDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (!player.physics.isJumping)
                        player.physics.isCrouching = true;
                    break;
            }
        }

        private void OnKeyboardUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (!player.physics.isCrouching)
                        player.physics.AddForce();
                    break;
                case Keys.Down:
                    player.physics.isCrouching = false;
                    break;
            }
        }

        public void Init()
        {
            player = new Player(new PointF(50, 149), new Size(50, 50));
            mainTimer.Start();
            Invalidate();
        }

        public void Update(object sender, EventArgs e)
        {
            player.physics.ApplyPhysics();
            GameController.MoveMap();
            Invalidate();
        }

        private void DrawGame(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            player.DrawSprite(g);
            GameController.DrawObjects(g);
        }
    }
}
