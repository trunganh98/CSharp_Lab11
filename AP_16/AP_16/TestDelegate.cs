using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_16
{
    delegate int NumberChanger(int n);
    namespace DelegateApp1 
    { 

        class TestDelegate
        {
            public static int num = 10;

            public static int AddNum(int p)
            {
                num += p;
                return num;
            }

            public static int MultNum(int q)
            {
                num *= q;
                return num;
            }

            public static int getNum()
            {
                return num;
            }

        }
    }
}
