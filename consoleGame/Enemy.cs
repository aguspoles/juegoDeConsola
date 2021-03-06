﻿using System;

namespace consoleGame
{
    class Enemy
    {
        private int locationX;
        private int locationY;
        private bool flag = true;

        public Enemy(int x, int y)
        {
            locationX = x;
            locationY = y;
        }

        public void Movement()
        {
            if (locationX < 78 && flag)
                locationX++;
            else flag = false;
            if (locationX > 0 && !flag)
                locationX--;
            else flag = true;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("X");
        }

        public int GetLocationX()
        {
            return locationX;
        }

        public int GetLocationY()
        {
            return locationY;
        }

        public void SetLocationX(int x)
        {
            locationX = x;
        }

        public void SetLocationY(int y)
        {
            locationY = y;
        }
    }
}
