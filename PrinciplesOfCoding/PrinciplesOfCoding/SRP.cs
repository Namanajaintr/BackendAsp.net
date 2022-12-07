using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.codeproject.com/Tips/1033646/SOLID-Principle-with-Csharp-Example
//S is single responsibility principle(SRP)

namespace PrinciplesOfCoding
{
    class SRP
    {
        public class Employee
        {
            public int Employee_Id { get; set; }
            public string Employee_Name { get; set; }

           
            public bool InsertIntoEmployeeTable(Employee em) {
                // Insert into employee table.
                return true;
            }
            
            public void GenerateReport(Employee em) {
                // Report generation with employee data using crystal report.
            }
        }
        //public class ReportGeneration
        //{
        //    /// Method to generate report
        //    public void GenerateReport(Employee em) {
        //        // Report reneration with employee data.
        //    }
        //}
    }
}
