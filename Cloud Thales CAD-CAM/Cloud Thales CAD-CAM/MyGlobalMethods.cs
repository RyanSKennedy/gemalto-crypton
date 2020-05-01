using System;
using System.Linq;
using System.Net.Http;
using Aladdin.HASP;

namespace Cloud_Thales_CAD_CAM
{
    public class MyGlobalMethods
    {
        public static HttpClient httpClient;

        public MyGlobalMethods() 
        {}

        public static string GetBaseDir() 
        {
            // Get Base dir for app
            //============================================= 
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            return System.IO.Path.GetDirectoryName(a.Location);
        }

        public static string GetSessionInfo(string format)
        {
            string info = null;
            if (Variables.myStatus == HaspStatus.StatusOk)
            {
                Variables.myStatus = Variables.myHasp.GetSessionInfo(format, ref info);
                if (Variables.myStatus == HaspStatus.StatusOk)
                {
                    return info;
                }
                else
                {
                    return Variables.myStatus.ToString();
                }
            }

            return Variables.myStatus.ToString();
        }

        public static string GetInfo(string scope, string format, bool checkBeforeLogin = false)
        {
            string info = null;
            HaspStatus getStatus = HaspStatus.AlreadyLoggedOut;
            if (Variables.myStatus == HaspStatus.StatusOk && !checkBeforeLogin)
            {
                getStatus = Hasp.GetInfo(scope, format, Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()], ref info);
                if (getStatus == HaspStatus.StatusOk)
                {
                    return info;
                }
                else
                {
                    return getStatus.ToString();
                }
            }
            else if (checkBeforeLogin)
            {
                getStatus = Hasp.GetInfo(scope, format, Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()], ref info);
                if (getStatus == HaspStatus.StatusOk)
                {
                    return info;
                }
                else
                {
                    return getStatus.ToString();
                }
            }
            return getStatus.ToString();
        }

        public static string CancelDetachViaUrl(string productId, string targetKeyId = "")
        {
            if (String.IsNullOrEmpty(targetKeyId))
            {
                targetKeyId = FormMain.parentKeyId;
            }

            httpClient = new HttpClient();
            Uri fullUri = new Uri(Variables.urlForCancelDetachLicense.Replace("{HOST}", Variables.accHost).Replace("{PORT}", Variables.accPortStr).Replace("{KEY_ID}", targetKeyId).Replace("{VENDOR_ID}", Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault().Value).Replace("{PRODUCT_ID}", productId));
            HttpResponseMessage httpClientResponse = httpClient.GetAsync(fullUri).Result;

            return httpClientResponse.StatusCode.ToString();
        }

        public static string CancelDetachViaLicensingApi(string parentKeyId)
        {
            var myId = GetInfo(Variables.scopeForLocal, Variables.formatForGetId);

            string info = null;

            HaspStatus myCancelDetachStatus = Hasp.Transfer(Variables.actionForCancelDetach.Replace("{KEY_ID}", parentKeyId), Variables.scopeForSpecificKeyId.Replace("{KEY_ID}", parentKeyId), Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()], myId, ref info);

            return myCancelDetachStatus.ToString();
        }
    }
}
