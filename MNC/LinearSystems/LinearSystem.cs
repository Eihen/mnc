using System;

namespace MNC.LinearSystems
{
    public static class LinearSystem
    {
        public static double[][] transposed(double[][] a)
        {
            double[][] t = new double[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                t[i] = new double[a.Length];
                for (var j = 0; j < a.Length; j++)
                {
                    t[i][j] = a[j][i];
                }
            }

            return t;
        }

        public static double determinant(double[][] a)
        {
            double d = 1;
            for (var i = 0; i < a.Length; i++)
                d *= a[i][i];

            return d;
        }

        public static void swapRows(double[][] a, double[][] b, int row1, int row2)
        {
            double aux2;
            var aux1 = a[row1];
            a[row1] = a[row2];
            a[row2] = aux1;

            for (var i = 0; i < b.Length; i++)
            {
                aux2 = b[i][row1];
                b[i][row1] = b[i][row2];
                b[i][row2] = aux2;
            }
        }

        public static void swapColumns(double[][] a, int[] v, int col1, int col2)
        {
            double aux;
            for (var i = 0; i < a.Length; i++)
            {
                aux = a[i][col1];
                a[i][col1] = a[i][col2];
                a[i][col2] = aux;
            }

            var pos = v[col1];
            v[col1] = v[col2];
            v[col2] = pos;
        }

        public static double[][] identity(int o)
        {
            double[][] id = new double[o][];
            for (var i = 0; i < o; i++)
            {
                id[i] = new double[o];
                id[i][i] = 1;
            }
            return id;
        }

        public static double[][] copy(double[][] a)
        {
            double[][] b = new double[a.Length][];
            for (var i = 0; i < a.Length; i++)
            {
                b[i] = new double[a.Length];
                for (var j = 0; j < a.Length; j++)
                    b[i][j] = a[i][j];
            }
            return b;
        }

        public static double[] retrosubstitution(double[][] a, double[] v)
        {
            double[] x = new double[a.Length];
            double s;

            for (var i = a.Length - 1; i >= 0; i--)
            {
                s = 0;
                for (var j = a.Length - 1; j > i; j--)
                    s += x[j] * a[i][j];
                x[i] = (v[i] - s) / a[i][i];
                if (Double.IsInfinity(x[i]) || Double.IsNaN(x[i]))
                {
                    throw new NotFiniteNumberException("Erro ao realizar retrosubstituição, número não finito atingido.", x[i]);
                }
            }
            return x;
        }

        public static double[] substitution(double[][] a, double[] v)
        {
            double[] x = new double[a.Length];
            double s;

            for (var i = 0; i < a.Length; i++)
            {
                s = 0;
                for (var j = 0; j < i; j++)
                    s += x[j] * a[i][j];
                x[i] = (v[i] - s) / a[i][i];
                if (Double.IsInfinity(x[i]) || Double.IsNaN(x[i]))
                {
                    throw new NotFiniteNumberException("Ocorreu um erro durante a substituição, número não finito atingido.", x[i]);
                }
            }
            return x;
        }

        public static double distance(double[] p, double[] q)
        {
            double s = 0;
            for (var i = 0; i < p.Length; i++)
                s += (p[i] - q[i]) * (p[i] - q[i]);
            if (s < 0)
                throw new Exception("Erro ao calcular distância entre pontos, número não real.");
            else
                return Math.Sqrt(s);
        }

        public static double[][] gauss(double[][] a, double[][] b)
        {
            double m;
            for (var k = 0; k < a.Length; k++)
                for (var i = k + 1; i < a.Length; i++)
                {
                    m = a[i][k] / a[k][k];
                    if (Double.IsInfinity(m) || Double.IsNaN(m))
                        throw new NotFiniteNumberException("Erro ao aplicar o método de gauss, número não finito atingido.", m);

                    for (var j = 0; j < a.Length; j++)
                        a[i][j] = a[i][j] - m * a[k][j];
                    for (var n = 0; n < b.Length; n++)
                        b[n][i] = b[n][i] - m * b[n][k];
                }
            return a;
        }

