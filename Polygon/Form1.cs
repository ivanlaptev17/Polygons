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
            //if (shapes.Count > 2) {
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
            //if (shapes.Count >= 3)
            //{
            //    Shape minShape = shapes[0];
            //    foreach (Shape i in shapes)
            //    {
            //        if (i.Y > minShape.Y)
            //        {
            //            minShape = i;
            //        }
            //else if (i.Y == minShape.Y)
            //{
            //    minShape = (i.X < minShape.X) ? i : minShape;
            //}
            //}
            //Point p = new Point(minShape.X - 100, minShape.Y);

            //double minCos = double.MaxValue;
            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    minCos = double.MaxValue;
            //    double x1 = p.X - minShape.X;
            //    double y1 = -p.Y + minShape.Y;
            //    double x2 = shapes[i].X - minShape.X;
            //    double y2 = -shapes[i].Y + minShape.Y;
            //    double locCos = (x1 * x2 + y1 * y2) / (Math.Sqrt(x1 * x1 + y1 * y1) * Math.Sqrt(x2 * x2 + y2 * y2));
            //    if (locCos < minCos) // скалярный вектор
            //    {
            //        minCos = locCos;
            //        shapes[i].DrawLine = true;
            //        //minShape.DrawLine = true;
            //        p = new Point(shapes[i].X - 100, shapes[i].Y);
            //        minShape = shapes[i];
            //    }
            //}



            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    //Вектор1
            //    float x1 = p.X - curShape.X;
            //    float y1 = p.Y - curShape.Y;
            //    //Вектор2
            //    float x2 = shapes[i].X - curShape.X;
            //    float y2 = shapes[i].Y - curShape.Y;
            //    if ((x1 * x2 + y1 * y2) / (Math.Sqrt(x1 * x1 + y1 * y1) + Math.Sqrt(x2 * x2 + y2 * y2)) < minCos) // скалярный вектор
            //    {
            //        minCos = (x1 * x2 + y1 * y2) / (Math.Sqrt(x1 * x1 + y1 * y1) + Math.Sqrt(x2 * x2 + y2 * y2));
            //        minShape = curShape;
            //        curShape = shapes[i];
            //    }
            //    if (i == shapes.Count - 1) {
            //        e.Graphics.DrawLine(pen, minShape.X, minShape.Y, curShape.X, curShape.Y);
            //        minShape.DrawLine = curShape.DrawLine = true;
            //    }
            //    p = new Point(minShape.X - 100, minShape.Y);

            //}
            //}

            // Jarvis Algorithm
            if (shapes.Count >= 3) {
               int startShape = 0;
               foreach (Shape i in shapes) 
                    if (i.X <= shapes[startShape].X)
                        startShape = shapes.IndexOf(i);
                e.Graphics.DrawLine(pen, shapes[startShape].X, shapes[startShape].Y, shapes[startShape].X, shapes[startShape].Y - 200000);
                shapes[startShape].DrawLine = true;
                int curShape = startShape;
                double x = 0, y = 0, k = 0, minCos = double.MaxValue;
                int index = 0;
                double vx = 0, vy = -2e5;
                do
                {
                    x = y = 0;
                    minCos = double.MaxValue;
                    foreach (Shape i in shapes)
                    {
                        // vector
                        x = i.X - shapes[curShape].X;
                        y = i.Y + shapes[curShape].Y;
                        if (MinCos(vx, vy, x, y) < minCos && i != shapes[curShape])
                        {
                            minCos = MinCos(vx, vy, x, y);
                            index = shapes.IndexOf(i);
                            vx = shapes[curShape].X - i.X;
                            vy = +shapes[curShape].Y - i.Y;
                        }
                        // e.Graphics.DrawLine(pen, shapes[curShape].X, shapes[curShape].Y, i.X, i.Y);
                        // shapes[curShape].DrawLine = i.DrawLine = true;
                        //k++;
                        //curShape = shapes.IndexOf(i);
                    }
                    e.Graphics.DrawLine(pen, shapes[curShape].X, shapes[curShape].Y, shapes[index].X, shapes[index].Y);
                    shapes[curShape].DrawLine = shapes[index].DrawLine = true;
                    curShape = index;
                    k++;
                } while (k!=1000);

            }
            foreach (Shape i in shapes)
                i.Draw(e.Graphics);
        }

        private double MinCos(double x1, double x2, double y1, double y2) {
            return Math.Abs(x1 * x2 + y1 + y2) / (Math.Sqrt(x1 * x1 + y1 * y1) + Math.Sqrt(x2 * x2 + y2 * y2));
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
