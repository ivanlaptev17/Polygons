using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Солнечная_система {
    abstract class Astro {
        protected int R;
        protected int x, y;

        public Astro() {
            x = 23;
            y = 50;
            R = 70;
        }

        public Astro(int x, int y, int R) {
            this.x = x;
            this.y = y;
            this.R = R;
        }

        public abstract void Draw(Graphics G);
    }

    class Sun : Astro {
        public Sun(int x, int y, int R) : base(x, y, R) { }

        public override void Draw(Graphics G) {
            SolidBrush brush = new SolidBrush(Color.Yellow);
            G.FillEllipse(brush, x - R, y + R, x + 2 * R, y + 2 * R);
        }
    }

    class Moon : Astro {
        public Moon(int x, int y, int R) : base(x, y, R) { }

        public override void Draw(Graphics e) {
            Brush B = new SolidBrush(Color.White);
            e.FillEllipse(B, x + 150, y + 150, 60, 60);
            Brush P = new SolidBrush(Color.Gray);
            e.FillEllipse(P, x + 190, y + 190, 10, 10);
            e.FillEllipse(P, x + 183, y + 182, 10, 10);
            e.FillEllipse(P, x + 170, y + 170, 10, 10);

        }
    }

    class Saturn : Astro {
        public Saturn(int x, int y, int R) : base(x, y, R) { }

        public override void Draw(Graphics e) {
            Brush B = new SolidBrush(Color.Brown);
            Pen P = new Pen(Color.White);
            e.FillEllipse(B, x + 250, y + 250, 80, 80);
            e.DrawEllipse(P, x + 245, y + 270, 90, 30);
        }
    }

    class Kometa : Astro {
        public Kometa(int x, int y, int R) : base(x, y, R) { }

        public override void Draw(Graphics e) {
            Brush B = new SolidBrush(Color.Red);
            Pen P = new Pen(Color.White);
            e.FillEllipse(B, x + 100, y + 100, 30, 30);
            e.DrawLine(P, x + 100, y + 100, x + 100, y + 80);
            e.DrawLine(P, x + 100, y + 80, x + 120, y + 80);
        }
    }
}