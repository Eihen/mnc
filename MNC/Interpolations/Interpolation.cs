using MNC.LinearSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNC.Interpolations
{
    class Interpolation
    {
        private readonly List<KeyValuePair<double, double>> points;
        private readonly char[] trimChars = { '0', '.', ',', ' ' };

        public Interpolation(List<KeyValuePair<double, double>> points)
        {
            this.points = points;
        }

        public String linearSystem()
        {
            double[][] a = new double[points.Count][], b = new double[1][];
            double[] solution;
            StringBuilder result = new StringBuilder(String.Empty);
            b[0] = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new double[points.Count];
                a[i][0] = 1;
                b[0][i] = points[i].Value;
                for (int j = 1; j < a.Length; j++)
                {
                    a[i][j] = a[i][j - 1] * points[i].Key;
                }
            }

            LinearSystem.gauss(a, b);
            solution = LinearSystem.retrosubstitution(a, b[0]);

            for (int i = solution.Length - 1; i >= 0; i--)
            {
                if (solution[i] != 0)
                {
                    if (i == 0 || solution[i] != 1)
                    {
                        result.Append(solution[i].ToString().TrimEnd(trimChars));
                    }

                    if (i != 0)
                    {
                        result.Append((solution[i] != 1 ? "*" : "") + "x");
                        if (i > 1)
                        {
                            result.Append("^" + i);
                        }
                        if (solution[i - 1] > 0)
                        {
                            result.Append("+");
                        }
                    }
                }
            }
            return result.ToString().Equals(String.Empty) ? "0" : result.ToString();
        }

        public String newton()
        {
            double[][] d = new double[points.Count][];
            double[] x = new double[points.Count];
            StringBuilder result = new StringBuilder(String.Empty);

            for (int i = 0; i < points.Count; i++)
            {
                x[i] = points[i].Key;
                d[i] = new double[points.Count];
                d[i][0] = points[i].Value;
            }

            for (int i = 1; i < points.Count; i++)
            {
                for (int j = 0; j < points.Count - i; j++)
                {
                    d[j][i] = (d[j + 1][i - 1] - d[j][i - 1]) / (x[j + i] - x[j]);
                }
            }

            for (int i = 0; i < points.Count; i++)
            {
                if (d[0][i] != 0)
                {
                    result.Append(d[0][i].ToString().TrimEnd(trimChars) + "+");
                }
                if (x[i] == 0)
                {
                    result.Append("x");
                }
                else
                {
                    result.Append("(x");
                    if (x[i] > 0)
                    {
                        result.Append("-" + x[i].ToString().TrimEnd(trimChars));
                    }
                    else
                    {
                        result.Append("+" + Math.Abs(x[i]).ToString().TrimEnd(trimChars));
                    }
                    result.Append(")");
                }
                if (i != points.Count - 1)
                {
                    result.Append("*(");
                }
            }

            for (int i = 0; i < points.Count - 1; i++)
                result.Append(")");

            return result.ToString();
        }

        public String newtonGregory()
        {
            double[][] d = new double[points.Count][];
            double[] x = new double[points.Count];
            long f = 1;
            StringBuilder result = new StringBuilder(String.Empty);

            for (int i = 0; i < points.Count; i++)
            {
                x[i] = points[i].Key;
                d[i] = new double[points.Count];
                d[i][0] = points[i].Value;
            }

            if (points.Count > 2)
            {
                double distance = x[1] - x[0];
                for (int i = 2; i < points.Count; i++)
                    if (x[i] - x[i - 1] != distance)
                        throw new Exception("Não foi possível aplicar o método de Newton-Gregory, os valores não estão igualmente espaçados.");
            }
            
            for (int i = 1; i < points.Count; i++)
            {
                for (int j = 0; j < points.Count - i; j++)
                {
                    d[j][i] = (d[j + 1][i - 1] - d[j][i - 1]);
                }
            }

            for (int i = 0; i < points.Count; i++)
            {
                f *= (i + 1);
                if (d[0][i] != 0)
                {
                    result.Append((d[0][i] / f).ToString().TrimEnd(trimChars) + "+");
                }
                if (i == 0)
                {
                    result.Append("s");
                }
                else
                {
                    result.Append("(s-" + i + ")");
                }

                if (i != points.Count - 1)
                {
                    result.Append("*(");
                }
            }

            for (int i = 0; i < points.Count - 1; i++)
                result.Append(")");

            return result.ToString();
        }
    }
}
