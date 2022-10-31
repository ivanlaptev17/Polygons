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
        protected int x, y;
        protected bool isDragged;
        protected int dx, dy;

        static Shape() {
            C = Color.Blue;
            R = 20;
        }

        public Shape(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics G);

        public abstract bool IsInside(int x, int y);
    }

    class Circle : Shape {
        public Circle(int x, int y) : base(x, y) { }
        
        public override void Draw(Graphics G) {
            SolidBrush brush = new SolidBrush(C);
            G.FillEllipse(brush, x - R, y + R, x + 2 * R, y + 2 * R);
        }

        public override bool IsInside(int x, int y) { 
            return Math.Sqrt((this.x - x) * (this.x - x)) + Math.Sqrt((this.y - y) * this.y - y) < R;
        }
    }

    class Triangle : Shape {
        public Triangle(int x, int y) : base(x, y) { }

        public override void Draw(Graphics G) {
            Pen pen = new Pen(C);
            Point[] points = {
                new Point(x, y - R),
                new Point((int)(x - R * Math.Sqrt(3) / 2), x + R / 2),
                new Point((int)(x + R * Math.Sqrt(3) / 2), x + R / 2)
            };
            G.DrawPolygon(pen, points);
        }

        public override bool IsInside(int x, int y) {
            return y > 2 * this.x + R * Math.Sqrt(3) && y < -2 * this.x + R * Math.Sqrt(3);
        }
    }

    class Square : Shape {
        public Square(int x, int y) : base(x, y) { }

        public override void Draw(Graphics G) {
            SolidBrush brush = new SolidBrush(C);
            G.FillRectangle(brush, (float)(x - R * 2 / Math.Sqrt(2)), (float)(y - R * 2 / Math.Sqrt(2)), (float)(R * 2 / Math.Sqrt(2)), (float)(R * 2 / Math.Sqrt(2)));
        }

        public override bool IsInside(int x, int y) {
            return false;
        }
    }
}
