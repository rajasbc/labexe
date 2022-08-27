using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    public class MachineReports
    {
        public class MachineReport
        {
            public string TestTime { get; set; }
            public string Barcode { get; set; }
        }
        public class SampleBarcodeMachine
        {
            public string PatientName { get; set; }
            public string Barcode { get; set; }
        }
    }
}
