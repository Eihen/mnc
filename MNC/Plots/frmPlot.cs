using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            try
            {
                chart.Series.Clear();
                double[] point;
                Random rnd = new Random(Guid.NewGuid().GetHashCode());

                foreach (Function function in functions)
                {
                    chart.Series.Add(function.label);
                    chart.Series[function.label].ChartType = function.type;
                    var r = rnd.Next(20, 205);
                    var g = rnd.Next(20, 205);
                    var b = rnd.Next(20, 205);
                    chart.Series[function.label].BorderColor = System.Drawing.Color.FromArgb(r, g, b);
                    chart.Series[function.label].Color = System.Drawing.Color.FromArgb(r + 50, g + 50, b + 50);
                    chart.Series[function.label].BorderWidth = 2;


                    while ((point = function.nextPoint()) != null)
                    {
                        chart.Series[function.label].Points.AddXY(point[0], point[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
