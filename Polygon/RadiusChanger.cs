using System;
using System.Windows.Forms;

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
    }
}
