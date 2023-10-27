using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class ProjectileCircle
    {
        public int size = 10;
        public float x, y, xSpeed, ySpeed;
        public int speed;

        public ProjectileCircle(float _x, float _y, float _xSpeed, float _ySpeed, int _size, int _speed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _size;
            speed = _speed;

        }


        public void Move()
        {
            x += xSpeed*speed;
            y += ySpeed*speed;

            if (x < 0 || x > 625 - size)
            {
                //remove projectile
            }

            if (y < 0 || y > 500 - size)
            {
                //remove projectile
            }
        }
        public bool Collision(Player p)
        {
            int xBox = (int)Math.Round(x);
            int yBox = (int)Math.Round(y);
            Rectangle projectileRec = new Rectangle(xBox, yBox, size, size);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.size, p.size);
            Rectangle playerGrazeRec = new Rectangle(p.x+10, p.y+10, p.size+10, p.size+10);

            if (projectileRec.IntersectsWith(playerRec))
            {

                p.lives--;


                return true;
            }

            if (projectileRec.IntersectsWith(playerGrazeRec))
            {
                GameScreencs.graze++;
            }

            return false;
        }
    }
}
