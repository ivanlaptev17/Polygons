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
        protected int x, y;
        protected Color C;

        static Shape()
        {
            Color C = Color.Red;
            R = 10;
        }

        public Shape(Color C, int R)
        {
            this.C = C;
            R = R;
        }

        public abstract void Draw(Graphics G);

        public abstract bool InSide(int x, int y);
    }

    class Circle : Shape {

    }

    class Triangle : Shape {

    }

    class Square : Shape {

    }
}
