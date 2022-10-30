using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Солнечная_система {
    public partial class Form1 : Form  {
        Astro[] astros = new Astro[4] {
            new Sun(100, 100, 23),
            new Moon(200, 100, 21),
            new Saturn(160, 100, 123),
            new Kometa(300, 100, 231)
        };

        public Form1() {
            InitializeComponent();
        }

        private void pnl_Paint(object sender, PaintEventArgs e) {
            if (((ToolStripMenuItem)sender).CheckState == CheckState.Checked)
                astros[0].Draw(e.Graphics);
            //if(солнце.CheckState == CheckState.Checked)
            //    astros[0].Draw(e.Graphics);
            //if (луна.CheckState == CheckState.Checked)
            //    astros[1].Draw(e.Graphics);
            //if (сатурн.CheckState == CheckState.Checked)
            //    astros[2].Draw(e.Graphics);
            //if (комета.CheckState == CheckState.Checked)
            //    astros[3].Draw(e.Graphics);
        }

        private void planet_CheckedChanged(object sender, EventArgs e) {
            Refresh();
        }
    }
}
