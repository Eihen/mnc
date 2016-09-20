using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using MNC.Derivatives;

namespace MNC.Roots
{
    public class Root
    {
        Expression exp;
        List<Range> ranges;
        readonly double bigDelta, delta, errorMax;
        readonly int iMax;

        public Root(String exp, double a, double b, double bigDelta, int iMax, double errorMax)
        {
            this.exp = new Expression(exp);
            this.exp.defineArgument("x", 0);

            if (!this.exp.checkSyntax())
                throw new NotImplementedException("A expressão informada não é válida.");

            this.bigDelta = bigDelta;

            //Same number of intervals as the original range
            this.delta = bigDelta * bigDelta / (b - a);

            this.errorMax = errorMax;
            this.iMax = iMax;
            findRanges(a, b);
        }

        public void findRanges(double a, double b)
        {
            double p, q = a, f1;
            ranges = new List<Range>();

            do
            {
                p = q;
                q += bigDelta;

                exp.setArgumentValue("x", p);
                f1 = exp.calculate();
                exp.setArgumentValue("x", q);

                if (f1 * exp.calculate() <= 0)
                {
                    ranges.Add(new Range(p, q));
                }
            } while (p < b);
        }

        public List<double> uniformSearch()
        {
            double p, q, fp, fq;
            var roots = new List<double>();
            int it;
            Boolean found;

            for (var i = 0; i < ranges.Count; i++)
            {
                p = ranges[i].a;
                q = ranges[i].b;

                it = 0;
                found = false;

                exp.setArgumentValue("x", q);
                fq = exp.calculate();

                do
                {
                    it++;
                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();

                    if ((found = Math.Abs(fp) < errorMax) && !roots.Contains(p))
                        roots.Add(p);
                    p += delta;
                } while (!found && fp * fq <= 0 && it != iMax);

                if (!found && it != iMax)
                {
                    p -= delta;
                    it = 0;
                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();
                    do
                    {
                        it++;
                        exp.setArgumentValue("x", q);
                        fq = exp.calculate();
                        if ((found = Math.Abs(fq) < errorMax) && !roots.Contains(p))
                            roots.Add(q);
                        q -= delta;
                    } while (!found && fp * fq <= 0 && it != iMax);

                    if (!found && it != iMax)
                    {
                        q += delta;
                        p = (p + q) / 2;

                        exp.setArgumentValue("x", p);
                        fp = exp.calculate();

                        if (Math.Abs(fp) < errorMax && !roots.Contains(p))
                            roots.Add(q);
                    }
                }
            }

            return roots;
        }

        public List<double> bisection()
        {
            double p, fa, fp, a, b;
            var roots = new List<double>();
            int it;
            Boolean found;

            for (var i = 0; i < ranges.Count; i++)
            {
                it = 0;
                found = false;

                a = ranges[i].a;
                b = ranges[i].b;

                do
                {
                    it++;
                    exp.setArgumentValue("x", a);
                    fa = exp.calculate();

                    if (found = Math.Abs(fa) < errorMax)
                    {
                        if (!roots.Contains(a))
                            roots.Add(a);
                    }
                    else
                    {
                        p = (a + b) / 2;
                        exp.setArgumentValue("x", p);
                        fp = exp.calculate();

                        if (found = Math.Abs(fp) < errorMax)
                        {
                            if (!roots.Contains(p))
                                roots.Add(p);
                        }
                        else
                        {
                            if (fp * fa < 0)
                                b = p;
                            else
                                a = p;
                        }
                    }
                } while (!found && Math.Abs(b - a) > errorMax && it != iMax);

                if (!found && it != iMax)
                {
                    p = (a + b) / 2;

                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();

                    if (Math.Abs(fp) < errorMax && !roots.Contains(p))
                    {
                        roots.Add(p);
                    }
                }
            }

            return roots;
        }

        public List<double> falsePosition()
        {
            double p, fa, fb, fp, a, b;
            var roots = new List<double>();
            int it;
            Boolean found;

            for (var i = 0; i < ranges.Count; i++)
            {
                it = 0;
                found = false;

                a = ranges[i].a;
                b = ranges[i].b;

                do
                {
                    it++;

                    exp.setArgumentValue("x", a);
                    fa = exp.calculate();

                    if (found = Math.Abs(fa) < errorMax)
                    {
                        if (!roots.Contains(a))
                            roots.Add(a);
                    }
                    else
                    {
                        exp.setArgumentValue("x", b);
                        fb = exp.calculate();
                        p = a * fb - b * fa / (fb - fa);
                        exp.setArgumentValue("x", p);
                        fp = exp.calculate();
                        if (found = Math.Abs(fp) < errorMax)
                        {
                            if (!roots.Contains(p))
                                roots.Add(p);
                        }
                        else
                        {
                            if (fp * fa < 0)
                                b = p;
                            else
                                a = p;
                        }
                    }
                } while (!found && Math.Abs(b - a) > errorMax && it != iMax);

                if (!found && it != iMax)
                {
                    p = (a + b) / 2;

                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.Contains(p))
                    {
                        roots.Add(p);
                    }
                }
            }

