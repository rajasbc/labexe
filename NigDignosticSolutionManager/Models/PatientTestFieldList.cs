using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    class PatientTestFieldList
    {
        public int Id { get; set; }
        public int Lab_id { get; set; }
        public int Test_id { get; set; }
        public string Test_short_name { get; set; }
        public string Test_full_name { get; set; }
        public int Field_id { get; set; }
        public string Field_name { get; set; }
        public int Department_id { get; set; }
        public int Group_id { get; set; }
        public int Branch_id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Units { get; set; }
        public string Default_range { get; set; }
        public string Min_range { get; set; }
        public string Max_range { get; set; }
        public string IsAgeSpecific { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Content_freeze { get; set; }
        public string Status { get; set; }
        public int Created_by { get; set; }
        public int? Updated_by { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public int Input_type { get; set; }
        public int Value_input_type { get; set; }
        public object Six_header_title1 { get; set; }
        public object Six_header_title2 { get; set; }
        public object Six_header_title3 { get; set; }
        public object Six_header_title4 { get; set; }
        public object Six_header_title5 { get; set; }
        public object Six_header_title6 { get; set; }
        public string Formula { get; set; }
        public string Optional { get; set; }
        public int IsActive { get; set; }
        public string Work_list { get; set; }
        public DateTime TestDate { get; set; }
        public double TestResult { get; set; }
        public string TestUnit { get; set; }

       

        internal object OrderByDescending(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
