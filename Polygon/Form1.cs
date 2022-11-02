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
        List<Shape> shapes = new List<Shape> { new Circle(22, 12), new Triangle(231, 123), new Square(123, 438) };
        Circle shape = new Circle(233, 22);

        public Form1() {
            InitializeComponent();
            comboBox1.DataSource = shapes;
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
        }

        private void panel_MouseDown(object sender, MouseEventArgs e) {
            var G = panel.CreateGraphics();
            shape = new Circle(e.X, e.Y);
            if (shape.IsInside(e.X, e.Y))
                shape.isDragged = true;
            ((Shape)comboBox1.SelectedItem).Draw(G);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e) {

        }

        private void panel_MouseUp(object sender, MouseEventArgs e) {
        }


        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
