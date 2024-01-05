using System;
using System.Threading;

namespace Jan5Thread
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Employee e = new Employee() { Eid = 101, Ename = "John" };
            Thread t1 = new Thread(e.Fun1); // non-static function
            t1.Start(e); // Pass the object as a parameter
        }

        class Employee
        {
            public int Eid { get; set; }
            public string Ename { get; set; }

            public void Fun1(object obj)
            {
                Employee emp = (Employee)obj; // Cast the object back to Employee
                Console.WriteLine("Employee id is " + emp.Eid);
                Console.WriteLine("Employee name is " + emp.Ename);
            }
        }
    }
}

