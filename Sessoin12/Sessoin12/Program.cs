using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessoin12
{
    class Program
    {
        static void Main(string[] args)
        {
            Snippet9();
            Snippet10();
            Snippet11();
            Snippet12();
            Snippet13();
            Snippet14();
            Snippet15();
            Snippet16();
            Snippet17();
            Snippet18();
            Snippet19();
            Console.ReadLine();
        }

        static void Snippet9()
        {
            Employee objEmployee = new Employee();
            objEmployee.Add(102, "John");
            objEmployee.Add(105, "James");
            objEmployee.Add(106, "Peter");
            Console.WriteLine("Original values stored in Dictionary");
            objEmployee.GetDetails();
            objEmployee.OnRemove(106);
            Console.WriteLine("Modified values stored in Dictionary");
            objEmployee.GetDetails();
        }

        static void Snippet10()
        {
            Student objStudent = new Student();
            objStudent.StudentDetails();
            foreach (string str in objStudent)
            {
                Console.WriteLine(str);
            }
            objStudent.Display("James");
        }

        static void Snippet11()
        {
            ArrayList objArray = new ArrayList();
            objArray.Add("John");
            objArray.Add("James");
            objArray.Add("Peter");
            objArray.RemoveAt(2);
            objArray.Insert(2, "Williams");
            Console.WriteLine("Capacity: " +objArray.Capacity);
            Console.WriteLine("Count: " +objArray.Count);
            Console.WriteLine();
            Console.WriteLine("Elements of the ArrayList");
            foreach (string str in objArray)
            {
                Console.WriteLine(str);
            }
        }

        static void Snippet12()
        {
            ArrayList objCustomers = new ArrayList();
            objCustomers.Add("Nicole Anderson");
            objCustomers.Add("Ashley Thomas");
            objCustomers.Add("Garry White");
            Console.WriteLine("Fixed Size: " + objCustomers.IsFixedSize);
            Console.WriteLine("Count: " + objCustomers.Count);
            Console.WriteLine("List of customer: ");
            foreach (string  names in objCustomers)
            {
                Console.WriteLine("{0}", names);
            }
            objCustomers.Sort();
            Console.WriteLine("\nList of customers after sorting: ");
            foreach (string names in objCustomers)
            {
                Console.WriteLine("{0}", names);
            }
            objCustomers.Clear();
            Console.WriteLine("Count after removing all eiements: " + objCustomers.Count);

        }

        static void Snippet13()
        {
            Hashtable objTable = new Hashtable();
            objTable.Add(001, "John");
            objTable.Add(002, "Peter");
            objTable.Add(003, "James");
            objTable.Add(004, "Joe");
            Console.WriteLine("Number of elements in the hash table: " +
            objTable.Count);
            ICollection objCollection = objTable.Keys;
            Console.WriteLine("Original values stored in hashtable are: ");
            foreach (int i in objCollection)
            {
                Console.WriteLine(i + " : " + objTable[i]);
            }
        }

        static void Snippet14()
        {
            Hashtable objAuthors = new Hashtable();
            objAuthors.Add("AU01","John");
            objAuthors.Add("AU04", "Mary");
            objAuthors.Add("AU09", "William");
            objAuthors.Add("AU11", "Rodrick");
            Console.WriteLine("Read - only : " + objAuthors.IsReadOnly);
            Console.WriteLine("Count: " +objAuthors.Count);
            IDictionaryEnumerator objCollection =
            objAuthors.GetEnumerator();
            Console.WriteLine("List of authors:\n");
            Console.WriteLine("Author ID \t Name");
            while (objCollection.MoveNext())
            {
                Console.WriteLine(objCollection.Key + "\t\t " +
                objCollection.Value);
            }
            if (objAuthors.Contains("AU01"))
            {
                Console.WriteLine("\nList contains author with id AU01");
            }
            else
            {
                Console.WriteLine("\nList does not contain author with id AU01");
            }
        }

        static void Snippet15()
        {
            SortedList objSortList = new SortedList();
            objSortList.Add("John", "Administration");
            objSortList.Add("Jack", "Human Resources");
            objSortList.Add("Peter", "Finance");
            objSortList.Add("Joel", "Marketing");
            Console.WriteLine("Original values stored in the sorted list");
            Console.WriteLine("Key \t\t Values");
            for (int i = 0; i < objSortList.Count; i++)
            {
                Console.WriteLine(objSortList.GetKey(i) + " \t\t " + objSortList.GetByIndex(i));
            }
            if (!objSortList.ContainsKey("Jerry"))
            {
                objSortList.Add("Jerry", "Construction");
            }
            objSortList["Peter"] = "Engineering";
            objSortList["Jerry"] = "Information Technology";
            Console.WriteLine();
            Console.WriteLine("Updated values stored in hashtable");
            Console.WriteLine("Key \t\t Values");
            for (int i = 0; i < objSortList.Count; i++)
            {
                Console.WriteLine(objSortList.GetKey(i) + " \t\t " + objSortList.GetByIndex(i));
            }
        }

        static void Snippet16()
        {
            SortedList objCountries = new SortedList();
            objCountries.Add("UK", "United Kingdom");
            objCountries.Add("GER", "Germany");
            objCountries.Add("USA", "United States of America");
            objCountries.Add("AUS", "Australia");
            Console.WriteLine("Read - only : " + objCountries.IsReadOnly);
            Console.WriteLine("Count: " +objCountries.Count);
            Console.WriteLine("List of countries:\n");
            Console.WriteLine("Country Code \t Name");
            for (int i = 0; i < objCountries.Count; i++)
            {
                Console.WriteLine(objCountries.GetKey(i) + "\t\t " +objCountries.GetByIndex(i));
            }
            objCountries.RemoveAt(1);
            Console.WriteLine("\nList of countries after removing element at index 1:\n");
            Console.WriteLine("Country Code \t Name");
            for (int i = 0; i < objCountries.Count; i++)
            {
                Console.WriteLine(objCountries.GetKey(i) + "\t\t " +objCountries.GetByIndex(i));
            }
        }

        static void Snippet17()
        {
            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
            objDictionary.Add(25, "Hard Disk");
            objDictionary.Add(30, "Processor");
            objDictionary.Add(15, "MotherBoard");
            objDictionary.Add(65, "Memory");
            ICollection objCollect = objDictionary.Keys;
            Console.WriteLine("Original values stored in the collection");
            Console.WriteLine("Keys \t Values");
            Console.WriteLine("----------------");
            foreach (int i in objCollect)
            {
                Console.WriteLine(i + " \t " +objDictionary[i]);
            }
            objDictionary.Remove(65);
            Console.WriteLine();
            if (objDictionary.ContainsValue("Memory"))
            {
                Console.WriteLine("Value Memory could not be deleted");
            }
            else
            {
                Console.WriteLine("Value Memory deleted successfully");
            }
            Console.WriteLine();
            Console.WriteLine("Values stored after removing element");
            Console.WriteLine("Keys \t Values");
            Console.WriteLine("----------------");
            foreach (int i in objCollect)
            {
                Console.WriteLine(i + " \t " +objDictionary[i]);
            }
        }

        static void Snippet18()
        {
            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
            objDictionary.Add(201, "Gear Box");
            objDictionary.Add(220, "Oil Filter");
            objDictionary.Add(330, "Engine");
            objDictionary.Add(305, "Radiator");
            objDictionary.Add(303, "Steering");
            Console.WriteLine("Dictionary class contains values of type");
            Console.WriteLine(objDictionary.GetType());
            Console.WriteLine("Keys \t\t Values");
            Console.WriteLine("__________________________");
            IDictionaryEnumerator objDictionayEnumerator = objDictionary.GetEnumerator();
            while (objDictionayEnumerator.MoveNext ())
            {
                Console.WriteLine(objDictionayEnumerator.Key.ToString() + "\t\t"+ objDictionayEnumerator.Value);
            }

        }

        static void Snippet19()
        {
            ArrayList nums = new ArrayList { 1, 2, 3 * 6, 4, 5 };
            foreach (int num in nums)
            {
                Console.WriteLine("{ 0}", num);
            }
        }

    }
}
