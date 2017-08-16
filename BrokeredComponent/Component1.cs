using System;
using System.IO;

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
