using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class Employee
    {
        string _empName;
        int _empID;
        public Employee(string name, int num)
        {
            _empName = name;
            _empID = num;
        }
        public string Name
        {
            get
            {
                return _empName;
            }
        }
        public int ID
        {
            get
            {
                return _empID;
            }
        }
    }
    class GenericList<T> where T : Employee
    {
        T[] _name = new T[3];
        int _counter = 0;
        public void Add(T val)
        {
            _name[_counter] = val;
            _counter++;
        }
        public void Display()
        {
            for (int i = 0; i < _counter; i++)
            {
                Console.WriteLine(_name[i].Name + ", " +_name[i].ID);
            }
        }
    }
}

