using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletHell
{
    public partial class GameScreencs : UserControl
    {
        public static int points;
        public static int graze;
        Player me;
        Enemy1 boss;
        ProjectileCircle projectile;
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush blueBrush = new SolidBrush(Color.SlateBlue);
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        public static bool col = false;
        bool goLeft = true;
        List<ProjectileCircle> projectiles = new List<ProjectileCircle>();
        int attack1Timer = 0;
        bool phase1 = true;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        List<ProjectileCircle> Projectile = new List<ProjectileCircle>();


        public GameScreencs()
        {
            InitializeComponent();
            me = new Player(175, 415, 5, 5);
            boss = new Enemy1(165, 25, 3, 3);
            projectiles = boss.attack1();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.W:
                    upArrowDown = true;
                    break;
                case Keys.S:
                    downArrowDown = true;
                    break;
                case Keys.ShiftKey:
                    me.ySpeed = 3;
                    me.xSpeed = 3;
                    break;



            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            attack1Timer++;



            if (leftArrowDown && me.x - 8 > 0)
            {
                me.Move("left");
            }
            else if (rightArrowDown && me.x + 152 < this.Width - me.size)
            {
                me.Move("right");
            }

            if (upArrowDown && me.y > 20)
            {
                me.Move("up");
            }
            else if (downArrowDown && me.y < this.Height - 25 - me.size)
            {
                me.Move("down");
            }



            foreach (ProjectileCircle p in projectiles)
            {
                p.Move();
                if (p.Collision(me))
                {

                    //make some circles explode from player location

                    me.x = 174;
                    me.y = 415;
                    break;
                }
                
            }

            if (phase1 == true)
            {
                if (boss.y < 200)
                {
                    boss.Move("down");
                }
                if (boss.y >= 200)
                {
                    if (boss.x <= 0)
                    {
                        goLeft = false;
                    }

                    if (boss.x >= 315)
                    {
                        goLeft = true;
                    }

                    if (goLeft == true)
                    {
                        boss.Move("left");
                    }

                    if (goLeft == false)
                    {
                        boss.Move("right");
                    }

                    if (attack1Timer * 1 == attack1Timer)
                    {
                        boss.attack1();
                    }



                }
               
                if (attack1Timer == 15)
                {
                    projectiles.AddRange(boss.attack1());
                    attack1Timer = 0;
                }
                foreach (ProjectileCircle p in projectiles)
                {
                    if (p.x < 0)
                    {
                        projectiles.Remove(p);
                        break;
                    }

                    if (p.x > 450)
                    {
                        projectiles.Remove(p);
                        break;
                    }

                    if (p.y < 0)
                    {
                        projectiles.Remove(p);
                        break;
                    }

                    if (p.y > 670)
                    {
                        projectiles.Remove(p);
                        break;
                    }
                }

            }

            Refresh();
        }

        private void colorBox_Click(object sender, EventArgs e)
        {

        }

        private void GameScreencs_Paint(object sender, PaintEventArgs e)
        {
            //Shows player life
            livesOut.Text = me.lives + "";

            //Shows Bomb
            bombsOut.Text = me.bomb + "";

            //Shows Points
            pointsOut.Text = points + "";

            //Shows Graze
            grazeOut.Text = graze + "";

            e.Graphics.FillEllipse(redBrush, me.x, me.y, me.size, me.size);
            e.Graphics.FillEllipse(yellowBrush, boss.x, boss.y, boss.height, boss.width);
            foreach (ProjectileCircle p in projectiles)
            {
                e.Graphics.FillEllipse(blueBrush, p.x, p.y, p.size, p.size);
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
                case Keys.W:
                    upArrowDown = false;
                    break;
                case Keys.S:
                    downArrowDown = false;
                    break;
                case Keys.ShiftKey:
                    me.ySpeed = 5;
                    me.xSpeed = 5;
                    break;

            }
        }

        private void GameScreencs_Load(object sender, EventArgs e)
        {

        }


    }
}
