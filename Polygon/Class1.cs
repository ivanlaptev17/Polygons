using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Polygon {
    abstract class Shape {
        protected static int R;
        protected static Color C;
        public int x, y;
        public bool isDragged;
        public int dx, dy;

        static Shape() {
            C = Color.Blue;
            R = 20;
        }

        public Shape(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public bool IsDragged {
            get { return isDragged; }
             set { isDragged = value; }
        }

        public int Dx {
            get { return dx; }
            set { dx = value; }
        }

        public int Dy {
            get { return dy; }
            set { dy = value; }
        }

        public int X {
            get { return x; }
            set { x = value; }
        }

        public int Y {
            get { return y; }
            set { y = value; }
        }

        public abstract void Draw(Graphics G);

        public abstract bool IsInside(int x, int y);
    }

    class Circle : Shape {
        public Circle(int x, int y) : base(x, y) { }
        
        public override void Draw(Graphics G) {
            SolidBrush brush = new SolidBrush(C);
            G.FillEllipse(brush, x - R, y - R, 2 * R, 2 * R);
        }

        public override bool IsInside(int x, int y) {
            return Math.Sqrt((this.x - x) * (this.x - x) + (this.y - y) * (this.y-y)) < R;
        }
    }

    class Triangle : Shape {
        public Triangle(int x, int y) : base(x, y) { }

        public override void Draw(Graphics G) {
            SolidBrush brush = new SolidBrush(C);
            Point[] points = {
                new Point(x, y - R),
                new Point((int)(x + R * Math.Sqrt(3) / 2), y + R / 2),
                new Point((int)(x - R * Math.Sqrt(3) / 2), y + R / 2)
            };
            G.FillPolygon(brush, points);
        }

        public override bool IsInside(int x, int y) {
            return y > 2 * this.x + R * Math.Sqrt(3) && y < -2 * this.x + R * Math.Sqrt(3);
        }
    }

    class Square : Shape {
        public Square(int x, int y) : base(x, y) { }

        public override void Draw(Graphics G) {
            SolidBrush brush = new SolidBrush(C);
            G.FillRectangle(brush, (float)(x - R / Math.Sqrt(2)), (float)(y - R / Math.Sqrt(2)), (float)(R * 2 / Math.Sqrt(2)), (float)(R * 2 / Math.Sqrt(2)));
        }

        public override bool IsInside(int x, int y) {
            return x > this.x - R / Math.Sqrt(2) && x < this.x + R / Math.Sqrt(2) && y > this.y - R / Math.Sqrt(2) && y < this.y + R / Math.Sqrt(2);
        }
    }
}
