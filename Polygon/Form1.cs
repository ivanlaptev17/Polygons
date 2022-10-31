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
        List<Shape> shapes = new List<Shape> { };
        
        public Form1() {
            InitializeComponent();
        }
        

        private void panel_Paint(object sender, PaintEventArgs e) {
            Refresh();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e) {
            foreach(Shape shape in shapes)
            {
                
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e) {

        }

        private void panel_MouseMove(object sender, MouseEventArgs e) {

        }
    }
}
