using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class Enemy1
    {

        public int height = 30;
        public int width = 30;
        public int x, y, xSpeed, ySpeed;
        public int health = 400;
        public int xCenter;
        public int yCenter;

        List<ProjectileCircle> attack1List;


        public Enemy1(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            xCenter = x+width/2;
            yCenter = y+height/2;
            
        }

        public List<ProjectileCircle> attack1()
        {
            attack1List = new List<ProjectileCircle>(); ;
           

            for (int i = 0; i < 360; i += 10)
            {
                //theta measure for angle of fire, (float uses less memory)
                // float thetaAngle = (90 - hero.angle);
                float thetaAngle = (90 - i);


                // determine the end point for each hand (result must be a double)
                double xStep = Math.Cos(thetaAngle * Math.PI / 180.0);
                double yStep = Math.Sin(thetaAngle * Math.PI / 180.0);

                //  //bullet object requires float values to draw on screen
                //  ProjectileCircle p = new ProjectileCircle(x, y, size, bulletSpeed, (float)xStep, (float)-yStep);
                ProjectileCircle p = new ProjectileCircle(xCenter,yCenter, (float)xStep, (float)yStep, 8, 3);
                attack1List.Add(p);
            }

            return attack1List;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= xSpeed;
                xCenter-=xSpeed;
            }
            else if (direction == "right")
            {
                x += xSpeed;
                xCenter += xSpeed;
            }

            if (direction == "up")
            {
                y -= ySpeed;
                yCenter-=ySpeed;
            }
            else if (direction == "down")
            {
                y += ySpeed;
                yCenter += ySpeed;
            }
        }

    }
}
