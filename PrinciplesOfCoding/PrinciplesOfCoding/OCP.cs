using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrinciplesOfCoding.SRP;

//O stands for open closed principle (OCP)

namespace PrinciplesOfCoding
{
    public class OCP
    {
        public class ReportGeneration
        {           
            public string ReportType { get; set; }

            /// Method to generate report
            public void GenerateReport(Employee em) {
                if (ReportType == "CRS") {
                    // Report generation with employee data in Crystal Report.
                }
                if (ReportType == "PDF") {
                    // Report generation with employee data in PDF.
                }
            }
        }
        public class IReportGeneration
        {
            public virtual void GenerateReport(Employee em) {
                // From base
            }
        }
        
        /// Class to generate Crystal report
        
        public class CrystalReportGeneraion : IReportGeneration
        {
            public override void GenerateReport(Employee em) {
                // Generate crystal report.
            }
        }
        
        /// Class to generate PDF report
        
        public class PDFReportGeneraion : IReportGeneration
        {
            public override void GenerateReport(Employee em) {
                // Generate PDF report.
            }
        }
      
    }
}
