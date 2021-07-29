using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication
{
    interface INormalCal
    {
        int Add(int x, int y);
        int Sub(int x, int y);
    }
    interface ISciCal
    {
        int Add(int a, int b);
        int Mul(int x, int y);
    }
    class Calculator : INormalCal,ISciCal
    {
        int INormalCal.Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        int ISciCal.Add(int x, int y)
        {
            return x + y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
    interface InterfaceEg
    {
        static void Main()
        {
            INormalCal ncal = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}", ncal.Add(5, 7));
            Console.WriteLine("Subtraction of Normal Calculator:{0}", ncal.Sub(90, 7));
            ISciCal scal = new Calculator();
            Console.WriteLine("Addition of Scientific Calculator:{0}", scal.Add(5,7));
            Console.WriteLine("Multiplication of Scientific Calculator:{0}", scal.Add(90,7));
        }

    }
}
