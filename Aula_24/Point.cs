using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24
{
    public struct Point(int x, int y)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;

        public double Distancia(Point p)
        {
            // X = 10 não é permitido em struct
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
    }
    public class Player(int id, Point p)
    {
        public int Id { get; set;} = id;
        public Point Position { get; set; } = p;

        public void Move(Point p)
        {
            Position = p;
        }
    }
}