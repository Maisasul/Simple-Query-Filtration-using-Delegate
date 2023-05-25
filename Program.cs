namespace EmployeeDelegater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[]
            { 
                new Employee{Name = "Maisa", Age = 25, Salary = 16455, TotalSales = 23800},
                new Employee{Name = "Sara", Age = 26, Salary = 17455, TotalSales = 5800},
                new Employee{Name = "Amal", Age = 23, Salary = 7455, TotalSales = 232800},
                new Employee{Name = "Fatma", Age = 39, Salary = 16455, TotalSales = 23800},
                new Employee{Name = "Arwa", Age = 29, Salary = 4675, TotalSales = 98800}
            };
            Filteration filteration = new Filteration();
            Console.ForegroundColor = ConsoleColor.Red;
            filteration.CheckValid(employee, "---Filter Employee by Salary grater than 15000---", (employee) => employee.Salary > 15000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            filteration.CheckValid(employee, "---Filter Employee by Age grater than 25---", (employee) => employee.Age > 25);
            Console.ForegroundColor = ConsoleColor.Blue;
            filteration.CheckValid(employee, "---Filter Employee by Total Sales grater than 40000---", (employee) => employee.TotalSales > 40000);
            Console.ResetColor();
        }
    }
}