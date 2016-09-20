using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using MNC.Derivatives;

namespace MNC.Roots
{
    public class Root
    {
        private Expression exp;
        private List<Range> ranges;
        private readonly double bigDelta, delta, errorMax;
        private readonly int itMax;

        public List<Range> Ranges
        {
            get { return ranges; }
        }

        public Root(String exp, double a, double b, double bigDelta, double delta, int itMax, double errorMax)
        {
            this.exp = new Expression(exp);
            this.exp.defineArgument("x", 0);

            if (!this.exp.checkSyntax())
                throw new Exception("A expressão informada não é válida.");

            this.bigDelta = bigDelta;
            this.delta = delta;

            this.errorMax = errorMax;
            this.itMax = itMax;
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

        public SortedList<double, double> uniformSearch()
        {
            double p, q, fp, fq;
            var roots = new SortedList<double, double>();
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

                    if ((found = Math.Abs(fp) < errorMax) && !roots.ContainsKey(p))
                        roots.Add(p, fp);
                    p += delta;
                } while (!found && fp * fq <= 0 && it != itMax);

                if (!found && it != itMax)
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
                        if ((found = Math.Abs(fq) < errorMax) && !roots.ContainsKey(p))
                            roots.Add(q, fq);
                        q -= delta;
                    } while (!found && fp * fq <= 0 && it != itMax);

                    if (!found && it != itMax)
                    {
                        q += delta;
                        p = (p + q) / 2;

                        exp.setArgumentValue("x", p);
                        fp = exp.calculate();

                        if (Math.Abs(fp) < errorMax && !roots.ContainsKey(p))
                            roots.Add(q, fp);
                    }
                }
            }

            return roots;
        }

        public SortedList<double, double> bisection()
        {
            double p, fa, fp, a, b;
            var roots = new SortedList<double, double>();
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
                        if (!roots.ContainsKey(a))
                            roots.Add(a, fa);
                    }
                    else
                    {
                        p = (a + b) / 2;
                        exp.setArgumentValue("x", p);
                        fp = exp.calculate();

                        if (found = Math.Abs(fp) < errorMax)
                        {
                            if (!roots.ContainsKey(p))
                                roots.Add(p, fp);
                        }
                        else
                        {
                            if (fp * fa < 0)
                                b = p;
                            else
                                a = p;
                        }
                    }
                } while (!found && Math.Abs(b - a) > errorMax && it != itMax);

                if (!found && it != itMax)
                {
                    p = (a + b) / 2;

                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();

                    if (Math.Abs(fp) < errorMax && !roots.ContainsKey(p))
                    {
                        roots.Add(p, fp);
                    }
                }
            }

            return roots;
        }

        public SortedList<double, double> falsePosition()
        {
            double p, fa, fb, fp, a, b;
            var roots = new SortedList<double, double>();
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
                        if (!roots.ContainsKey(a))
                            roots.Add(a, fa);
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
                            if (!roots.ContainsKey(p))
                                roots.Add(p, fp);
                        }
                        else
                        {
                            if (fp * fa < 0)
                                b = p;
                            else
                                a = p;
                        }
                    }
                } while (!found && Math.Abs(b - a) > errorMax && it != itMax);

                if (!found && it != itMax)
                {
                    p = (a + b) / 2;

                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.ContainsKey(p))
                    {
                        roots.Add(p, fp);
                    }
                }
            }

            return roots;
        }

        public SortedList<double, double> modifiedFalsePosition()
        {
            double p, fa, fb, fp, a, b;
            var roots = new SortedList<double, double>();
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
                        if (!roots.ContainsKey(a))
                            roots.Add(a, fa);
                    }
                    else if (found = Math.Abs(fb) < errorMax)
                    {
                        if (!roots.ContainsKey(b))
                            roots.Add(b, fb);
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
                } while (!found && Math.Abs(b - a) > errorMax && it != itMax);

                if (!found && it != itMax)
                {
                    p = (a + b) / 2;
                    exp.setArgumentValue("x", p);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.ContainsKey(p))
                    {
                        roots.Add(p, fp);
                    }
                }
            }

            return roots;
        }

        public SortedList<double, double> newton()
        {
            double p, q, fp;
            var roots = new SortedList<double, double>();
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
                        if (!roots.ContainsKey(p))
                            roots.Add(p, fp);
                    }
                    else
                    {
                        xs["x"] = p;
                        d = new Derivative(exp.getExpressionString(), xs);
                        q = p - fp / d.derivate1();
                    }
                } while (!found && Math.Abs(p - q) > errorMax && it != itMax);

                if (!found && it != itMax)
                {
                    exp.setArgumentValue("x", q);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.ContainsKey(q))
                        roots.Add(q, fp);
                }
            }
            return roots;
        }

        public SortedList<double, double> modifiedNewton(int iDerivate = 5)
        {
            double p, q, fp, derivative = 0;
            var roots = new SortedList<double, double>();
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
                        if (!roots.ContainsKey(p))
                            roots.Add(p, fp);
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
                } while (!found && Math.Abs(p - q) > errorMax && it != itMax);

                if (!found && it != itMax)
                {
                    exp.setArgumentValue("x", q);
                    fp = exp.calculate();
                    if (Math.Abs(fp) < errorMax && !roots.ContainsKey(q))
                        roots.Add(q, fp);
                }
            }

            return roots;
        }

    }

}