            return roots;
        }

        public List<double> modifiedFalsePosition()
        {
            double p, fa, fb, fp, a, b;
            var roots = new List<double>();
            int it, ca, cb;
            Boolean found;

            for (var i = 0; i < ranges.Count; i++)
            {
                it = ca = cb = 0;
                found = false;
                a = ranges[i].a;
                b = ranges[i].b;

                do
                {
                    it++;

                    exp.setArgumentValue("x", a);
                    fa = exp.calculate();
                    exp.setArgumentValue("x", b);
                    fb = exp.calculate();

                    if (found = Math.Abs(fa) < errorMax)
                    {
                        if (!roots.Contains(a))
                            roots.Add(a);
                    }
                    else if (found = Math.Abs(fb) < errorMax)
                    {
                        if (!roots.Contains(b))
                            roots.Add(b);
                    }
                    else
                    {
                        if (ca == 2)
                        {
                            ca = 0;
                            p = a * fb / 2 - b * fa / (fb / 2 - fa);
                        }
                        else if (cb == 2)
                        {
                            cb = 0;
                            p = a * fb - b * fa / 2 / (fb - fa / 2);
                        }
                        else
                        {
                            p = a * fb - b * fa / (fb - fa);
                        }

                        exp.setArgumentValue("x", p);
                        fp = exp.calculate();
                        if (fp * fa < 0)
                        {
                            b = p;
                            ca++;
                            cb = 0;
                        }
                        else
                        {
                            a = p;
                            cb++;
                            ca = 0;
                        }
                    }
                } while (!found && Math.Abs(b - a) > errorMax && it != iMax);

                if (!found && it != iMax)
                {
                    p = (a + b) / 2;
                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.Contains(p))
                    {
                        roots.Add(p);
                    }
                }
            }

            return roots;
        }

        public List<double> newton()
        {
            double p, q, fp;
            var roots = new List<double>();
            Derivative d;
            var xs = new SortedList<String, double>();
            int it;
            Boolean found;

            xs.Add("x", 0);

            for (var i = 0; i < ranges.Count; i++)
            {
                it = 0;
                found = false;
                q = ranges[i].a;

                do
                {
                    it++;
                    p = q;
                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();

                    if (found = Math.Abs(fp) < errorMax)
                    {
                        if (!roots.Contains(p))
                            roots.Add(p);
                    }
                    else
                    {
                        xs["x"] = p;
                        d = new Derivative(exp.getExpressionString(), xs);
                        q = p - fp / d.derivate1();
                    }
                } while (!found && Math.Abs(p - q) > errorMax && it != iMax);

                if (!found && it != iMax)
                {
                    exp.setArgumentValue("x", q);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.Contains(q))
                        roots.Add(q);
                }
            }
            return roots;
        }

        public List<double> modifiedNewton(int iDerivate = 5)
        {
            double p, q, fp, derivative = 0;
            var roots = new List<double>();
            Derivative d;
            var xs = new SortedList<String, double>();
            int it, c;
            Boolean found;

            for (var i = 0; i < ranges.Count; i++)
            {
                it = c = 0;
                found = false;
                q = ranges[i].a;

                do
                {
                    it++;
                    p = q;
                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();

                    if (found = Math.Abs(fp) < errorMax)
                    {
                        if (!roots.Contains(p))
                            roots.Add(p);
                    }
                    else
                    {
                        if (c == 0)
                        {

                            xs["x"] = p;
                            d = new Derivative(exp.getExpressionString(), xs);
                            derivative = d.derivate1();
                            c = iDerivate;
                        }
                        c--;
                        q = p - fp / derivative;
                    }
                } while (!found && Math.Abs(p - q) > errorMax && it != iMax);

                if (!found && it != iMax)
                {
                    exp.setArgumentValue("x", q);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.Contains(q))
                        roots.Add(q);
                }
            }

            return roots;
        }

    }

}