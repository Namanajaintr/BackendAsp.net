﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//L Liskov substitution principle (LSP)

namespace PrinciplesOfCoding
{
    class LSP
    {
        public abstract class Employee
        {
            public virtual string GetProjectDetails(int employeeId) {
                return "Base Project";
            }
            public virtual string GetEmployeeDetails(int employeeId) {
                return "Base Employee";
            }
        }
        public class CasualEmployee : Employee
        {
            public override string GetProjectDetails(int employeeId) {
                return "Child Project";
            }
            // May be for contractual employee we do not need to store the details into database.
            public override string GetEmployeeDetails(int employeeId) {
                return "Child Employee";
            }
        }
        public class ContractualEmployee : Employee
        {
            public override string GetProjectDetails(int employeeId) {
                return "Child Project";
            }
            // May be for contractual employee we do not need to store the details into database.
            public override string GetEmployeeDetails(int employeeId) {
                throw new NotImplementedException();
            }
        }
    }
}