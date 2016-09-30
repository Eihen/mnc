using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;


namespace MNC.Derivatives
{
    public class Derivative
    {
        private Expression exp;
        private SortedList<String, double> xs;
        private readonly double h, errorMax;
        private readonly int itMax;

        public Derivative(String exp, SortedList<String, double> xs, double h = 0.00001, int itMax = 100, double errorMax = 0.00001)
        {
            this.exp = new Expression(exp);
            this.xs = xs;

            loadArguments();

            if (!this.exp.checkSyntax())
                throw new Exception("A expressão informada não é válida ou o vetor x não foi preenchido corretamente.");

            this.h = h * 1024;
            this.itMax = itMax;
            this.errorMax = errorMax;
        }

        public void loadArguments()
        {
            exp.removeAllArguments();

            if (xs.Count == 0)
            {
                throw new Exception("Você não preencheu o vetor x.");
            }

            foreach (KeyValuePair<String, double> x in xs)
            {
                exp.defineArgument(x.Key, x.Value);
            }
        }

        public double derivate1(String i = "x")
        {
            double p, q, f1, f2, h = this.h;
            int it = 0;

            loadArguments();

            exp.setArgumentValue(i, xs[i] + h);
            f1 = exp.calculate();
            exp.setArgumentValue(i, xs[i] - h);
            f2 = exp.calculate();
            p = (f1 - f2) / (2 * h);

            do
            {
                it++;
                q = p;
                h /= 2;

                exp.setArgumentValue(i, xs[i] + h);
                f1 = exp.calculate();
                exp.setArgumentValue(i, xs[i] - h);
                f2 = exp.calculate();
                p = (f1 - f2) / (2 * h);

                if (Double.IsInfinity(p) || Double.IsNaN(p))
                {
                    return q;
                }
            } while (it != itMax && Math.Abs(p - q) > errorMax);

            return p;
        }

        public double derivate2(String i = "x", String j = "x")
        {
            double p, q, f1, f2, f3, f4, h = this.h;
            int it = 0;

            loadArguments();

            if (i != j)
            {
                exp.setArgumentValue(i, xs[i] + h);
                exp.setArgumentValue(j, xs[j] + h);
                f1 = exp.calculate();

                exp.setArgumentValue(j, xs[j] - h);
                f2 = exp.calculate();

                exp.setArgumentValue(i, xs[i] - h);
                f3 = exp.calculate();

                exp.setArgumentValue(j, xs[j] + h);
                f4 = exp.calculate();

                p = (f1 - f2 - f3 + f4) / (4 * h * h);
            }
            else
            {
                exp.setArgumentValue(i, xs[i] + 2 * h);
                f1 = exp.calculate();

                exp.setArgumentValue(i, xs[i]);
                f2 = exp.calculate();

                exp.setArgumentValue(i, xs[i] - 2 * h);
                f3 = exp.calculate();

                p = (f1 - 2 * f2 + f3) / (4 * h * h);
            }

            do
            {
                it++;
                q = p;
                h /= 2;
                if (i != j)
                {
                    exp.setArgumentValue(i, xs[i] + h);
                    exp.setArgumentValue(j, xs[j] + h);
                    f1 = exp.calculate();

                    exp.setArgumentValue(j, xs[j] - h);
                    f2 = exp.calculate();

                    exp.setArgumentValue(i, xs[i] - h);
                    f3 = exp.calculate();

                    exp.setArgumentValue(j, xs[j] + h);
                    f4 = exp.calculate();

                    p = (f1 - f2 - f3 + f4) / (4 * h * h);
                }
                else
                {

                    exp.setArgumentValue(i, xs[i] + 2 * h);
                    f1 = exp.calculate();

                    exp.setArgumentValue(i, xs[i]);
                    f2 = exp.calculate();

                    exp.setArgumentValue(i, xs[i] - 2 * h);
                    f3 = exp.calculate();

                    p = (f1 - 2 * f2 + f3) / (4 * h * h);
                }

                if (Double.IsInfinity(p) || Double.IsNaN(p))
                {
                    return q;
                }
            } while (it != itMax && Math.Abs(p - q) > errorMax);

            return p;
        }

