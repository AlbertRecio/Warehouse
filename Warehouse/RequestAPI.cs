using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Warehouse
{
    public class RequestAPI
    {
        public static String address;
        public static Boolean isSuccess = false;
        public static string errorMSG;
        #region ValidatePath(String raw)
        private static String ValidatePath(String raw)
        {
            if (raw[0].Equals('/'))
                return raw.Remove(0, 1);
            return raw;
        }
        #endregion
        public static async Task<Boolean> InsertAPI<T>(List<T> mT, String path)
        {
            errorMSG = "";
            path = ValidatePath(path);
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(address);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage response = client.PutAsJsonAsync(path, mT).Result;
                    if (response.StatusCode == HttpStatusCode.OK)
                        return true;
                    return false;
                }
            }
            catch (Exception e)
            {
                errorMSG = e.InnerException.Message;
                //MessageBox.Show(e.InnerException.Message, "Error Found!");
                return false;
            }
        }
    }
}
