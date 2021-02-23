using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Point2D
    {
        private int _x;
        private int _y;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public override string ToString()
        {
            return $"Point: X- {X}; Y- {Y} ";
        }
        public Point2D() // constructor.
        {
            X = default;
            Y = default;
        }
        public Point2D(int x, int y) // constructor.
        {
            X = x;
            Y = y;
        }

        // Унарные операторы.
        public static Point2D operator ++(Point2D point2D)
        {
            point2D.X++;
            point2D.Y++;
            return point2D;
        }
        public static Point2D operator --(Point2D point2D)
        {
            point2D.X--;
            point2D.Y--;
            return point2D;
        }
        public static Point2D operator -(Point2D point2D)
        {
            //return new Point2D(point2D.X *= -1, point2D.Y *= -1);

            point2D.X *= -1;
            point2D.Y *= -1;
            return point2D;
        }

        // банрный.
        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }
        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
        }
        public static Point2D operator +(Point2D point2D, int x)
        {
            point2D.X += x;
            point2D.Y += x;
            return point2D;
        }
        public static Point2D operator +(int x, Point2D point2D)
        {
            point2D.X += x;
            point2D.Y += x;
            return point2D;
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static bool operator == (Point2D point1, Point2D point2)
        {
            return point1.Equals(point2);
        }        
        public static bool operator != (Point2D point1, Point2D point2)
        {
            return !(point1 == point2);
        }
        public static bool operator true(Point2D point2D) // точка положительная.
        {
            return (point2D.X > 0 && point2D.Y > 0) ? true : false; 
        }        
        public static bool operator false(Point2D point2D) // точка отрицательная.
        {
            return (point2D.X < 0 && point2D.Y < 0) ? false : true; 
        }
        public static bool operator !(Point2D point2D)
        {
            if (point2D) { return true; } else { return false; }
        }
    }
}
