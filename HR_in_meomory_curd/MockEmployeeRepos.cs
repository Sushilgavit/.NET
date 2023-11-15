using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_in_meomory_curd
{
    internal class MockEmployeeRepos : IEmployeeRepo
    {
        private static List<Employee_Poco> _empList;

        public MockEmployeeRepos()
        {
            _empList = new List<Employee_Poco>()
            {
                new Employee_Poco() { Id = 1, Name = "Sushil", city = "Kannad", gender = "M", salary = 120000 } ,
                new Employee_Poco() { Id = 2, Name = "Akshay",city ="Kolhapur", gender = "M",  salary = 78000},
            };
        }
        public Employee_Poco Add(Employee_Poco employee)
        {
           employee.Id=_empList.Max(x => x.Id)+1;
            _empList.Add(employee );
            return employee;
        }

        public Employee_Poco Delete(int Id)
        {
          Employee_Poco employee = _empList.FirstOrDefault(employee => employee.Id==Id);
            if(employee !=null)
            {
                _empList.Remove(employee);
            }
            return employee;
        }

        

        public Employee_Poco GetEmployee_Poco(int Id)
        {
            return _empList.FirstOrDefault(emp => emp.Id==Id);
        }


        public IEnumerable<Employee_Poco> GetEmployee_Poco()
        {
            return _empList;
        }

        public Employee_Poco Update(Employee_Poco employeeChanges)
        {
                Employee_Poco employee = _empList.FirstOrDefault(e=> e.Id==employeeChanges.Id);
            if(employee!=null)
            {
                employee.Name = employeeChanges.Name;
                employee.salary = employeeChanges.salary;
                employee.gender= employeeChanges.gender;
                employee.city= employeeChanges.city;
            }
            return employee;
        }
    }
}
