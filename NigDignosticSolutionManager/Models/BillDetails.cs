using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    //class BillDetails
    //{        
    //        public int lab_id { get; set; }
    //        public int patient_id { get; set; }
    //        public int branch_id { get; set; }
    //        public int patient_no { get; set; }
    //        public string manual_id { get; set; }
    //        public string title { get; set; }
    //        public string name { get; set; }
    //        public string last_name { get; set; }
    //        public string mobile_no { get; set; }
    //        public string alternate_mobile_no { get; set; }
    //        public string email_id { get; set; }
    //        public string dob { get; set; }
    //        public string age { get; set; }
    //        public string gender { get; set; }
    //        public int refered_by { get; set; }
    //        public string area { get; set; }
    //        public string city { get; set; }
    //        public string pincode { get; set; }
    //        public string patient_come { get; set; }
    //        public int created_by { get; set; }
    //        public DateTime created_at { get; set; }
    //        public string status { get; set; }
    //        public object profile_image { get; set; }
    //        public int height { get; set; }
    //        public int weight { get; set; }
    //        public string bp { get; set; }
    //        public string specimen { get; set; }
    //        public int points { get; set; }
    //        public string passport_no { get; set; }
    //        public object otp { get; set; }
    //        public int referral_hospital { get; set; }
    //        public int outside_lab { get; set; }
    //        public int rewardamount { get; set; }
    //        public string labnumber { get; set; }
    //        public DateTime updated_at { get; set; }
    //        public string adhar_no { get; set; }
    //        public string blood_group { get; set; }
    //        public string allergies { get; set; }
    //        public string injuries { get; set; }
    //        public string smoking_habits { get; set; }
    //        public string alcohol_consumption { get; set; }        
    //}
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    //public class PatientDetail
    //{
    //    public int lab_id { get; set; }
    //    public int patient_id { get; set; }
    //    public int branch_id { get; set; }
    //    public int patient_no { get; set; }
    //    public string manual_id { get; set; }
    //    public string title { get; set; }
    //    public string name { get; set; }
    //    public object local_name { get; set; }
    //    public string last_name { get; set; }
    //    public string mobile_no { get; set; }
    //    public string alternate_mobile_no { get; set; }
    //    public string email_id { get; set; }
    //    public string dob { get; set; }
    //    public string age { get; set; }
    //    public object age_type { get; set; }
    //    public string gender { get; set; }
    //    public int refered_by { get; set; }
    //    public string area { get; set; }
    //    public string city { get; set; }
    //    public string pincode { get; set; }
    //    public string patient_come { get; set; }
    //    public int created_by { get; set; }
    //    public DateTime created_at { get; set; }
    //    public string status { get; set; }
    //    public object profile_image { get; set; }
    //    public int height { get; set; }
    //    public int weight { get; set; }
    //    public string bp { get; set; }
    //    public string specimen { get; set; }
    //    public int points { get; set; }
    //    public string passport_no { get; set; }
    //    public object otp { get; set; }
    //    public int referral_hospital { get; set; }
    //    public int outside_lab { get; set; }
    //    public int rewardamount { get; set; }
    //    public string labnumber { get; set; }
    //    public DateTime updated_at { get; set; }
    //    public string adhar_no { get; set; }
    //    public object sid_no { get; set; }
    //    public string blood_group { get; set; }
    //    public string allergies { get; set; }
    //    public string injuries { get; set; }
    //    public string smoking_habits { get; set; }
    //    public string alcohol_consumption { get; set; }
    //    public object patient_nick_name { get; set; }
    //    public object nationality { get; set; }
    //    public object icmr_id { get; set; }
    //    public object icmr_approve_no { get; set; }
    //    public int isActive { get; set; }
    //}

    //public class Testdetail
    //{
    //    public int bill_id { get; set; }
    //    public int test_id { get; set; }
    //    public string test_name { get; set; }
    //    public int department { get; set; }
    //    public int group_id { get; set; }
    //}

    //public class BillDetails
    //{
    //    public List<PatientDetail> patient_details { get; set; }
    //    public List<Testdetail> testdetails { get; set; }
    //}
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class PatientDetail
    {
        public int Lab_id { get; set; }
        public int Patient_id { get; set; }
        public int Branch_id { get; set; }
        public int Patient_no { get; set; }
        public object Manual_id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Parentname { get; set; }
        public object Local_name { get; set; }
        public object Last_name { get; set; }
        public string Mobile_no { get; set; }
        public object Alternate_mobile_no { get; set; }
        public object Email_id { get; set; }
        public string Dob { get; set; }
        public string Age { get; set; }
        public object Age_type { get; set; }
        public string Gender { get; set; }
        public int Refered_by { get; set; }
        public object Area { get; set; }
        public object City { get; set; }
        public object Pincode { get; set; }
        public object Patient_come { get; set; }
        public object Created_by { get; set; }
        public DateTime Created_at { get; set; }
        public object Status { get; set; }
        public object Profile_image { get; set; }
        public object Height { get; set; }
        public object Weight { get; set; }
        public object Bp { get; set; }
        public object Specimen { get; set; }
        public int Points { get; set; }
        public object Passport_no { get; set; }
        public object Otp { get; set; }
        public int Referral_hospital { get; set; }
        public int Outside_lab { get; set; }
        public int Rewardamount { get; set; }
        public object Labnumber { get; set; }
        public DateTime Updated_at { get; set; }
        public object Adhar_no { get; set; }
        public object Sid_no { get; set; }
        public string Blood_group { get; set; }
        public string Allergies { get; set; }
        public string Injuries { get; set; }
        public string Smoking_habits { get; set; }
        public string Alcohol_consumption { get; set; }
        public object Patient_nick_name { get; set; }
        public object Nationality { get; set; }
        public string Opd_ipd_type { get; set; }
        public object Icmr_id { get; set; }
        public object Icmr_approve_no { get; set; }
        public int IsActive { get; set; }
        public string Cidnumber { get; set; }
        public string Sample_collector { get; set; }
        public string Report_received_by { get; set; }
    }

    public class Testdetail
    {
        public int Bill_id { get; set; }
        public int Test_id { get; set; }
        public string Test_name { get; set; }
        public int Department { get; set; }
        public int Group_id { get; set; }
    }

    public class RootOne
    {
        public List<PatientDetail> Patient_details { get; set; }
        public List<Testdetail> Testdetails { get; set; }
    }




}
