using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I interface segregation principle(ISP)

namespace PrinciplesOfCoding
{
    class ISP
    {
        public interface IEmployee
        {
            bool AddEmployeeDetails();
        }
        public interface IEmployeeDatabase
        {
            bool AddEmployeeDetails();
            bool ShowEmployeeDetails(int employeeId);
        }
        public interface IAddOperation
        {
            bool AddEmployeeDetails();
        }
        public interface IGetOperation
        {
            bool ShowEmployeeDetails(int employeeId);
        }
    }
}
