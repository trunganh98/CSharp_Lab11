using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    delegate T DelMath<T>(T val);

    class Numbers2
    {
        public static int NumberType(int num)
        {
            if (num % 2 == 0)
                return num;
            else
                return (0);
        }
        public static float NumberType(float num)
        {
            return num % 2.5F;
        }
        
    }
}
