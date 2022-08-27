using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    public class RecordCreate
    {
        public string bill_id { get; set; }
        public string test_id { get; set; }
        public string patient_id { get; set; }
        public string department_id { get; set; }
        public string group_id { get; set; }
        public List<TestRecord> test_result { get; set; }       
    }

    public class TestResults
    {
        public string Field_id { get; set; }
        public string Test_id { get; set; }
        public string Machine_short_name { get; set; }
        public string Test_name { get; set; }
        public string Test_value { get; set; }        
    }

    public class TestRecord
    {
        public string field_id { get; set; }
       // public string Machine_short_name { get; set; }
       // public string Test_id { get; set; }
        public string test_name { get; set; }
        public string test_value { get; set; }       
    }   

    public class TestRecords
    {
        public List<TestRecord> testRecords { get; set; }        
    }
}
