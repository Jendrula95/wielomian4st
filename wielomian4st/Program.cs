using System;
using System.Collections.Generic;
namespace wielomian4st
{
    class Program
    {
     

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            double f = (c / a) - (Math.Pow(3 *b, 2) / Math.Pow(8 * a, 2));
            Console.WriteLine("f = " + f);

            double g = (d / a) + (Math.Pow(b, 3) / Math.Pow(8 * a, 3)) - (b*c)/Math.Pow(2*a,2);
            Console.WriteLine("g = " + g);

            double h = (e / a) - (Math.Pow(36, 4) / Math.Pow(256 * a, 4)) + ((Math.Pow(b,2) * c)/Math.Pow(16 *a,3)) - (b*d)/Math.Pow(4*a,2);
            Console.WriteLine("h = " + h);
            Console.WriteLine("----------------------------------------------------------------");
            double a1 = 1;
            Console.WriteLine("a1 = " +a1);
            double b1 = (f/2);
            Console.WriteLine("b1 = " +b1);
            double c1 = (Math.Pow(f, 2) - (4 * b))/16;
            Console.WriteLine("c1 = " + c1);
            double d1 = -(Math.Pow(g, 2) / 64);
            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("----------------------------------------------------------------");
            double x = Math.Pow(a1, 3) + Math.Pow(b1, 2) + c1 + d1;
            Console.WriteLine("x = " + x);
            Console.WriteLine("----------------------------------------------------------------");
            double w = -b / 3 * a;
            Console.WriteLine("w = " + w);
            Console.WriteLine("----------------------------------------------------------------");
            double p = (((3 * a1) * Math.Pow(w, 2)) + (2 * b1 * w) + c1) / a1;
            Console.WriteLine("p = " +p);
            double q = ((a1 * Math.Pow(w, 3)) + (b1 * Math.Pow(w, 2) + (c1 * w) + d))/a;
            Console.WriteLine("q = " +q);
            Console.WriteLine("----------------------------------------------------------------");
            double delta = (Math.Pow(q, 2) / 4) + (Math.Pow(p, 3) / 27);
            Console.WriteLine("delta = " + delta);

            if (delta > 0)
            {
                double u = Math.Pow(-(q / 2) + Math.Sqrt(delta), 1.0 / 3.0);
                Console.WriteLine("u = " + u);
                double v = Math.Pow(-(q / 2) - Math.Sqrt(delta), 1.0 / 3.0);
                Console.WriteLine("v = " + v);
                Console.WriteLine("----------------------------------------------------------------");
                double y = u + v + w;
                Console.WriteLine("y = " + y);
                double y1 = (-(1 / 2) * (u + v) + w) + ((Math.Sqrt(3) / 2) * (u - v));
                Console.WriteLine("y1 = " + y1 + "i");
                double y2 = (-(1 / 2) * (u + v) + w) - ((Math.Sqrt(3) / 2) * (u - v));
                Console.WriteLine("y2 = " + y2 + "i");
                p = Math.Sqrt(y1);
                Console.WriteLine("p = " + p);
                q = Math.Sqrt(y2);
                Console.WriteLine("q =" + q);
                double r = -(g / (8 * p * q));
                Console.WriteLine("r = " + r);
                double s = b / (4 * a * b);
                Console.WriteLine("s = " + s);
            }
            else if(delta < 0) 
            {
                double fi = Math.Acos((3 * q) / (2 * p) * Math.Sqrt(-(p / 3)));
                Console.WriteLine("fi = " + fi);
                double y = w + (2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3) + ((2/3)*Math.PI)));
                Console.WriteLine("y = " +y);
                double y1 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos(fi / 3));
                Console.WriteLine("y1 = " +y1);
                double y2 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3) + ((4 / 3) * Math.PI)));
                Console.WriteLine("y2 = " + y2);
                p = Math.Sqrt(y1);
                Console.WriteLine("p = " + p);
                q = Math.Sqrt(y2);
                Console.WriteLine("q =" + q);
                double r = -(g / (8 * p * q));
                Console.WriteLine("r = " + r);
                double s = b / (4 * a * b);
                Console.WriteLine("s = " + s);
            }
            else if (delta == 0)
            {
                double y1 = w - (2 * Math.Pow(q / 2, 1.0 / 3.0));
                Console.WriteLine("y1 = " + y1);
                double y2 = w - (2 * Math.Pow(q / 2, 1.0 / 3.0));
                Console.WriteLine("y2 = " + y2);
                p = Math.Sqrt(y1);
                Console.WriteLine("p = " + p);
                q = Math.Sqrt(y2);
                Console.WriteLine("q =" +q);
                double r = -(g / (8 * p * q));
                Console.WriteLine("r = " + r);
                double s = b / (4 * a * b);
                Console.WriteLine("s = " + s);
            }
        }
    }
}
