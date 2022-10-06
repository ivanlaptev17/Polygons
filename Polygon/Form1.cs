using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon
{
    public partial class Form1 : Form
    {
        List<Shape> shapes = new List<Shape> { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            Circle circle = new Circle(e.X, e.Y);
            shapes.Add(circle);
       
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            shapes[0].Draw(e.Graphics);
        }
    }
}
