using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCore_Empty.Modal;

namespace Asp.NetCore_Empty.Modal
{
    public class MockEmployee : IEmployee
    {
        private List<Employee> mockemployees = new List<Employee>();

        public MockEmployee() {
            mockemployees.Add(new Employee() { ID = 1, Name = "Avi", Age = 22, Address = "Bang" });
            mockemployees.Add(new Employee() { ID = 2, Name = "Akshu", Age = 25, Address = "Tmk" });
            mockemployees.Add(new Employee() { ID = 3, Name = "Namu", Age = 12, Address = "Davan" });
            mockemployees.Add( new Employee() { ID = 4, Name = "Raki", Age = 56, Address = "Mang" });
        }
        Employee IEmployee.getEmpDetails(int id) {
            return this.mockemployees.FirstOrDefault(e=>e.ID == id);

        }

       
    }
}
