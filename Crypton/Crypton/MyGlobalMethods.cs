using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypton
{
    public class MyGlobalMethods
    {
        public MyGlobalMethods() 
        {}

        public static string GetBaseDir() 
        {
            // Get Base dir for app
            //============================================= 
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            return System.IO.Path.GetDirectoryName(a.Location);
        }
    }
}
