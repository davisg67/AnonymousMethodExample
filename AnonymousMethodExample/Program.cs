using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int idValue = 103; //Available to the anonymous method.

            //Get list of employees.
            List<Employee> listEmployees = new List<Employee>();
            listEmployees = GetEmployeeList();

            // An anonymous method is being passed as an argument to
            // the Find() method of List Collection.
            Employee employee = listEmployees.Find(
                                    delegate (Employee x)
                                    {
                                        return x.ID == idValue;
                                    }
                                );
            
            Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            Console.ReadKey();
        }

        //Employee list
        public static List<Employee> GetEmployeeList()
        {
            //Employee Objects
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "John",
                Gender = "Male",
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Jane",
                Gender = "Female",
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Bill",
                Gender = "Male",
                Salary = 30000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Susan",
                Gender = "Female",
                Salary = 40000
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Kevin",
                Gender = "Male",
                Salary = 50000
            };

            //Create a list of employees.
            List<Employee> lstEmployees = new List<Employee>();
            lstEmployees.Add(emp1);
            lstEmployees.Add(emp2);
            lstEmployees.Add(emp3);
            lstEmployees.Add(emp4);
            lstEmployees.Add(emp5);

            return lstEmployees;
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
}
