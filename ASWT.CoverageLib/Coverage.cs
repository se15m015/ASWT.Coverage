using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWT.CoverageLib
{
    public static class Coverage
    {
        public static int Run(int a, int b)
        {
            if (a >= b){
                a += 20;
                if (a == 70 && b == 50) return -1;
                if (a > 100) return 100;
                return a;
            }
            else {
                b += 10;
                if (b > 100) return 100;
                return b;
            }
        }
    }
}
