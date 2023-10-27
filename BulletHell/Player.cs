using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class Player
    {
        public int size = 6;
        public int x, y, xSpeed, ySpeed;
        public int lives = 3;
        public int bomb = 3;

        public Player(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }
        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= xSpeed;
            }
            else if (direction == "right")
            {
                x += xSpeed;
            }

            if (direction == "up")
            {
                y -= ySpeed;
            }
            else if (direction == "down")
            {
                y += ySpeed;
            }

            
          
        }
    }
}
