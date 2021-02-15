using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVSIQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1, Name="Mauro" },
                new Employee(){Id=2, Name="Kenan" },
                new Employee(){Id=3, Name="Jozef" },
                new Employee(){Id=4, Name="Jean" },
            };

            //IEnumerable<Employee> query = from emp in employees
            //                              where emp.Id == 3
            //                              select emp;

            IQueryable<Employee> query = employees.AsQueryable().Where(n => n.Id == 3);

            foreach (var item in query)
            {
                Console.WriteLine(item.Id+ " " + item.Name);
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}
