using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BulletHell
{
    internal class StringProjectile
    {
        public int width, height;
        public float x, y, xSpeed, ySpeed;
        public int speed;


        public StringProjectile(float _x, float _y, float _xSpeed, float _ySpeed, int _width, int _height)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            width = _width;
            height = _height;
        }
        public void Move()
        {
            x += xSpeed * speed;
            y += ySpeed * speed;           
        }

        public void Collision(Enemy1 e)
        {
            int xBox = (int)Math.Round(x);
            int yBox = (int)Math.Round(y);
            Rectangle enemyRec = new Rectangle(e.x, e.y, e.width, e.height);
            Rectangle projectileRec = new Rectangle(xBox, yBox, width, height);

            if (projectileRec.IntersectsWith(enemyRec))
            {
                Enemy1.health -= 100;
            }
            
        }
    }

  
    }



