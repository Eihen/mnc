using MNC.Derivatives;
using MNC.LinearSystems;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;

namespace MNC.NonLinearSystems
{
    class NonLinearSystem
    {
        private readonly String[] exps;
        private Expression exp;
        private SortedList<String, double> xs;
        private readonly double errorMax;
        private readonly int itMax;
        private Derivative d;

        public NonLinearSystem(String[] exps, SortedList<String, double> xs, int itMax = 100, double errorMax = 0.00001)
        {
            this.exps = exps;
            this.xs = xs;
            this.itMax = itMax;
            this.errorMax = errorMax;
            this.d = new Derivative("x1", xs, errorMax, itMax, errorMax);
            exp = new Expression();

            foreach (KeyValuePair<String, Double> x in xs)
            {
                exp.defineArgument(x.Key, x.Value);
            }
        }

        private void loadArgs()
        {
            foreach (KeyValuePair<String, Double> x in xs)
            {
                exp.setArgumentValue(x.Key, x.Value);
            }
        }

        public SortedList<String, double> newton()
        {
            double[][] j, t;
            double[] h, f = new double[exps.Length];
            double x;
            Boolean a;
            int it = 0;
            do
            {
                it++;
                a = true;
                j = d.jacobian(exps);
                loadArgs();
                for (int i = 0; i < exps.Length; i++)
                {
                    exp.setExpressionString(exps[i]);
                    if (!exp.checkSyntax())
                        throw new Exception("A expressão " + (i + 1) + " é inválida.");

                    f[i] = -1 * exp.calculate();
                }

                t = LinearSystem.copy(j);
                LinearSystem.gaussPartial(t, new double[1][] { f });
                h = LinearSystem.retrosubstitution(t, f);

                for (var i = 0; i < exps.Length; i++)
                {
                    x = xs.Values[i] + h[i];
                    if (Double.IsInfinity(x) || Double.IsNaN(x))
                    {
                        throw new NotFiniteNumberException("Erro ao realizar retrosubstituição, número não finito atingido.", x);
                    }
                    a = a && (Math.Abs(x - xs.Values[i]) < errorMax);
                    xs["x" + (i + 1)] = x;
                }
            } while (it < itMax && !a);

            return xs;
        }

        public SortedList<String, double> modifiedNewton()
        {
            double[][] j = d.jacobian(exps), t;
            double[] h, f = new double[exps.Length];
            double x;
            Boolean a;
            int it = 0;
            do
            {
                it++;
                a = true;

                if (it % 5 == 0)
                {
                    j = d.jacobian(exps);
                }

                loadArgs();
                for (int i = 0; i < exps.Length; i++)
                {
                    exp.setExpressionString(exps[i]);
                    if (!exp.checkSyntax())
                        throw new Exception("A expressão " + (i + 1) + " é inválida.");

                    f[i] = -1 * exp.calculate();
                }

                t = LinearSystem.copy(j);
                LinearSystem.gaussPartial(t, new double[1][] { f });
                h = LinearSystem.retrosubstitution(t, f);

                for (var i = 0; i < exps.Length; i++)
                {
                    x = xs.Values[i] + h[i];
                    if (Double.IsInfinity(x) || Double.IsNaN(x))
                    {
                        throw new NotFiniteNumberException("Erro ao realizar retrosubstituição, número não finito atingido.", x);
                    }
                    a = a && (Math.Abs(x - xs.Values[i]) < errorMax);
                    xs["x" + (i + 1)] = x;
                }
            } while (it < itMax && !a);

            return xs;
        }
    }
}
