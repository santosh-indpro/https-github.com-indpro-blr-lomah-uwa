using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Foundation;

namespace BrokeredComponent
{
    public sealed class Component1
    {
        public Component1()
        {
            FileStream fs = null;
            if (!File.Exists(@"C:\\Lomha\az.txt"))
            {
                using (fs = File.Create(@"C:\\Lomha\az.txt"))
                {

                }
            }
        }
    }
}
