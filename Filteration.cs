using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDelegater
{
    internal class Filteration
    {
        public delegate bool FilterAcordaing(Employee e);

        public void CheckValid(Employee[] emp, string title, FilterAcordaing filter)
        {
            Console.WriteLine(title);
            foreach (Employee e in emp) 
            {
                if (filter(e))
                {
                    Console.WriteLine($"Employee Name: {e.Name}, Age : {e.Age}, Salary : {e.Salary}, Total Salary : {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
