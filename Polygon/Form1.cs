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
        }

        private void Form1_Load(object sender, EventArgs e) {
            shapes = new List<Shape>();
            comboBox1.DataSource = shapes;
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            if(flag) shapes[shapes.Count-1].Draw(e.Graphics);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e) {
            shapes.Add((Shape)comboBox1.SelectedValue;)
            if (!shapes[shapes.Count-1].IsInside(e.X, e.Y)) flag = true;
            else flag = false;
            panel.Invalidate();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e) {
        }

        private void panel_MouseUp(object sender, MouseEventArgs e) {
        }
    }
}
