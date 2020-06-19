using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class General2<T, U>
    {
        T _valOne;
        U _valTwo;
        public void AcceptValues(T item)
        {
            _valOne = item;
        }
        public void AcceptValues(U item)
        {
            _valTwo = item;
        }
        public void Display()
        {
            Console.Write(_valOne + "\t" +_valTwo);
        }
    }
}

