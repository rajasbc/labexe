using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    class Jsontoclass
    {
        public class Rootobject
        {
            public string Sample_id { get; set; }
            public string Sample_date { get; set; }
            public Test_Details[] Test_details { get; set; }
        }

        public class Test_Details
        {
            public string Test_name { get; set; }
            public string Test_result { get; set; }
        }

    }
}
