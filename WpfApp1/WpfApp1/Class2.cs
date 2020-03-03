using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Class2
    {
        public double mnozenie(double x,double y)
        {
            return x * y;
        }

        public double dzielenie(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }else
            return x / y;
        }
    }
}
