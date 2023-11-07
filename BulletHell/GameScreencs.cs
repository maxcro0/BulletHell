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
        double healthBar = 338;
        double healthRatio;
        string healthbarText;
        int maxHealth = 400;
        string moveDirection = "right";

        Player me;
        Enemy1 boss;
        ProjectileCircle projectile;
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush blueBrush = new SolidBrush(Color.SlateBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        public static bool col = false;
        bool goLeft = true;
        bool goUp = false;
        bool shooting = false;
        bool bombing = false;
        bool justDied;
        List<ProjectileCircle> projectiles = new List<ProjectileCircle>();
        List<StringProjectile> friendProjectiles = new List<StringProjectile>();
        int attack1Timer = 0;
        int attack2Timer = 0;
        int invulTimer = 0;
        int shotTimer = 0;
        bool phase1 = true;
        bool phase2 = false;
        bool phase3 = false;
        bool phase3initial = false;
        Point[] arrow;
        public Point phase2attack1;
        public Point phase2attack2;

        private void label1_Click(object sender, EventArgs e)
        {

        }



        List<ProjectileCircle> Projectile = new List<ProjectileCircle>();


        public GameScreencs()
        {
            InitializeComponent();
            me = new Player(175, 415, 4, 4);
            boss = new Enemy1(153, 25, 2, 2);
            arrow = new Point[] { new Point(boss.x, 445), new Point(boss.xCenter, 435), new Point(boss.x + boss.width, 445) };
            phase2attack1 = new Point(45, 35);
            phase2attack2 = new Point(405, 35);
            healthRatio = healthBar / boss.health;


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
                    me.ySpeed = 2;
                    me.xSpeed = 2;
                    break;
                case Keys.Space:
                    shooting = true;
                    break;
                case Keys.V:
                    bombing = true;
                    break;






            }
        }

        private void deleteProjectiles()
        {
            foreach (ProjectileCircle p in projectiles)
            {
                if (p.x < -5)
                {
                    projectiles.Remove(p);
                    break;
                }

                if (p.x > 355)
                {
                    projectiles.Remove(p);
                    break;
                }

                if (p.y < 0)
                {
                    projectiles.Remove(p);
                    break;
                }

                if (p.y > 675)
                {
                    projectiles.Remove(p);
                    break;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            attack1Timer++;

            if (justDied == true)
            {
                invulTimer++;
            }
            if (invulTimer == 25)
            {
                invulTimer = 0;
                justDied = false;
            }

            if (boss.health <= 0 && phase1 == true)
            {
                phase1 = false;
                phase2 = true;
                boss.health = 2000;
                maxHealth = boss.health;
                healthRatio = healthBar / boss.health;
            }
            if (boss.health <= 0 && phase2 == true)
            {
                phase2 = false;
                phase3 = true;
                boss.health = 800;
                maxHealth = boss.health;
                healthRatio = healthBar / boss.health;
            }

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

            if (shooting == true)
            {
                shotTimer++;
                if (shotTimer == 2)
                {
                    StringProjectile p = new StringProjectile(me.x + me.size / 2, me.y, 20, 20, 3, 5);
                    friendProjectiles.Add(p);
                    shotTimer = 0;
                }
            }

            //if (bombing == true)
            //{
            //    Rectangle bombBox = new Rectangle();
            //}




            foreach (ProjectileCircle p in projectiles)
            {
                p.Move();

                if (justDied == false)
                {

                    if (p.Collision(me))
                    {

                        //make some circles explode from player location

                        me.x = 174;
                        me.y = 415;
                        justDied = true;
                        break;
                    }
                }

            }

            foreach (StringProjectile p in friendProjectiles)
            {
                p.Move("up");
                if (p.Collision(boss))
                {
                    boss.health -= 1;
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

                }

                if (attack1Timer == 20)
                {
                    projectiles.AddRange(boss.attack1());
                    attack1Timer = 0;
                }
                deleteProjectiles();

            }
            if (phase2 == true)
            {
                attack2Timer++;

                if (boss.xCenter > 225 - boss.width)
                {
                    boss.Move("left");
                }

                if (boss.xCenter < 225 - boss.width)
                {
                    boss.Move("right");
                }

                if (boss.yCenter < 200)
                {
                    boss.Move("down");
                }

                if (boss.yCenter > 200)
                {
                    boss.Move("up");
                }

                if (boss.xCenter == 176 && boss.yCenter == 200)
                {
                    if (attack2Timer == 45)
                    {
                        projectiles.AddRange(boss.attack2());
                        attack1Timer = 0;


                    }
                    if (attack2Timer > 45)
                    {
                        attack2Timer = 0;
                    }
                }



            }

            if (phase3 == true)
            {
                if (moveDirection == "right" && boss.x > 250)
                {
                    moveDirection = "down";
                }

                if (moveDirection == "down" && boss.y >= 250)
                {
                    moveDirection = "left";
                }

                if (moveDirection == "left" && boss.x <=50)
                {
                    moveDirection = "up";
                }

                if ((moveDirection == "up" && boss.y >=250 ))
                {
                    moveDirection = "right";
                }

                //
                //
                //

                boss.Move(moveDirection);

                //if (phase3initial == false)
                //{
                //    if (boss.yCenter > 100)
                //    {
                //        goUp = true;
                //    }
                //    if (boss.yCenter < 100)

                //    if (boss.xCenter < 400 - boss.width)
                //    {
                //        goLeft = false;
                //    }
                //}
                //if (boss.yCenter == 100 && boss.xCenter == 400-boss.width && phase3initial == false)
                //{
                //    phase3initial = true;
                //}

                //if (boss.y == 100 && phase3initial == true)
                //{
                //    if (boss.xCenter >= 400 - boss.width)
                //    {
                //        goLeft = true;
                //    }

                //    if (boss.x <= 0 + boss.width)
                //    {
                //        goLeft = false;
                //        goUp = false;
                //    }


                //    if (goLeft == true)
                //    {
                //        boss.Move("left");
                //    }

                //    if (goLeft == false)
                //    {
                //        boss.Move("right");
                //    }

                //    if (goUp == true)
                //    {
                //        boss.Move("up");
                //    }
                //    if (goUp == false)
                //    {
                //        boss.Move("down");
                //    }
                //}

            }

            arrow = new Point[] { new Point(boss.x, 445), new Point(boss.xCenter, 435), new Point(boss.x + boss.width, 445) };


            Refresh();
        }

        private void colorBox_Click(object sender, EventArgs e)
        {

        }

        private void GameScreencs_Paint(object sender, PaintEventArgs e)
        {

            //Shows player life
            livesOut.Text = me.lives + "";


            // Shows Health Bar

            healthbarText = ($"{boss.health} / {maxHealth}");
            e.Graphics.FillRectangle(grayBrush, 0, 20, 338, 20);
            e.Graphics.FillRectangle(redBrush, 0, 25, (int)(boss.health * healthRatio), 10);
            e.Graphics.DrawString(healthbarText, new Font("Arial", 10), whiteBrush, 155, 20);
            //Shows Bomb
            bombsOut.Text = me.bomb + "";

            //Shows Points
            pointsOut.Text = points + "";

            //Shows Graze
            grazeOut.Text = graze + "";
            e.Graphics.FillPolygon(whiteBrush, arrow);
            e.Graphics.FillEllipse(redBrush, me.x, me.y, me.size, me.size);

            //Show Boss
            e.Graphics.FillEllipse(yellowBrush, boss.x, boss.y, boss.height, boss.width);


            foreach (ProjectileCircle p in projectiles)
            {
                e.Graphics.FillEllipse(blueBrush, p.x, p.y, p.size, p.size);
            }
            foreach (StringProjectile p in friendProjectiles)
            {
                e.Graphics.FillRectangle(whiteBrush, p.x, p.y, p.width, p.height);

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
                case Keys.Space:
                    shooting = false;
                    break;


            }
        }

        private void GameScreencs_Load(object sender, EventArgs e)
        {

        }


    }
}
