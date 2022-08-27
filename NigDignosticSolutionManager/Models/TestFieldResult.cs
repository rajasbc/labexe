using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    public class TestFieldResult
    {
        public string TestResult { get; set; }
        public string TestTime { get; set; }
        public string Result { get; set; }
        public string FieldName { get; set; }
        public string MinRange { get; set; }
        public string MaxRange { get; set; }
        public string Units { get; set; }
        public string TestFieldName { get; set; }
        public string PatientId { get; set; }
        public string Test_id { get; set; }
    }
}
