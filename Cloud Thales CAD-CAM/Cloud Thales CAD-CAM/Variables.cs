﻿using System;
using System.Collections.Generic;
using Aladdin.HASP;

namespace Cloud_Thales_CAD_CAM
{
    public class Variables
    {
        public static Dictionary<KeyValuePair<string,string>, string> vendorCode = new Dictionary<KeyValuePair<string, string>, string>() {
            { new KeyValuePair<string, string> ("DEMOMA", "37515"), "AzIceaqfA1hX5wS+M8cGnYh5ceevUnOZIzJBbXFD6dgf3tBkb9cvUF/Tkd/iKu2fsg9wAysYKw7RMAsV" +
                        "vIp4KcXle/v1RaXrLVnNBJ2H2DmrbUMOZbQUFXe698qmJsqNpLXRA367xpZ54i8kC5DTXwDhfxWTOZrB" +
                        "rh5sRKHcoVLumztIQjgWh37AzmSd1bLOfUGI0xjAL9zJWO3fRaeB0NS2KlmoKaVT5Y04zZEc06waU2r6" +
                        "AU2Dc4uipJqJmObqKM+tfNKAS0rZr5IudRiC7pUwnmtaHRe5fgSI8M7yvypvm+13Wm4Gwd4VnYiZvSxf" +
                        "8ImN3ZOG9wEzfyMIlH2+rKPUVHI+igsqla0Wd9m7ZUR9vFotj1uYV0OzG7hX0+huN2E/IdgLDjbiapj1" +
                        "e2fKHrMmGFaIvI6xzzJIQJF9GiRZ7+0jNFLKSyzX/K3JAyFrIPObfwM+y+zAgE1sWcZ1YnuBhICyRHBh" +
                        "aJDKIZL8MywrEfB2yF+R3k9wFG1oN48gSLyfrfEKuB/qgNp+BeTruWUk0AwRE9XVMUuRbjpxa4YA67SK" +
                        "unFEgFGgUfHBeHJTivvUl0u4Dki1UKAT973P+nXy2O0u239If/kRpNUVhMg8kpk7s8i6Arp7l/705/bL" +
                        "Cx4kN5hHHSXIqkiG9tHdeNV8VYo5+72hgaCx3/uVoVLmtvxbOIvo120uTJbuLVTvT8KtsOlb3DxwUrwL" +
                        "zaEMoAQAFk6Q9bNipHxfkRQER4kR7IYTMzSoW5mxh3H9O8Ge5BqVeYMEW36q9wnOYfxOLNw6yQMf8f9s" +
                        "JN4KhZty02xm707S7VEfJJ1KNq7b5pP/3RjE0IKtB2gE6vAPRvRLzEohu0m7q1aUp8wAvSiqjZy7FLaT" +
                        "tLEApXYvLvz6PEJdj4TegCZugj7c8bIOEqLXmloZ6EgVnjQ7/ttys7VFITB3mazzFiyQuKf4J6+b/a/Y" }
        };

        public static string currentBatchCode = Properties.Settings.Default.CurrentBatchCode;
        public static HaspStatus myStatus = HaspStatus.AlreadyLoggedOut;
        public static HaspFeature myFeature = new HaspFeature(Properties.Settings.Default.FID);
        public static Hasp myHasp = new Hasp(myFeature);

        public static string specifyKeyId = null;
        public static bool connectToSpecifyKeyId = false;

        public static string regExForValidatingNewBatchCode = @"[A-Z]{5,6}-[0-9]{5,6}:.{200,}";
        public static string formatForInputToolTip = @"*YourBatchCode*-*YourVendorId*:*YourVendorCode*";

        public static string urlForCancelDetachLicense = @"http://{HOST}:{PORT}/_int_/cancel2.html?haspid={KEY_ID}&vendorid={VENDOR_ID}&productid={PRODUCT_ID}";
        public static string accHost = "127.0.0.1";
        public static string accPortStr = "1947";
        public static ushort accPort = Convert.ToUInt16(accPortStr);
        public static bool useUrl = true;

        public static string baseDir = MyGlobalMethods.GetBaseDir();
        
        public static string formatForGetAvailableLicenses = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                                                             "<haspformat root=\"hasp_info\">" +
                                                             "    <hasp>" +
                                                             "        <attribute name=\"id\" />" +
                                                             "        <attribute name=\"type\" />" +
                                                             "        <feature>" +
                                                             "            <attribute name=\"id\" />" +
                                                             "        </feature>" +
                                                             "    </hasp>" +
                                                             "</haspformat>";

        public static string formatForGetId = "<haspformat root=\"location\">" +
                                              "   <license_manager>" +
                                              "      <attribute name=\"id\"/>" +
                                              "      <attribute name=\"time\"/>" +
                                              "      <element name=\"hostname\"/>" +
                                              "      <element name=\"version\"/>" +
                                              "      <element name=\"host_fingerprint\"/>" +
                                              "   </license_manager>" +
                                              "</haspformat>";

        public static string formatForGetProductId = "<haspformat>" +
                                                     "    <product>" +
                                                     "        <element name=\"id\"/>" +
                                                     "        <element name=\"name\"/>" +
                                                     "    </product>" + 
                                                     "</haspformat>";

        public static string formatForGetFeatureId = "<haspformat root=\"hasp_info\">" +
                                                     "    <feature>" +
                                                     "       <element name=\"id\" />" +
                                                     "       <element name=\"name\" />" +
                                                     "       <attribute name=\"locked\" />" +
                                                     "       <attribute name=\"expired\" />" +
                                                     "       <attribute name=\"disabled\" />" +
                                                     "       <attribute name=\"usable\" />" +
                                                     "    </feature>" +
                                                     "</haspformat>";

        public static string scopeForLocal = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                                             "<haspscope>" +
                                             "    <license_manager hostname=\"localhost\" />" +
                                             "</haspscope>";

        public static string scopeUnfiltered = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" + 
                                               "<haspscope/>";

        public static string actionForDetach = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                               "<detach>" +
                                               "   <product id=\"{PRODUCT_ID}\">" +
                                               "      <duration>{NUMBER_OF_SECONDS}</duration>" +
                                               "   </product>" + 
                                               "</detach>";

        public static string actionForCancelDetach = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                                     "<cancel>" +
                                                     "   <hasp id=\"{KEY_ID}\"/>" + 
                                                     "</cancel>";

        public static string scopeForSpecificKeyId = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                                                     "<haspscope>" +
                                                     "    <hasp id=\"{KEY_ID}\"/>" +
                                                     "</haspscope>";

        public static string templateBatch = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                                             "<vendorsData>" +
                                             "  <vendor>" +
                                             "      <batchCode>{BATCH_CODE}</batchCode>" +
                                             "      <vendorId>{VENDOR_ID}</vendorId>" +
                                             "      <vendorCode>{VENDOR_CODE}</vendorCode>" +
                                             "  </vendor>" +
                                             "</vendorsData>";

        public Variables () {}
    }
}
