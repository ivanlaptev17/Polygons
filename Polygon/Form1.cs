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
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            foreach(Shape i in shapes) 
                i.Draw(e.Graphics);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                foreach(Shape i in shapes) {
                    if(i.IsInside(e.X, e.Y)) {
                        flag = true;
                        i.Dx = i.X - e.X;
                        i.Dy = i.Y - e.Y;
                        i.IsDragged = true;
                    }
                }
                if(!flag) {
                    if(circleToolStripMenuItem.Checked) {
                        Circle circle = new Circle(e.X, e.Y);
                        shapes.Add(circle);
                    }
                    else {
                        if(squareToolStripMenuItem.Checked) {
                            Square square = new Square(e.X, e.Y);
                            shapes.Add(square);
                        }
                        else {
                            if(triangleToolStripMenuItem.Checked) {
                                Triangle triangle = new Triangle(e.X, e.Y);
                                shapes.Add(triangle);
                            }
                        }
                        Refresh();
                    }
                }
            }
            if(e.Button == MouseButtons.Right) {
                for(int i = shapes.Count - 1; i >= 0; --i) {
                    if(shapes[i].IsInside(e.X, e.Y)) {
                        shapes.RemoveAt(i);
                        break;
                    }
                }
            }
            Refresh();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e) {
            if(flag) {
                foreach(Shape i in shapes) {
                    if(i.IsDragged) {
                        i.X = e.X + i.Dx;
                        i.Y = e.Y + i.Dy;
                    }
                }
                Refresh();
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e) {
            if(flag) {
                flag = false;
                foreach(Shape i in shapes) {
                    i.IsDragged = false;
                    i.Dx = 0;
                    i.Dy = 0;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e) {
            circleToolStripMenuItem.CheckState = CheckState.Checked;
            ((ToolStripMenuItem)sender).Checked = true;
            foreach(ToolStripMenuItem item in figureTypeToolStripMenuItem.DropDownItems)
                if(item != null && item != (ToolStripMenuItem)sender)
                    item.Checked = false;
        }
    }
}
