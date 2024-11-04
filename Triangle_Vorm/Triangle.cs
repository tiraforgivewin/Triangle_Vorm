using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    internal class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;

        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }

        public string outputA()
            { return Convert.ToString(a); }

        public string outputB()
        { return Convert.ToString(b); }

        public string outputC()
        { return Convert.ToString(c); }

        public string outputH()
        { return Convert.ToString(h); }


        public double Perimetr()
            { double p = 0;
            p = a + b + c;
            return p; }


        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s =Math.Sqrt((p *(p-a)*(p-b)*(p-c)));
            return s;
        }

        public double Ruut()
        {
            double s = 0;
            s = (h * a) / 2;
            return s;

        }






        public double GetSetA
        {   get { return a; } 
            set { a = value; }
        }

        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }

        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }

        public double GetSetH
        {
            get { return h; }
            set { h = value; }
        }

        public bool ExistTriangle
            { get 
            {   if ((a > b + c) && (b > a + c) && (c > b + a))
                return false;
                else  return true ;
            } 
        
        
        }


    }
}
