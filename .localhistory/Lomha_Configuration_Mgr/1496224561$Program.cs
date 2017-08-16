using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lomha_Configuration_Mgr
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            if (!File.Exists(@"C:\\Lomha\Test.txt"))
            {
                using (fs = File.Create(@"C:\\Lomha\Test.txt"))
                {

                }
            }
        }
    }
}
