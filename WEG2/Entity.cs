﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            positionNumber = _positionNumber;
        }

        //Create a class for the player
        public Entity(int _x, int _y, int _sizeX, int _sizeY, int _speed)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;

            
        }

        //Create another class for the boundaries and play area
        public Entity(int _x, int _y, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
        }

        public void UpMovement()
        {
            //Make the enemy/player move up
            y = y - speed;
        }

        public void DownMovement()
        {
            //Make the enemy/player move down
            y = y + speed;
        }

        public void LeftMovement()
        {
            //Make the enemy/player move left
            x = x - speed;
        }

        public void RightMovement()
        {
            //Make the enemy/player move right
            x = x + speed;
        }

        public void Move(string direction)
        {
            //Movement of the players depending what button is pressed
            if (direction == "Up")
            {
                y = y - 3;
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
    }
}
