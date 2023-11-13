using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[6]
         {
            new Employee { Id = 1, EmpName = "John", Salary = 50000, DetId = 101 },
            new Employee { Id = 2, EmpName = "Alice", Salary = 60000, DetId = 102 },
            new Employee { Id = 3, EmpName = "Bob", Salary = 55000, DetId = 101 },
            new Employee { Id = 4, EmpName = "Eva", Salary = 70000, DetId = 103 },
            new Employee { Id = 5, EmpName = "Charlie", Salary = 45000, DetId = 102 },
            new Employee { Id = 6, EmpName = "Grace", Salary = 80000, DetId = 103 }
         };

            // Creating an array of Department objects
            Department[] departments = new Department[3]
            {
            new Department { DetId = 101, DeptName = "ADV" },
            new Department { DetId = 102, DeptName = "HR" },
            new Department { DetId = 103, DeptName = "ADMIN" }
            };

            var query = employees
          .Join(departments, emp => emp.DetId, dept => dept.DetId, (emp, dept) => new { emp.EmpName, dept.DeptName });

            foreach (var result in query)
            {
                Console.WriteLine($"Employee: {result.EmpName}, Department: {result.DeptName}");
            }
        }
    }
}