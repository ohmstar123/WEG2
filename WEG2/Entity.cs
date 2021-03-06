﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WEG2
{
    class Entity
    {
        public int x, y, sizeX, sizeY, speed, positionNumber;

        //Create a class for the enemies 
        public Entity(int _x, int _y, int _sizeX, int _sizeY, int _speed, int _positionNumber)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            speed = _speed;
            positionNumber = _positionNumber;
        }

        //Create a class for the player
        public Entity(int _x, int _y, int _sizeX, int _sizeY, int _speed)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            speed = _speed;

        }

        //Create another class for the boundaries and play area
        public Entity(int _x, int _y, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
        }

        public void Move(string direction)
        {
            //Movement of the players depending what button is pressed
            if (direction == "Up")
            {
                y = y - speed;
            }

            if (direction == "Down")
            {
                y = y + speed;
            }

            if (direction == "Left")
            {
                x = x - speed;
            }

            if (direction == "Right")
            {
                x = x + speed;
            }
        }

        public Boolean Collision(Entity player)
        {
            Rectangle playerRec = new Rectangle(player.x, player.y, player.sizeX, player.sizeY);
            Rectangle opposingRec = new Rectangle(x, y, sizeX, sizeY);


            if (opposingRec.IntersectsWith(playerRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
