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
        private double[][] points;
        private double sy2, s2y;
        private readonly char[] trimChars = { '0', '.', ',', ' ' };

        public Fitting(double[][] points)
        {
            sy2 = s2y = 0;
            for (int i = 0; i < points.Length; i++)
            {
                sy2 += points[1][i] * points[1][i];
                s2y += points[1][i];
            }
            s2y *= s2y;
        }

        private double sum(double[] x, int e)
        {
            double p, s = 0;
            for (int i = 0; i < points[0].Length; i++)
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

        private String coefficient(String e, String var)
        {
            double c, sumE = 0;
            Expression exp = new Expression(e);
            exp.defineArgument(var, 0);
            
            if (!exp.checkSyntax())
                throw new Exception("A expressão informada não é válida.");

            for (int i = 0; i < points.Length; i++)
            {
                exp.setArgumentValue(var, points[0][i]);
                sumE += Math.Pow(points[1][i] - exp.calculate(), 2);
            }

            c = 1 - (points.Length * sumE / (points.Length * sy2 - s2y));

            if (Double.IsNaN(c) || Double.IsInfinity(c))
            {
                throw new NotFiniteNumberException("Não foi possível calcular o coeficiente de terminação, número não finito atingido.", c);
            }

            return c.ToString().TrimEnd(trimChars);
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

        public String polynomial(int o)
        {
            double[] c = linear(points, o);
            StringBuilder r = new StringBuilder("");

            for (int i = c.Length - 1; i >= 0; i++)
            {
                if (c[i] != 0)
                {
                    if (c[i] != 1)
                    {
                        r.Append(c[i].ToString().TrimEnd(trimChars));
                    }
                    if (i != 0)
                    {
                        r.Append((c[i]!=1? "*" : "") + "x");
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
                return coefficient(r.ToString(), "x");
            }
        }


        public void fittingABX()
        {
            double[][] ps = new double[2][];
            ps[0] = new double[points.Length];
            ps[1] = new double[points.Length];
            int sb = 2;
            double[] c;
            String result;
            for (int i = 0; i < points.Length; i++)
            {
                ps[0][i] = Math.Log(points[0][i]);
                ps[1][i] = Math.Log(points[1][i]);
                if (Double.IsInfinity(ps[1][i]) || Double.IsNaN(ps[1][i]) || Double.IsInfinity(ps[0][i]) || Double.IsNaN(ps[0][i]))
                {
                    throw new NotFiniteNumberException("Não foi possível calcular o coeficiente de terminação, número não finito atingido.");
                }
            }

            c = linear(ps, 2);
        }

    }
}
