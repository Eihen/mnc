using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNC.Integrals
{
    class Integral
    {
        private readonly double x0, xn, h;
        private readonly int n;
        private Expression exp;

        public Integral(String exp, double x0, double xn, int n)
        {
            this.exp = new Expression(exp);
            this.exp.defineArgument("x", x0);

            if (!this.exp.checkSyntax())
                throw new Exception("A expressão informada não é válida.");

            this.n = n;
            this.x0 = x0;
            this.xn = xn;
            this.h = (xn - x0) / n;
        }

        public double trapezium()
        {
            double fx, r, xi = x0;
            exp.setArgumentValue("x", x0);
            fx = exp.calculate();
            exp.setArgumentValue("x", xn);
            r = Math.Abs(fx) + Math.Abs(exp.calculate());

            for (int i = 1; i < n - 1; i++)
            {
                exp.setArgumentValue("x", xi += h);
                r += 2 * Math.Abs(exp.calculate());
            }
            return r * h / 2;
        }

        public double rightRectangle()
        {
            double r = 0, xi = x0 + h;

            for (int i = 1; i < n; i++)
            {
                exp.setArgumentValue("x", xi);
                r += Math.Abs(exp.calculate());
                xi += h;
            }
            return r * h;
        }

        public double leftRectangle()
        {
            double r = 0, xi = x0;

            for (int i = 0; i < n - 1; i++)
            {
                exp.setArgumentValue("x", xi);
                r += Math.Abs(exp.calculate());
                xi += h;
            }
            return r * h;
        }

        public double simpson13()
        {
            int e = n, m = 8;
            double xi = x0, r, fx;
            if (e % 2 != 0)
            {
                e--;
            }

            exp.setArgumentValue("x", xi);
            r = Math.Abs(exp.calculate());

            for (int i = 1; i < e; i++)
            {
                m /= 2;
                exp.setArgumentValue("x", xi += h);
                r = +m * Math.Abs(exp.calculate());
                if (i % 2 == 0)
                    m = 8;
            }

            r *= h / 3;

            for (int i = e; i < n; i++)
            {
                exp.setArgumentValue("x", xi);
                fx = exp.calculate();
                exp.setArgumentValue("x", xn);
                r += h / 2 * (Math.Abs(fx) + Math.Abs(exp.calculate()));
            }

            return r;
        }

        public double simpson38()
        {
            int e = n % 3;
            double xi = x0, fx, r;

            exp.setArgumentValue("x", xi);
            r = Math.Abs(exp.calculate());

            if (e == 0)
            {
                exp.setArgumentValue("x", xn);
                r += Math.Abs(exp.calculate());
            }

            for (int i = 1; i < e; i++)
            {
                exp.setArgumentValue("x", xi += h);
                r += (i % 3 == 0 ? 2 : 3) * Math.Abs(exp.calculate());
            }

            r *= 3 * h / 8;

            if (e > 0)
            {
                if (e == 2)
                {
                    xi += h;
                }
                exp.setArgumentValue("x", xi);
                fx = exp.calculate();
                exp.setArgumentValue("x", xn);
                r += h / 2 * (Math.Abs(fx) + Math.Abs(exp.calculate()));
            }

            return r;
        }

        private static readonly double[][] a = new double[8][]
        {
            new double[]{2},
            new double[]{1,1},
            new double[]{0.5555556, 0.8888889, 0.5555556},
            new double[]{0.34785484, 0.65214516, 0.65214516, 0.34785484},
            new double[]{0.23692688, 0.47862868, 0.5688889, 0.47862868, 0.23692688},
            new double[]{0.17132450, 0.36076158, 0.46791394, 0.46791394, 0.36076158, 0.17132450},
            new double[]{0.12948496, 0.27970540, 0.38183006, 0.41795918, 0.38183006, 0.27970540, 0.12948496},
            new double[]{0.10122854, 0.22238104, 0.31370664, 0.36268378, 0.36268378, 0.31370664, 0.22238104, 0.10122854}
        };
        private static readonly double[][] t = new double[8][]
        {
            new double[]{0},
            new double[]{0.57735027, -0.57735027},
            new double[]{0.77459667, 0, -0.77459667},
            new double[]{0.86113631, 0.33998104, -0.33998104, -0.86113631},
            new double[]{0.90617985, 0.53846931, 0, -0.53846931, -0.90617985},
            new double[]{0.93246951, 0.66120939, 0.23861919, -0.23861919, -0.66120939, -0.93246951},
            new double[]{0.94910791, 0.74153119, 0.40584515, 0 ,-0.40584515, -0.74153119, -0.94910791},
            new double[]{0.96028986, 0.79666648, 0.52553242, 0.18343464, -0.18343464, -0.52553242, -0.79666648, -0.96028986}
        };

        public double gaussianQuadrature()
        {
            double r = 0;
            if (n > 8 || n < 1)
            {
                throw new NotImplementedException("Método não implementado para n=" + n + ", utilize 0 < n < 9.");
            }

            for (int i = 0; i < n; i++)
            {
                exp.setArgumentValue("x", 0.5 * (xn - x0) * ((t[n-1][i] + 1)));
                r += a[n-1][i] * (0.5 * (xn - x0) * exp.calculate());
            }
            return r;
        }
    }
}
