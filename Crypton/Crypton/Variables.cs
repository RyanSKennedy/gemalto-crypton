using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aladdin.HASP;

namespace Crypton
{
    public class Variables
    {
        public static Dictionary<string, string> vendorCode = new Dictionary<string, string>() {
            { "DEMOMA", "AzIceaqfA1hX5wS+M8cGnYh5ceevUnOZIzJBbXFD6dgf3tBkb9cvUF/Tkd/iKu2fsg9wAysYKw7RMAsV" +
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
                        "tLEApXYvLvz6PEJdj4TegCZugj7c8bIOEqLXmloZ6EgVnjQ7/ttys7VFITB3mazzFiyQuKf4J6+b/a/Y" },

            { "YOUR_BATCH_CODE", "XXX_INPUT_YOUR_VENDOR_CODE_HERE_XXX" }
        };
        public static HaspStatus myStatus = HaspStatus.AlreadyLoggedOut;
        public static HaspFeature myFeature = new HaspFeature(10001);
        public static Hasp myHasp = new Hasp(myFeature);
        
        public static string baseDir = MyGlobalMethods.GetBaseDir();
        
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
                                                     "        <attribute name=\"name\"/>" +
                                                     "    </product>" + 
                                                     "</haspformat>";
        public static string scopeForLocal = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                                             "<haspscope>" +
                                             "    <license_manager hostname=\"localhost\" />" +
                                             "</haspscope>";
        public static string actionForDetach = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                               "<detach>" +
                                               "   <product id=\"{PRODUCT_ID}\">" +
                                               "      <duration>{NUMBER_OF_SECONDS}</duration>" +
                                               "   </product>" + 
                                               "</detach>";
        public static string scopeForSpecificKeyId = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                                                     "<haspscope>" +
                                                     "    <hasp id=\"{KEY_ID}\"/>" +
                                                     "</haspscope>";

        public Variables () {}
    }
}
