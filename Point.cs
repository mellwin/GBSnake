﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(){}

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x += offset;

            if (direction == Direction.LEFT) x -= offset;

            if (direction == Direction.UP) y -= offset;

            if (direction == Direction.DOWN) y += offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}