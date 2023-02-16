using System;
using System.Drawing;
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
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Columns[i].Width = 40;
                dataGridView2.Columns[i].Width = 40;
            }

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = pointsJar[i].X.ToString();
                dataGridView1.Rows[1].Cells[i].Value = pointsJar[i].Y.ToString();
            }


            for (int i = 0; i < 10; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = pointsStandard[i].X.ToString();
                dataGridView2.Rows[1].Cells[i].Value = pointsStandard[i].Y.ToString();
            }

            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = "Comparison Graph";
            pane.XAxis.Title.Text = "Number of figures";
            pane.YAxis.Title.Text = "Ticks";
            pane.CurveList.Clear();

            pane.AddCurve("Jarvis", pointsJar, Color.Blue, SymbolType.Circle);
            pane.AddCurve("Standard", pointsStandard, Color.Red, SymbolType.Circle);

            zedGraphControl1.IsShowHScrollBar = true;
            zedGraphControl1.IsAutoScrollRange = true;

            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();

            double jarTicksSum = 0.0;
            foreach (var i in pointsJar)
                jarTicksSum += i.Y;

            double standardTicksSum = 0.0;
            foreach (var i in pointsStandard)
                standardTicksSum += i.Y;

            MessageBox.Show($"{standardTicksSum / jarTicksSum}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraphs();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;
            dataGridView2.RowCount = 2;
            dataGridView1.ColumnCount = 10;
            dataGridView2.ColumnCount = 10;
        }
    }
}
