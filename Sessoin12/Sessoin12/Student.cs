using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessoin12
{
    class Student : IEnumerable
    {
        LinkedList<string> objList = new LinkedList<string>();
        public void StudentDetails()
        {
            objList.AddFirst("James");
            objList.AddFirst("John");
            objList.AddFirst("Patrick");
            objList.AddFirst("Peter");
            objList.AddFirst("James");
            Console.WriteLine("\nNumber of elements stored in the list: " + objList.Count);
        }
        public void Display(string name)
        {
            LinkedListNode<string> objNode;
            int count = 0;
            for (objNode = objList.First; objNode != null; objNode =
            objNode.Next)
            {
                if (objNode.Value.Equals(name))
                {
                    count++;
                }
            }
            Console.WriteLine("The value " +name + " appears " + count + " times in the list");
        }
        public IEnumerator GetEnumerator()
        {
            return objList.GetEnumerator();
        }
    }
}
