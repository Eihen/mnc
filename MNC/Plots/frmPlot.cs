using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MNC.Plots
{
    public partial class frmPlots : Form
    {
        private List<Function> functions;

        public frmPlots(List<Function> functions)
        {
            this.functions = functions;

            InitializeComponent();
        }

        private void frmPlot_Load(object sender, EventArgs e)
        {
            chart.Series.Clear();
            double[] point;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            
            foreach(Function function in functions)
            {
                chart.Series.Add(function.label);
                chart.Series[function.label].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                chart.Series[function.label].Color = System.Drawing.Color.FromArgb(rnd.Next(20, 235), rnd.Next(20, 235), rnd.Next(20, 235));
                
                while((point = function.nextPoint()) != null)
                {
                    chart.Series[function.label].Points.AddXY(point[0], point[1]);
                }
            }
        }
    }
}
