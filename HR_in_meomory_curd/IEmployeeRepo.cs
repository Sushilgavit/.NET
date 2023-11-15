using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_in_meomory_curd
{
    public interface IEmployeeRepo
    {
        Employee_Poco GetEmployee_Poco(int Id);
        IEnumerable<Employee_Poco> GetEmployee_Poco();
        Employee_Poco Add(Employee_Poco employee);

        Employee_Poco Update(Employee_Poco employeeChanges);
        Employee_Poco Delete(int Id);
    }
}
