using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;


namespace Polygon
{
    public partial class Form2 : Form
    {
        PointPairList points;

        public Form2(PointPairList list) 
        {
            InitializeComponent();
            points = list;
        }

        private void DrawGraphJarvis()
        {
            label3.Text = "";
            label4.Text = "";
            for (int i = 0; i<points.Count; i++)
            {
                label3.Text += points[i].X.ToString() + " ";
                label4.Text += points[i].Y.ToString() + " ";
            }
            
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = "Jarvis Algorithm";
            pane.XAxis.Title.Text = "Number of figure";
            pane.YAxis.Title.Text = "Ticks";
            pane.CurveList.Clear();


            pane.AddCurve("Jarvis", points, Color.Blue, SymbolType.None);

            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraphJarvis();
        }
    }
}
