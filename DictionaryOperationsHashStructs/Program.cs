using System;
using System.Collections.Generic;

namespace DictionaryOperationsHashStructs
{
    public class Employee
    {
        string name;
        int id;
        string dept;

        public Employee(string name, int id, string dept)
        {
            this.name = name;
            this.id = id;
            this.dept = dept;
        }
        static void Main(string[] args)
        {
            
            Employee employee = new Employee("Robby", 3827, "Technology");
            Employee employee2 = new Employee("Bobby", 9415, "Marketing");
            Employee employee3 = new Employee("Sally", 2519, "Sales");

            //<key, keyValue>
            Dictionary<int, Employee> empId = new Dictionary<int, Employee>();
            empId.Add(employee.id, employee);
            empId.Add(employee2.id, employee2);
            empId.Add(employee3.id, employee3);

            if(empId.TryGetValue(9415, out Employee e))
            {
                Console.WriteLine($"Name: {e.name}\nDept: {e.dept}\nID: {e.id}");
            }

            //EX: group of item codes that can be purchased using corporate card
            HashSet<string> prodCode = new HashSet<string>();
            prodCode.Add("8F26B");
            prodCode.Add("0A43P");
            prodCode.Add("8F26B");

            //CHECKING FOR CODES
            if (prodCode.Contains("39AHJF"))
            {
                Console.WriteLine("Authorized");
            }
            else { Console.WriteLine("Not Authorized"); }
            if (prodCode.Contains("0A43P"))
            {
                Console.WriteLine("Authorized");
            }
            else { Console.WriteLine("Not Authorized"); }
            if (prodCode.Contains("0A43p")) //CASE SENSITIVE --> returns false
            {
                Console.WriteLine("Authorized");
            }
            else { Console.WriteLine("Not Authorized"); }
            
            

        }
        static void EmpDetails()
        {
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Department:");
            string dept = Console.ReadLine();
        }

    }

    
}

/* NOTES:
 * no hash tables in C3 --> Dictionaries
 * 
 * hash-based structures are great when working with collections, sets, and data formatted as key-value pairs.
 * 
 * HashSet is an unorderd collection of unique items
 *      no duplicates, order is not relevant --> for unique items
 *      
 * Dictionary is useful for key-value pairs --> Type Safety and ordered
 *      --> thread safe only for public static memebers
 *      EX: store employee names (value) by id (key)
 *      
 *Hastable --> no type safe
 *  --> is thread safe
 *  
 *  VOCAB:
 *      Thread Safe: routine that can be called from multiple threads w/o unwanted interaction between threads
 *      
 */