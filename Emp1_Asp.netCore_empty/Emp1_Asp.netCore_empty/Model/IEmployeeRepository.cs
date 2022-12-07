using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp1_Asp.netCore_empty.Model
{
    public interface IEmployeeRepository
    {
           public IEnumerable<Employee> GetAllEmployees();
           public Employee Add(Employee employee);

    }
}
