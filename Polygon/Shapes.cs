using System;
using System.Drawing;

namespace Polygon
{

    [Serializable]
    public abstract class Shape
    {
        protected static int r;
        protected static Color c;
        protected int x;
        protected int y;
        protected bool isDragged;
        protected int dx;
        protected int dy;
        protected bool drawLine;

        static Shape()
        {
            C = Color.DarkOliveGreen;
            r = 50;
        }

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
            isDragged = false;
            dx = 0;
            dy = 0;
            drawLine = false;
        }

        public abstract bool DrawLine { get; set; }

        public abstract bool IsDragged { get; set; }

        public abstract int Dx { get; set; }

        public abstract int Dy { get; set; }

        public abstract int X { get; set; }

        public abstract int Y { get; set; }

        public static Color C { get { return c; } set { c = value; } }

        public static int R { get { return r; } set { r = value; } }

        public abstract void Draw(Graphics G);

        public abstract bool IsInside(int x, int y);
    }

    [Serializable]
    class Circle : Shape
    {
        public Circle(int x, int y) : base(x, y) { }

        public override bool DrawLine { get => drawLine; set => drawLine = value; }

        public override bool IsDragged { get => isDragged; set => isDragged = value; }

        public override int Dx { get => dx; set => dx = value; }

        public override int Dy { get => dy; set => dy = value; }

        public override int X { get => x; set => x = value; }

        public override int Y { get => y; set => y = value; }


        public override void Draw(Graphics G)
        {
            SolidBrush brush = new SolidBrush(C);
            G.FillEllipse(brush, x - R, y - R, 2 * R, 2 * R);
        }

        public override bool IsInside(int x, int y)
        {
            return Math.Sqrt((this.x - x) * (this.x - x) + (this.y - y) * (this.y - y)) < R;
        }
    }

    [Serializable]
    class Triangle : Shape
    {
        public Point[] points;
        public Triangle(int x, int y) : base(x, y)
        {
            points = new Point[3];
            points[0] = new Point(x, y - R);
            points[1] = new Point(x + (int)(R * Math.Sqrt(3) / 2), y + R / 2);
            points[2] = new Point(x - (int)(R * Math.Sqrt(3) / 2), y + R / 2);
        }

        public override bool DrawLine { get => drawLine; set => drawLine = value; }

        public override bool IsDragged { get => isDragged; set => isDragged = value; }

        public override int Dx { get => dx; set => dx = value; }

        public override int Dy { get => dy; set => dy = value; }

        public override int X { get => x; set => x = value; }

        public override int Y { get => y; set => y = value; }

        public override void Draw(Graphics G)
        {
            SolidBrush brush = new SolidBrush(C);
            points[0] = new Point(x, y - R);
            points[1] = new Point(x + (int)(R * Math.Sqrt(3) / 2), y + R / 2);
            points[2] = new Point(x - (int)(R * Math.Sqrt(3) / 2), y + R / 2);
            G.FillPolygon(brush, points);
        }

        public override bool IsInside(int x, int y)
        {
            int a = (points[0].X - x) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - y);
            int b = (points[1].X - x) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - y);
            int c = (points[2].X - x) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - y);
            return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
        }
    }

    [Serializable]
    class Square : Shape
    {
        public Square(int x, int y) : base(x, y) { }

        public override bool DrawLine { get => drawLine; set => drawLine = value; }

        public override bool IsDragged { get => isDragged; set => isDragged = value; }

        public override int Dx { get => dx; set => dx = value; }

        public override int Dy { get => dy; set => dy = value; }

        public override int X { get => x; set => x = value; }

        public override int Y { get => y; set => y = value; }

        public override void Draw(Graphics G)
        {
            SolidBrush brush = new SolidBrush(C);
            G.FillRectangle(brush, x - (int)(R * 2 / Math.Sqrt(2) / 2), y - (int)(R * 2 / Math.Sqrt(2) / 2), (int)(R * 2 / Math.Sqrt(2)), (int)(R * 2 / Math.Sqrt(2)));
        }

        public override bool IsInside(int x, int y)
        {
            return x > this.x - R / Math.Sqrt(2) && x < this.x + R / Math.Sqrt(2) && y > this.y - R / Math.Sqrt(2) && y < this.y + R / Math.Sqrt(2);
        }
    }
}