        public double derivate3(String i = "x")
        {
            double p, q, f1, f2, f3, f4, h = this.h;
            int it = 0;

            loadArguments();

            exp.setArgumentValue(i, xs[i] + h);
            f1 = exp.calculate();

            exp.setArgumentValue(i, xs[i] - h);
            f2 = exp.calculate();

            exp.setArgumentValue(i, xs[i] + 3 * h);
            f3 = exp.calculate();

            exp.setArgumentValue(i, xs[i] - 3 * h);
            f4 = exp.calculate();

            p = (-3 * f1 + 3 * f2 + f3 - f4) / (8 * h * h * h);

            do
            {
                it++;
                q = p;
                h /= 2;

                exp.setArgumentValue(i, xs[i] + h);
                f1 = exp.calculate();

                exp.setArgumentValue(i, xs[i] - h);
                f2 = exp.calculate();

                exp.setArgumentValue(i, xs[i] + 3 * h);
                f3 = exp.calculate();

                exp.setArgumentValue(i, xs[i] - 3 * h);
                f4 = exp.calculate();

                p = (-3 * f1 + 3 * f2 + f3 - f4) / (8 * h * h * h);

                if (Double.IsInfinity(p) || Double.IsNaN(p))
                {
                    return q;
                }
            } while (it != itMax && Math.Abs(p - q) > errorMax);

            return p;
        }

        public double derivate4(String i = "x")
        {
            double p, q, f1, f2, f3, f4, f5, h = this.h;
            int it = 0;

            loadArguments();

            f1 = exp.calculate();

            exp.setArgumentValue(i, xs[i] + 4 * h);
            f2 = exp.calculate();

            exp.setArgumentValue(i, xs[i] - 4 * h);
            f3 = exp.calculate();

            exp.setArgumentValue(i, xs[i] + 2 * h);
            f4 = exp.calculate();

            exp.setArgumentValue(i, xs[i] - 2 * h);
            f5 = exp.calculate();

            p = (6 * f1 + f2 + f3 - 4 * f4 - 4 * f5) / (16 * h * h * h * h);

            do
            {
                it++;
                q = p;
                h /= 2;

                exp.setArgumentValue(i, xs[i]);
                f1 = exp.calculate();

                exp.setArgumentValue(i, xs[i] + 4 * h);
                f2 = exp.calculate();

                exp.setArgumentValue(i, xs[i] - 4 * h);
                f3 = exp.calculate();

                exp.setArgumentValue(i, xs[i] + 2 * h);
                f4 = exp.calculate();

                exp.setArgumentValue(i, xs[i] - 2 * h);
                f5 = exp.calculate();

                p = (6 * f1 + f2 + f3 - 4 * f4 - 4 * f5) / (16 * h * h * h * h);

                if (Double.IsInfinity(p) || Double.IsNaN(p))
                {
                    return q;
                }
            } while (it != itMax && Math.Abs(p - q) > errorMax);

            return p;
        }

        public double[] gradient()
        {
            double[] gradient = new double[xs.Count];

            for (int i = 0; i < xs.Count; i++)
            {
                gradient[i] = derivate1(xs.Keys[i]);
            }

            return gradient;
        }

        public double[,] hessian()
        {
            double[,] hessian = new double[xs.Count, xs.Count];

            for (var i = 0; i < xs.Count; i++)
            {
                for (var j = i; j < xs.Count; j++)
                {
                    hessian[i, j] = hessian[j, i] = derivate2(xs.Keys[i], xs.Keys[j]);
                }
            }

            return hessian;
        }

        public double[][] jacobian(String[] exps)
        {
            double[][] jacobian = new double[exps.Length][];

            Expression e = this.exp;

            for (var i = 0; i < exps.Length; i++)
            {
                exp = new Expression(exps[i]);
                jacobian[i] = gradient();
            }

            this.exp = e;

            return jacobian;
        }
    }
}