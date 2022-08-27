using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignostic.Helpers
{
    public static class APIConstants
    {
        public static string Login = "auth/login";
        public static string PatientByBillId = "auth/patientbybillid";
        public static string PatientList = "auth/patientlist";
        public static string TestFieldList = "auth/filed_list";
        public static string TestDetails = "auth/testdetails";
        public static string ReportCreate = "auth/report";
        public static string TestDetailsBySampleId = "auth/testdetailsbysample";
        public static string Logout = "logout";
    }
}
