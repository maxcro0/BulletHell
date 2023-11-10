using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class Enemy1
    {

        public int height = 50;
        public int width = 50;
        public int x, y, xSpeed, ySpeed;
        public int health = 400;
        public int xCenter;
        public int yCenter;
        int altEye;
        public int gapSwitch;
        List<ProjectileCircle> attack1List;
        List<ProjectileCircle> attack2List;
        public List<ProjectileCircle> attack2rotatorsList;


        public Enemy1(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            xCenter = x+width/2;
            yCenter = y+height/2;
            altEye = 30;
            gapSwitch = 37;
            
        }

        public List<ProjectileCircle> attack1()
        {
            attack1List = new List<ProjectileCircle>(); ;
           

            for (int i = 0; i < 360; i += 15)
            {
                //theta measure for angle of fire, (float uses less memory)
                // float thetaAngle = (90 - hero.angle);
                float thetaAngle = (90 - i);


                // determine the end point for each hand (result must be a double)
                double xStep = Math.Cos(thetaAngle * Math.PI / 180.0);
                double yStep = Math.Sin(thetaAngle * Math.PI / 180.0);

                //  //bullet object requires float values to draw on screen
                //  ProjectileCircle p = new ProjectileCircle(x, y, size, bulletSpeed, (float)xStep, (float)-yStep);
                ProjectileCircle p = new ProjectileCircle(xCenter,yCenter, (float)xStep, (float)yStep, 8, 3,thetaAngle);
                attack1List.Add(p);
            }

            return attack1List;
        }
        public List<ProjectileCircle> attack2()
        {
        Random randint = new Random();
            
            attack2List = new List<ProjectileCircle>(); ;


            for (int i = gapSwitch; i <= 500; i += altEye)
            {
                //theta measure for angle of fire, (float uses less memory)
                // float thetaAngle = (90 - hero.angle);
                float thetaAngle = (90 - i);


                // determine the end point for each hand (result must be a double)
                double xStep = Math.Cos(thetaAngle * Math.PI / 180.0);
                double yStep = Math.Sin(thetaAngle * Math.PI / 180.0);

                //  //bullet object requires float values to draw on screen
                //  ProjectileCircle p = new ProjectileCircle(x, y, size, bulletSpeed, (float)xStep, (float)-yStep);
                ProjectileCircle p = new ProjectileCircle(xCenter, yCenter, (float)xStep, (float)yStep, 8, 1, thetaAngle);
                attack2List.Add(p);
                if (altEye == 30)
                {
                    altEye = 15;
                }
                else
                {
                    altEye = 30;
                }
               if (gapSwitch == 37)
                {
                    gapSwitch = 77;
                }
               else
                {
                    gapSwitch = 37;
                }
            }

            

            for (int i = 0;i <50; i++)
            {
                int y0 = (randint.Next(0, 660));
                int x0 = randint.Next(1, 4);
                int randomX;
                
                int direction;

                if (x0 == 2)
                {
                    direction = 2;
                    randomX = 0;
                }
                else
                {
                    direction = -2;
                    randomX = 340;
                }
                
                ProjectileCircle p = new ProjectileCircle(randomX, y0, direction, 0, 6, 3);
                
                attack2List.Add(p);
            }
           

            for (int i = 0; i < 360; i += 15)
            {
                //theta measure for angle of fire, (float uses less memory)
                // float thetaAngle = (90 - hero.angle);
                float thetaAngle = (90 - i);


                // determine the end point for each hand (result must be a double)
                double xStep = Math.Cos(thetaAngle * Math.PI / 180.0);
                double yStep = Math.Sin(thetaAngle * Math.PI / 180.0);

                //  //bullet object requires float values to draw on screen
                //  ProjectileCircle p = new ProjectileCircle(x, y, size, bulletSpeed, (float)xStep, (float)-yStep);
                ProjectileCircle p = new ProjectileCircle(45,60, (float)xStep, (float)yStep, 8, 5, thetaAngle);
                ProjectileCircle b = new ProjectileCircle(300,60,(float)xStep, (float)yStep, 8, 5, thetaAngle);

                attack2List.Add(p);
                attack2List.Add(b);

                
            }

            return attack2List;
            
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