        public static double[][] gaussReverse(double[][] a)
        {
            double[][] b = identity(a.Length), t = new double[a.Length][];
            gauss(a, b);
            for (var i = 0; i < a.Length; i++)
                t[i] = retrosubstitution(a, b[i]);
            return transposed(t);
        }

        public static int gaussPartial(double[][] a, double[][] b)
        {
            double m;
            int iMax, nSwaps = 0;

            for (var k = 0; k < a.Length; k++)
                for (var i = k + 1; i < a.Length; i++)
                {
                    iMax = k;
                    for (var l = i; l < a.Length; l++)
                        if (a[l][k] > a[iMax][k])
                            iMax = l;
                    if (iMax != k)
                    {
                        swapRows(a, b, k, iMax);
                        nSwaps++;
                    }

                    m = a[i][k] / a[k][k];
                    if (Double.IsInfinity(m) || Double.IsNaN(m))
                        throw new NotFiniteNumberException("Erro ao triangularizar a matriz com gauss parcial, número não finito atingido.", m);

                    for (var j = 0; j < a.Length; j++)
                        a[i][j] = a[i][j] - m * a[k][j];
                    for (var n = 0; n < b.Length; n++)
                        b[n][i] = b[n][i] - m * b[n][k];
                }

            return nSwaps;
        }

        public static double[][] gaussPartialReverse(double[][] a)
        {
            double[][] b = identity(a.Length), t = new double[a.Length][];
            gaussPartial(a, b);

            for (var i = 0; i < a.Length; i++)
            {
                t[i] = retrosubstitution(a, b[i]);
            }
            return transposed(t);
        }

        public static int gaussFull(double[][] a, double[][] b, int[] p)
        {
            double m;
            int iMax, jMax, nSawps = 0;

            for (var k = 0; k < a.Length; k++)
                for (var i = k + 1; i < a.Length; i++)
                {
                    iMax = jMax = k;
                    for (var l = i; l < a.Length; l++)
                        for (var c = i; c < a.Length; c++)
                            if (a[l][c] > a[iMax][jMax])
                            {
                                iMax = l;
                                jMax = c;
                            }
                    if (iMax != k)
                    {
                        swapRows(a, b, k, iMax);
                        nSawps++;
                    }
                    if (jMax != k)
                    {
                        swapColumns(a, p, k, jMax);
                        nSawps++;
                    }

                    m = a[i][k] / a[k][k];

                    if (Double.IsInfinity(m) || Double.IsNaN(m))
                        throw new NotFiniteNumberException("Erro ao triangularizar a matriz com gauss total, número não finito atingido", m);

                    for (var j = 0; j < a.Length; j++)
                        a[i][j] = a[i][j] - m * a[k][j];
                    for (var n = 0; n < b.Length; n++)
                        b[n][i] = b[n][i] - m * b[n][k];
                }
            return nSawps;
        }

        public static double[][] gaussFullReverse(double[][] a)
        {
            double[][] b = identity(a.Length), t = new double[a.Length][];
            int[] p = new int[a.Length];
            int k;

            for (var i = 0; i < a.Length; i++)
                p[i] = i;

            gaussFull(a, b, p);

            for (var i = 0; i < a.Length; i++)
            {
                var x = retrosubstitution(a, b[i]);
                for (var j = 0; j < a.Length; j++)
                {
                    for (k = 0; k < a.Length && p[k] != j; k++) ;
                    t[i][j] = x[k];
                }
            }
            return transposed(t);
        }

