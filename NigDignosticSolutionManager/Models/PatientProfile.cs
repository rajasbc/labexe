using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    public class SampleInfo
    {        
        public string Sample_id { get; set; }        
        public string Sample_barcode { get; set; }        
    }

    public class BindingReport
    {
        public double Wbc_count { get; set; }
        public string Lym { get; set; }
        public string Mixed { get; set; }
        public string Neu { get; set; }
        public double ALym { get; set; }
        public double AMixed { get; set; }
        public double ANeu { get; set; }
        public string Rbc_count { get; set; }
        public string Hem { get; set; }
        public string Hct { get; set; }
        public string Mcv { get; set; }
        public string Mch { get; set; }
        public string Mchc { get; set; }
        public string Rdw_cv { get; set; }
        public double Plat_count { get; set; }
        public string Mpv { get; set; }
        public string Pdw { get; set; }
        public string Id { get; set; }
        public string Date { get; set; }
    }
}
