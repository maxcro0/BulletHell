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
        public int xCenter;
        public int yCenter;
        public float angle;
        public float newAngle;

        public ProjectileCircle(float _x, float _y, float _xSpeed, float _ySpeed, int _size, int _speed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _size;
            speed = _speed;
            xCenter = (int)x + size / 2;
            yCenter = (int)y + size / 2;
        }
        public ProjectileCircle(float _x, float _y, float _xSpeed, float _ySpeed, int _size, int _speed, float _angle)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _size;
            speed = _speed;
            angle = _angle;
            newAngle = _angle;
            xCenter = (int)x + size / 2;
            yCenter = (int)y + size / 2;
        }

        public void Move()
        {
            x += xSpeed * speed;
            y += ySpeed * speed;

            if (x < 0 || x > 625 - size)
            {
                //remove projectile
            }

            if (y < 0 || y > 500 - size)
            {
                //remove projectile
            }


        }
        public void Move2()
        {
            x += xSpeed * speed;
            y += ySpeed * speed;

            //theta measure for angle of fire, (float uses less memory)
            // float thetaAngle = (90 - hero.angle);

            newAngle += 2;

            if (newAngle > angle + 180)
            {
                newAngle -= 2;
            } 



            // determine the end point for each hand (result must be a double)
            xSpeed = (float)(Math.Cos(newAngle * Math.PI / 180.0));

            ySpeed = (float)(Math.Sin(newAngle * Math.PI / 180.0));

            //  //bullet object requires float values to draw on screen


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
            Rectangle projectileRec = new Rectangle(xBox + 2, yBox + 2, size - 4, size - 4);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.size, p.size);
            Rectangle playerGrazeRec = new Rectangle(p.x + 10, p.y + 10, p.size + 10, p.size + 10);

            if (projectileRec.IntersectsWith(playerRec))
            {




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
