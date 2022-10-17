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
        bool flag = false;
        Circle circle = new Circle(50, 50);
        Square square = new Square(150, 150);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            circle.Draw(e.Graphics);
            square.Draw(e.Graphics);
        }
    }
}
