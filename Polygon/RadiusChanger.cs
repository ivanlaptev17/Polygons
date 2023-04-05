using System;
using System.Windows.Forms;
using LibraryShapes;

namespace Polygon
{
    public partial class RadiusChanger : Form
    {
        public RadiusChanger()
        {
            InitializeComponent();
        }

        public event RadiusDelegate RadiusChanged;

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            RadiusChanged(this, new RadiusEventArgs(trackBar1.Value));
        }

        private void RadiusChanger_Load(object sender, EventArgs e)
        {
            trackBar1.Value = Shape.R;
        }
    }
}
