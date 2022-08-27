using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    public class LabProfile
    {
        public int Id { get; set; }
        public int Sid { get; set; }
        public int Uid { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Mobile_no { get; set; }
        public string Landline_no { get; set; }
        public string Register_id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string Branch { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Lab_type { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Patient_photo_need { get; set; }
        public string Barcode { get; set; }
        public string Plan { get; set; }
        public string Expired_date { get; set; }
        public string Bill_begins { get; set; }
        public string Default_payment_mode { get; set; }
        public string Reg_type { get; set; }
        public string Page_border { get; set; }
        public string Field_border { get; set; }
        public int Font_size { get; set; }
        public int Cell_padding { get; set; }
        public string Prefix_need { get; set; }
        public string Prefix { get; set; }
        public string Reason { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public object Whatsapp_link { get; set; }
        public object Whatsapp_token { get; set; }
        public string Page_no { get; set; }
        public string Outside_report { get; set; }
        public string Cutoff_page { get; set; }
        public int Weight_need { get; set; }
        public int Height_need { get; set; }
        public int Bp_need { get; set; }
        public int Specimen { get; set; }
        public int ReportColumnCount { get; set; }
        public string RangeDisplayText { get; set; }
        public double Points { get; set; }
        public int Patient_id_from { get; set; }
        public string Outside_lab { get; set; }
        public string Font_style { get; set; }
        public string Reference_need { get; set; }
        public string Plno_need { get; set; }
        public string Appointment { get; set; }
        public string Consolidate_approve { get; set; }
        public string Admin_sign { get; set; }
        public string Doctor_sign { get; set; }
    }

    public class Root
    {
        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public LabProfile Lab_profile { get; set; }
        public int Expires_in { get; set; }
    }
}
