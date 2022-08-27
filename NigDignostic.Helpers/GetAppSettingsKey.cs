using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignostic.Helpers
{
    public static class GetAppSettingsKey
    {
        public static string GetAppSettingValue(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            if (!string.IsNullOrEmpty(value))
            {
                return value;
            }
            return null;
        }
    }
}
