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
            int result = 0;
            if (a >= b){
                a += 20;
                if (a == 52) result = 100;
                else result = a > 100 ? 100 : a;
            }else{
                b += 10;
                if (b == 29) result = 100;
                 else result = b > 100 ? 100 : b;
            }
            return result;
        }
    }
}
