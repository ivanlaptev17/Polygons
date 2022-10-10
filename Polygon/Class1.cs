using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Polygon
{
    abstract class Shape {
        protected static int R;
        protected static Color C;
        protected int x, y;

        static Shape() {
            C = Color.Blue;
            R = 10;
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
            Brush brush = new SolidBrush(C);
            G.FillEllipse(brush, x - R, y + R, x + 2 * R, y + 2 * R);
        }

        public override bool IsInside(int x, int y) { 
            return Math.Sqrt((this.x - x) * (this.x - x)) + Math.Sqrt((this.y - y) * this.y - y) < R;
        }
    }

    class Triangle : Shape
    {
        public Triangle(int x, int y) : base(x, y) { }

        public override void Draw(Graphics G) {
            Brush brush = new SolidBrush(C);
        }

        public override bool IsInside(int x, int y) { return false; } // TODO: т. Герона
    }

    class Square : Shape
    {
        public Square(int x, int y) : base(x, y) { }

        public override void Draw(Graphics G) {
        }

        public override bool IsInside(int x, int y) {
            return false;
        }
    }
}
