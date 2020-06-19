using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    interface IMaths<T>
    {
        T Addition(T valOne, T valTwo);
        T Subtraction(T valOne, T valTwo);
    }

    class Numbers : IMaths<int>
    {
        public int Addition(int valOne, int valTwo)
        {
            return valOne + valTwo;
        }
        public int Subtraction(int valOne, int valTwo)
        {
            if (valOne > valTwo)
            {
                return (valOne - valTwo);
            }
            else
            {
                return (valTwo - valOne);
            }
        }
    }
}
