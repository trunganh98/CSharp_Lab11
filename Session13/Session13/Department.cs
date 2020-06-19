using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class Department : IEnumerable
    {
        string[] departmentNames = {"Marketing", "Finance", "Information Technology", "Human Resources"};
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < departmentNames.Length; i++)
            {
                yield return departmentNames[i];
            }
        }
    }
}
