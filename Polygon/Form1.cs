using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon {
    public partial class Form1 : Form {
        List<Shape> shapes;
        bool flag;

        public Form1() {
            InitializeComponent();
            shapes = new List<Shape>();
            DoubleBuffered = true;
        }

        private void Form_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen pen = new Pen(Color.Black, 3);

            // Standard Algorithm
            //if (shapes.Count >= 3) {
            //    int cntL, cntR;
            //    for (int i = 0; i < shapes.Count; i++)
            //        shapes[i].DrawLine = false;
            //    for (int i = 0; i < shapes.Count; i++) {
            //        for (int j = i + 1; j < shapes.Count; j++) {
            //            cntL = cntR = 0;
            //            float k = ((float)shapes[j].Y - shapes[i].Y) / ((float)shapes[j].X - shapes[i].X);
            //            float b = shapes[i].Y - k * shapes[i].X;
            //            for (int l = 0; l < shapes.Count; l++) {
            //                if (l != i && l != j) {
            //                    if (shapes[l].Y > k * shapes[l].X + b)
            //                        cntR++;
            //                    else
            //                        cntL++;
            //                }
            //            }
            //            if (cntR * cntL== 0 && shapes[i].X!=shapes[j].X) {
            //                e.Graphics.DrawLine(pen, shapes[i].X, shapes[i].Y, shapes[j].X, shapes[j].Y);
            //                shapes[i].DrawLine = true;
            //                shapes[j].DrawLine = true;
            //            }
            //        }
            //    }
            //}

            // Jarvis Algorithm
            if (shapes.Count > 0)
            {
                Shape minShape = shapes[0];
                foreach (Shape i in shapes)
                {
                    if (i.X <= minShape.X)
                    {
                        minShape = i;
                    }
                }
                List<Shape> hull = new List<Shape> { minShape };
                while (true)
                {
                    Shape t = minShape;
                    foreach (Shape i in shapes)
                    {
                        // if (cos(i, minShape, t) < 0)
                            t = i;
                        if (t == minShape)
                            continue;
                        else
                        {
                            minShape = t;
                            hull.Add(t);
                        }
                    }
                }
                for (int i = 0; i < shapes.Count - 1; i++)
                {
                    e.Graphics.DrawLine(pen, shapes[i].X, shapes[i].Y, shapes[i + 1].X, shapes[i + 1].Y);
                    shapes[i].DrawLine = true;
                    shapes[i + 1].DrawLine = true;
                }
            }

            foreach (Shape i in shapes)
                i.Draw(e.Graphics); 
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                foreach (Shape i in shapes) {
                    if (i.IsInside(e.X, e.Y)) {
                        flag = true;
                        i.Dx = i.X - e.X;
                        i.Dy = i.Y - e.Y;
                        i.IsDragged = true;
                    }
                }
                if (!flag) {
                    if (circleToolStripMenuItem.Checked) {
                        Circle circle = new Circle(e.X, e.Y);
                        shapes.Add(circle);
                    } else if (squareToolStripMenuItem.Checked) {
                        Square square = new Square(e.X, e.Y);
                        shapes.Add(square);
                    } else if (triangleToolStripMenuItem.Checked) {
                        Triangle triangle = new Triangle(e.X, e.Y);
                        shapes.Add(triangle);
                    }
                    if (shapes.Count >= 3) {
                        Refresh();
                        if (!shapes[shapes.Count - 1].DrawLine) {
                            shapes.RemoveAt(shapes.Count - 1);
                            flag = true;
                        }
                        for (int i = 0; i < shapes.Count; i++) {
                            if (!shapes[i].DrawLine) {
                                shapes.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Right) {
                for (int i = shapes.Count - 1; i >= 0; i--) {
                    if (shapes[i].IsInside(e.X, e.Y)) {
                        shapes.RemoveAt(i);
                        break;
                    }
                }
            }
            Refresh();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e) {
            if (flag) {
                foreach (Shape i in shapes) {
                    if (i.IsDragged) {
                        i.X = e.X + i.Dx;
                        i.Y = e.Y + i.Dy;
                    }
                }
                Refresh();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e) {
            if (flag) {
                flag = false;
                foreach (Shape i in shapes)
                    i.IsDragged = false;
                if (shapes.Count >= 3) {
                    for (int i = 0; i < shapes.Count; i++) {
                        if (!shapes[i].DrawLine) {
                            shapes.RemoveAt(i);
                            i--;
                        }
                    }
                    Refresh();
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e) {
            circleToolStripMenuItem.CheckState = CheckState.Checked;
            ((ToolStripMenuItem)sender).Checked = true;
            foreach (ToolStripMenuItem item in figureTypeToolStripMenuItem.DropDownItems)
                if (item != null && item != (ToolStripMenuItem)sender)
                    item.Checked = false;
        }
    }
}
