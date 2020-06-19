using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class SwapNumbers
    {
        public static void Swap<T>(ref T valOne, ref T valTwo)
        {
            T temp = valOne;
            valOne = valTwo;
            valTwo = temp;
        }
    }
}
