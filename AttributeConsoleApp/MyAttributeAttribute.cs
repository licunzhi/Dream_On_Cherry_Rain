using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeConsoleApp
{
    // Add some limit
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple =true)]
    public class MyAttributeAttribute : Attribute
    {
        public string Description;
        public string Version;
        public string Reviewer;

        public MyAttributeAttribute(string desc, string ver, string Rev)
        {
            Description = desc;
            this.Version = ver;
            Reviewer = Rev;

            Console.WriteLine(desc + ver + Rev);
        }
    }
}
