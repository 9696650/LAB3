using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{


    namespace TrapezoidLib
    {
        public class Trapezoid
        {
            private double a, b, c, d, h;

            // читання значень
            public double A { get { return a; } }
            public double B { get { return b; } }
            public double C { get { return c; } }
            public double D { get { return d; } }
            public double H { get { return h; } }

            // конструктор без параметрів
            public Trapezoid()
            {
                a = 1;
                b = 1;
                c = 1;
                d = 1;
                h = 1;
            }

            // конструктор з параметрами
            public Trapezoid(double a, double b, double c, double d, double h)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
                this.h = h;
            }

            // конструктор копіювання
            public Trapezoid(Trapezoid t)
            {
                a = t.a;
                b = t.b;
                c = t.c;
                d = t.d;
                h = t.h;
            }

            // площа
            public double Area()
            {
                return (a + b) / 2 * h;
            }

            // периметр
            public double Perimeter()
            {
                return a + b + c + d;
            }

            // оператор --
            public static Trapezoid operator --(Trapezoid t)
            {
                return new Trapezoid(t.a - 1, t.b - 1, t.c - 1, t.d - 1, t.h - 1);
            }

            // оператор *
            public static Trapezoid operator *(Trapezoid t1, Trapezoid t2)
            {
                return new Trapezoid(
                    t1.a * t2.a,
                    t1.b * t2.b,
                    t1.c * t2.c,
                    t1.d * t2.d,
                    t1.h * t2.h);
            }
        }
    }

}
