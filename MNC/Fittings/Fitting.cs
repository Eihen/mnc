using MNC.LinearSystems;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNC.Fittings
{
    class Fitting
    {
        private List<KeyValuePair<double, double>> points;
        private double sy2, s2y;
        private readonly char[] trimChars = { '0', '.', ',', ' ' };

        public Fitting(List<KeyValuePair<double, double>> points)
        {
            sy2 = s2y = 0;
            for (int i = 0; i < points.Count; i++)
            {
                sy2 += points[i].Value * points[i].Value;
                s2y += points[i].Value;
            }
            s2y *= s2y;

            this.points = points;
        }

        private double sum(double[] x, int e)
        {
            double p, s = 0;
            for (int i = 0; i < points.Count; i++)
            {
                p = 1;
                for (int j = 0; j < e; j++)
                {
                    p *= x[i];
                }
                s += p;
            }
            return s;
        }

        private double sum(double[][] m, int e)
        {
            double p, s = 0;
            for (int i = 0; i < m.Length; i++)
            {
                p = 1;
                for (int j = 0; j < e; j++)
                {
                    p *= m[0][i];
                }
                s += p * m[1][i];
            }
            return s;
        }

        public double coefficient(String e, String var)
        {
            double c, sumE = 0;
            Expression exp = new Expression(e);
            exp.defineArgument(var, 0);

            if (!exp.checkSyntax())
                throw new Exception("A expressão informada não é válida.");

            for (int i = 0; i < points.Count; i++)
            {
                exp.setArgumentValue(var, points[i].Key);
                sumE += Math.Pow(points[i].Value - exp.calculate(), 2);
            }

            c = 1 - (points.Count * sumE / (points.Count * sy2 - s2y));

            if (Double.IsNaN(c) || Double.IsInfinity(c))
            {
                throw new NotFiniteNumberException("Não foi possível calcular o coeficiente de terminação, número não finito atingido.", c);
            }

            return c;
        }

        private double[] linear(double[][] ps, int o)
        {
            if (o > 0)
            {
                double[][] a = new double[o][];
                double[][] b = new double[1][];
                int j;

                for (int i = 0; i < o; i++)
                {
                    a[i] = new double[o];
                    a[0][i] = sum(ps[0], i);
                }
                b[0] = new double[o];
                b[0][0] = sum(ps, 0);

                for (int i = 1; i < o; i++)
                {
                    for (j = 0; j < o - 1; j++)
                    {
                        a[i][j] = a[i - 1][j + 1];
                    }
                    a[i][j] = sum(ps[0], i + j);
                    b[0][i] = sum(ps, i);
                }

                if (ps[0].Length > 1)
                {
                    LinearSystem.gauss(a, b);
                }

                return LinearSystem.retrosubstitution(a, b[0]);
            }
            else if (o == 0)
            {
                double s = 0;
                for (int i = 0; i < ps[1].Length; i++)
                {
                    s += ps[1][i];
                }
                return new double[] { s / ps[1].Length };
            }
            else
            {
                throw new Exception("Erro, ordem inválida.");
            }
        }

        public String fittingPolynomial(int o)
        {
            double[][] ps = new double[2][];
            ps[0] = new double[points.Count];
            ps[1] = new double[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                ps[1][i] = points[i].Value;
                ps[0][i] = points[i].Key;
            }

            double[] c = linear(ps, o);
            StringBuilder r = new StringBuilder("");

            for (int i = c.Length - 1; i >= 0; i--)
            {
                if (c[i] != 0)
                {
                    if (c[i] != 1)
                    {
                        r.Append(c[i].ToString().TrimEnd(trimChars));
                    }
                    if (i != 0)
                    {
                        r.Append((c[i] != 1 ? "*" : "") + "x");
                        if (i != 1)
                        {
                            r.Append("^" + i);
                        }
                        if (c[i - 1] > 0)
                        {
                            r.Append("+");
                        }
                    }
                }
            }

            if (r.ToString().Equals(String.Empty))
            {
                throw new Exception("Erro ao ajustar a curva por um polinômio.");
            }
            else
            {
                return r.ToString().Replace("+-", "-");
            }
        }


        public String fittingAbx()
        {
            double[][] ps = new double[2][];
            double[] c;
            double a, b;

            ps[0] = new double[points.Count];
            ps[1] = new double[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                ps[1][i] = Math.Log(points[i].Value);
                ps[0][i] = points[i].Key;
                if (Double.IsInfinity(ps[1][i]) || Double.IsNaN(ps[1][i]))
                {
                    throw new NotFiniteNumberException("Não foi possível calcular ln(" + ps[1][i] + "), número não finito atingido.");
                }
            }

            c = linear(ps, 2);
            a = Math.Exp(c[0]);
            b = Math.Exp(c[1]);

            if (a == 0)
            {
                return "0";
            }
            else
            {
                return (a + "*(" + b + "^x)").Replace("+-", "-");
            }
        }

        public String fittingAxb()
        {
            double[][] ps = new double[2][];
            double[] c;
            double a, b;

            ps[0] = new double[points.Count];
            ps[1] = new double[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                ps[0][i] = Math.Log(points[i].Key);
                ps[1][i] = Math.Log(points[i].Value);
                if (Double.IsInfinity(ps[1][i]) || Double.IsNaN(ps[1][i]))
                {
                    throw new NotFiniteNumberException("Não foi possível calcular ln(" + ps[1][i] + "), número não finito atingido.");
                }
                if (Double.IsInfinity(ps[0][i]) || Double.IsNaN(ps[0][i]))
                {
                    throw new NotFiniteNumberException("Não foi possível calcular ln(" + ps[0][i] + "), número não finito atingido.");
                }
            }

            c = linear(ps, 2);
            a = Math.Exp(c[0]);
            b = c[1];

            if (a == 0)
            {
                return "0";
            }
            else
            {
                return (a + "*(x^" + b + ")").Replace("+-", "-");
            }
        }

        public String fittingAebx()
        {
            double[][] ps = new double[2][];
            double[] c;
            double a, b;

            ps[0] = new double[points.Count];
            ps[1] = new double[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                ps[1][i] = Math.Log(points[i].Value);
                ps[0][i] = points[i].Key;
                if (Double.IsInfinity(ps[1][i]) || Double.IsNaN(ps[1][i]))
                {
                    throw new NotFiniteNumberException("Não foi possível calcular ln(" + ps[1][i] + "), número não finito atingido.");
                }
            }

            c = linear(ps, 2);
            a = Math.Exp(c[0]);
            b = c[1];

            if (a == 0)
            {
                return "0";
            }
            else
            {
                return (a + "*e^(" + b + "*x)").Replace("+-", "-");
            }
        }

        public String fitting1abx()
        {
            double[][] ps = new double[2][];
            double[] c;
            double a, b;

            ps[0] = new double[points.Count];
            ps[1] = new double[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                ps[1][i] = 1 / points[i].Value;
                ps[0][i] = points[i].Key;
                if (Double.IsInfinity(ps[1][i]) || Double.IsNaN(ps[1][i]))
                {
                    throw new NotFiniteNumberException("Não foi possível calcular ln(" + ps[1][i] + "), número não finito atingido.");
                }
            }

            c = linear(ps, 2);
            a = c[0];
            b = c[1];
            
            return ("1/(" + a + "+" + b + "*x)").Replace("+-", "-");
        }
    }
}
