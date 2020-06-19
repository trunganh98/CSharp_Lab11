using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class Student2<T> : GeneralList2<T>
    {
        public T Value;
        public Student2(T valOne, T valTwo) : base(valOne)
        {
            Value = valTwo;
        }
        public override T GetValue()
        {
            Console.Write(base.GetValue() + "\t\t");
            return Value;
        }
    }
}