        public static double[][] lu(double[][] a)
        {
            double[][] l = identity(a.Length), u = new double[a.Length][];
            double s;

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = i; j < a.Length; j++)
                {
                    s = 0;
                    for (var k = 0; k < i; k++)
                        s += l[i][k] * u[k][j];
                    u[i][j] = a[i][j] - s;
                }
                for (var j = i + 1; j < a.Length; j++)
                {
                    s = 0;
                    for (var k = 0; k < j; k++)
                        s += l[j][k] * u[k][i];
                    l[j][i] = (a[j][i] - s) / u[i][i];
                    if (Double.IsInfinity(l[j][i]) || Double.IsNaN(l[j][i]))
                        throw new NotFiniteNumberException("Erro ao triangular matriz com o método LU, número não finito atingido", l[j][i]);
                }
            }
            return a;
        }

        public static double[][] gaussCompact(double[][] a, double[][] b)
        {
            double[][] lu = identity(a.Length);
            double s;

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = i; j < a.Length; j++)
                {
                    s = 0;
                    for (var k = 0; k < i; k++)
                        s += lu[i][k] * lu[k][j];
                    lu[i][j] = a[i][j] - s;
                }
                for (var j = i + 1; j < a.Length; j++)
                {
                    s = 0;
                    for (var k = 0; k < j; k++)
                        s += lu[j][k] * lu[k][i];
                    lu[j][i] = (a[j][i] - s) / lu[i][i];
                    if (Double.IsInfinity(lu[j][i]) || Double.IsNaN(lu[j][i]))
                        throw new NotFiniteNumberException("Erro ao triangularizar a matriz com gauss compacto, número não finito atingido.", lu[j][i]);
                }
                for (var n = 0; n < b.Length; n++)
                {
                    s = 0;
                    for (var m = 0; m < i; m++)
                        s += lu[i][m] * b[n][m];
                    b[n][i] = b[n][i] - s;
                }
            }
            return lu;
        }

        public static double[][] cholesky(double[][] a, double[] b)
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = i; j < a.Length; j++)
                    if (a[i][j] != a[j][i])
                        throw new Exception("Erro ao aplicar o método de choesky, a matriz não é simétrica.");

            double[][] g = new double[a.Length][];
            double[][] gT = new double[a.Length][];
            double s;

            for (int j = 0; j < a.Length; j++)
            {
                s = 0;
                for (int k = 0; k < j; k++)
                    s += g[j][k] * g[j][k];
                g[j][j] = gT[j][j] = Math.Sqrt(a[j][j] - s);

                for (int i = j + 1; i < a.Length; i++)
                {
                    s = 0;
                    for (int k = 0; k < j; k++)
                        s += g[j][k] * g[i][k];
                    g[i][j] = gT[j][i] = (a[i][j] - s) / g[j][j];
                }
            }

            return a;
        }

        public static double[] jacobi(double[][] a, double[] b, double[] estimative, double errorMax, int itMax)
        {
            double[] q = estimative, p = new double[q.Length];
            double s;
            int it = 0;

            do
            {
                it++;
                for (int k = 0; k < a.Length; k++)
                    p[k] = q[k];

                for (int i = 0; i < a.Length; i++)
                {
                    s = 0;
                    for (int j = 0; j < a.Length; j++)
                        if (j != i)
                            s += a[i][j] * p[j];
                    q[i] = (b[i] - s) / a[i][i];
                    if (Double.IsInfinity(q[i]) || Double.IsNaN(q[i]))
                        throw new NotFiniteNumberException("Erro ao aplicar o método de jacobi, número não finito atingido", q[i]);
                }
            } while (distance(p, q) > errorMax && it != itMax);

            return q;
        }

        public static double[] gaussSeidel(double[][] a, double[] b, double[] estimative, double errorMax, int itMax)
        {
            double[] q = estimative, p = new double[q.Length];
            double s;
            int it = 0;

            do
            {
                it++;
                for (int k = 0; k < a.Length; k++)
                    p[k] = q[k];

                for (int i = 0; i < a.Length; i++)
                {
                    s = 0;
                    for (int j = 0; j < a.Length; j++)
                        if (i != j)
                            s += a[i][j] * (j < i ? q[j] : p[j]);
                    q[i] = (b[i] - s) / a[i][i];
                    if (Double.IsInfinity(q[i]) || Double.IsNaN(q[i]))
                        throw new NotFiniteNumberException("Erro ao aplicaro método de Gauss-Seidel, número não finito atingido.", q[i]);
                }
            } while (distance(p, q) > errorMax && it != itMax);

            return q;
        }
    }
}

