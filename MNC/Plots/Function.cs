using org.mariuszgromada.math.mxparser;
using System.Windows.Forms.DataVisualization.Charting;
using System;

namespace MNC.Plots
{
    public class Function
    {
        private String _label;
        private String var;
        private Expression exp;
        private double h, a, b;
        private SeriesChartType _type;

        public Function(String label, String exp, String var, double a, double b, double h, SeriesChartType t = SeriesChartType.Spline)
        {
            this._label = label;
            this.h = Math.Abs(h);
            if (a > b)
            {
                this.a = b - this.h;
                this.b = a;
            }
            else
            {
                this.a = a - this.h;
                this.b = b;
            }
            this._type = t;

            this.var = var;
            this.exp = new Expression(exp);
            this.exp.defineArgument(var, 0);

            if (!this.exp.checkSyntax())
            {
                throw new Exception("A expressão é inválida.");
            }
        }

        public SeriesChartType type
        {
            get { return _type; }
        }

        public String label
        {
            get { return _label; }
        }

        public Double[] nextPoint()
        {
            if (a < b)
            {
                a += h;
                exp.setArgumentValue(var, a);
                return new Double[2] { a, exp.calculate() };
            }
            else return null;
        }
    }
}
