using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    public class TestDetailsList
    {
        public string Field_name { get; set; }
        public string Test_time { get; set; }
        public string Test_result { get; set; }
        public string Min_range { get; set; }
        public string Max_range { get; set; }
        public string Units { get; set; }
        public string Machine_shortname { get; set; }

    }
}
