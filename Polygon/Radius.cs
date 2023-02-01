using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public class RadiusEventArgs : EventArgs
    {
        public int Radius;

        public RadiusEventArgs(int Radius)
        {
            this.Radius = Radius;
        }
    }

    public delegate void RadiusDelegate(object sender, RadiusEventArgs e);

}
