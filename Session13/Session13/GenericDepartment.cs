using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class GenericDepartment<T>
    {
        T[] item;
        public GenericDepartment(T[] val)
        {
            item = val;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T value in item)
            {
                yield return value;
            }
        }
    }
}
