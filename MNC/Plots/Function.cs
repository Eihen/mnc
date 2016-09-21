using org.mariuszgromada.math.mxparser;
using System;

namespace MNC.Plots
{
    public class Function
    {
        private String _label;
        private String var;
        private Expression exp;
        private double h, _a, _b;

        public Function(String label, String exp, String var, double a, double b, double h)
        {
            this._label = label;
            this._a = a;
            this._b = b;
            this.h = h;

            this.var = var;
            this.exp = new Expression(exp);
            this.exp.defineArgument(var, 0);

            if (!this.exp.checkSyntax())
            {
                throw new Exception("A expressão é inválida.");
            }
        }

        public double a
        {
            get { return _a; }
        }

        public double b
        {
            get { return _b; }
        }

        public String label
        {
            get { return _label; }
        }

        public Double[] nextPoint()
        {
            if (a < b)
            {
                exp.setArgumentValue(var, _a);
                _a += h;
                return new Double[2] { _a, exp.calculate() };
            }
            else return null;
        }
    }
}
