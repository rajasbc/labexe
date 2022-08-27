using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{

    public class JsonRoots
    {
        public string ID { get; set; }
        public string DATE { get; set; }
        public string WBC { get; set; }
        public string LYM { get; set; }
        public string MIX { get; set; }
        public string NEU { get; set; }
        public string ALYM { get; set; }
        public string AMIX { get; set; }
        public string ANEU { get; set; }
        public string RBC { get; set; }
        public string HGB { get; set; }
        public string HCT { get; set; }
        public string MCV { get; set; }
        public string MCH { get; set; }
        public string MCHC { get; set; }
        public string RDW { get; set; }
        public string PLT { get; set; }
        public string MPV { get; set; }
        public string PDW { get; set; }
    }
    public class TestDetail
    {
        public string Test_name { get; set; }
        public string Test_result { get; set; }
    }

    public class RootTest
    {
        public string Sample_id { get; set; }
        public string Sample_date { get; set; }
        public List<TestDetail> Test_details { get; set; }
    }
    public class RootObjects
    {
        public List<JsonRoots> MainObjects { get; set; }
    }

}
