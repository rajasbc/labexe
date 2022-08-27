using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NigDignostic.Helpers
{
    public static class APIHelper
    {
        public static async Task<HttpResponseMessage> LoginAsync(string baseAddress,string path,FormUrlEncodedContent requestBody)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //Post Method  
                    HttpResponseMessage response = await client.PostAsync(path, requestBody);
                    return response;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<HttpResponseMessage> PostMethodAsync(string baseAddress, string path, FormUrlEncodedContent requestBody, string token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    //Post Method  
                    HttpResponseMessage response = await client.PostAsync(path, requestBody);
                    return response;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<HttpResponseMessage> PostMethodAsync(string baseAddress, string path, StringContent requestBody, string token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(GetAppSettingsKey.GetAppSettingValue("ApiBaseAddress"));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    //Post Method  
                    HttpResponseMessage response = await client.PostAsync(path, requestBody);
                    return response;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<HttpResponseMessage> GetMethodAsync(string baseAddress, string path,string token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(GetAppSettingsKey.GetAppSettingValue("ApiBaseAddress"));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    //Get Method  
                    HttpResponseMessage response = await client.GetAsync(path);
                    return response;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
