using LAB_3.TrapezoidLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_3 {

   

    class Program
    {
        static void Main()
        {
            Trapezoid TR1 = new Trapezoid();
            Trapezoid TR2 = new Trapezoid(5, 6, 3, 3, 4);
            Trapezoid TR3 = new Trapezoid(TR2);

            Console.WriteLine("TR1:");
            Print(TR1);

            Console.WriteLine("TR2:");
            Print(TR2);

            Console.WriteLine("TR3:");
            Print(TR3);

            
            TR3--;

            Console.WriteLine("TR3 -- :");
            Print(TR3);

            
            TR1 = TR2 * TR3;

            Console.WriteLine("TR1 = TR2 * TR3:");
            Print(TR1);

            Console.WriteLine("S TR1: " + TR1.Area());
            Console.WriteLine("P TR1: " + TR1.Perimeter());
        }

        static void Print(Trapezoid t)
        {
            Console.WriteLine(
                "a=" + t.A +
                " b=" + t.B +
                " c=" + t.C +
                " d=" + t.D +
                " h=" + t.H);
        }
    }


}
