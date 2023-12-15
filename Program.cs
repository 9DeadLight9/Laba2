using System;

namespace Lab2
{
    class Rectangle//1
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double CalculateArea()
        {
            return side1 * side2;
        }

        public double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
    
    class Point//3
    {
        public double point1
        {
            get;
        }

        public double point2
        {
            get;
        }

        public string point3
        {
            get;
        }
        

        public Point(double point1_, double point2_ , string point3_)
        {
            point1 = point1_;
            point2 = point2_;
            point3 = point3_;
        }
    }
    class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.point1 - A.point1, 2) + Math.Pow(B.point2 - A.point2, 2));
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0.0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length; // Останню точку з'єднуємо з першою
                perimeter += GetSideLength(points[i], points[nextIndex]);
            }
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            Console.Write("Enter first side -");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second side -");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            double Area = rectangle.Area;
            double Perimeter = rectangle.Perimeter;
            Console.WriteLine($"Area of your rectangle is {Area}");
            Console.WriteLine($"Perimeter of your rectangle is {Perimeter}");
            */
            /*
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 3, "C");

            Figure myFigure = new Figure(A, B, C);

            myFigure.CalculatePerimeter();
            */
        }
    }
}