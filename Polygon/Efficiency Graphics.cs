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
        PointPairList pointsJar;
        PointPairList pointsStandard;

        public Form2(PointPairList listJar, PointPairList listStandard) 
        {
            InitializeComponent();
            pointsJar = listJar;
            pointsStandard = listStandard;
        }

        private void DrawGraphs()
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            for (int i = 0; i<pointsJar.Count; i++)
            {
                label3.Text += pointsJar[i].X.ToString() + " ";
                label4.Text += pointsJar[i].Y.ToString() + "  ";
            }


            for (int i = 0; i < pointsStandard.Count; i++)
            {
                label5.Text += pointsStandard[i].X.ToString() + " ";
                label6.Text += pointsStandard[i].Y.ToString() + "  ";
            }

            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = "Comparison Graph";
            pane.XAxis.Title.Text = "Ticks";
            pane.YAxis.Title.Text = "Number of figure";
            pane.CurveList.Clear();

            pane.AddCurve("Jarvis", pointsJar, Color.Blue, SymbolType.None);
            pane.AddCurve("Standard", pointsStandard, Color.Red, SymbolType.None);

            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();

            double jarTicksSum = 0.0;
            foreach (var i in pointsJar)
                jarTicksSum += i.X;

            double standardTicksSum = 0.0;
            foreach (var i in pointsStandard)
                standardTicksSum += i.X;

            MessageBox.Show($"{jarTicksSum / standardTicksSum}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraphs();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
