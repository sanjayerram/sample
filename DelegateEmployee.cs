using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracice
{
    public class DelegateEmployee
    {
        public void Main()
        {
            //List<Employee> employeelist = new List<Employee>();
            //employeelist.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            //employeelist.Add(new Employee() { ID = 102, Name = "John", Salary = 4000, Experience = 4 });
            //employeelist.Add(new Employee() { ID = 103, Name = "Mike", Salary = 6000, Experience = 6 });
            //employeelist.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });
            //Employee.PromoteEmployee(employeelist);

            List<Employee> employeelist1 = new List<Employee>
            {
                new Employee(){ID = 101, Name = "Mary", Salary = 5000, Experience = 5},
                new Employee(){ID = 102, Name = "John", Salary = 4000, Experience = 4},
                new Employee(){ID = 103, Name = "Mike", Salary = 6000, Experience = 6},
                new Employee(){ID = 104, Name = "Todd", Salary = 3000, Experience = 3}
            };
            Employee.PromoteEmployee(employeelist1);
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> emplist)
        {
            foreach(Employee emp in emplist)
            {
                if(emp.Salary>=5000)
                {
                    Console.WriteLine(emp.Name + "\t" + "Promoted");
                }
            }
        }

        public static void ShowEmpData(List<Employee> emplist1)
        {
            int eid;
            Console.WriteLine("Enter eid");
            eid =int.Parse( Console.ReadLine());
            foreach (Employee item in emplist1)
            {
                if (eid ==item.ID)
                {
                    Console.WriteLine(item.Name + "\n" + item.Salary + "\n" + item.Experience);
                }
                
            }
        }
    }


}
