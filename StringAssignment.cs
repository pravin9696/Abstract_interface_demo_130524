using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface_demo_130524
{
   abstract class StringValue
    {
        String value;
      public void setValue(string ch)
        {
            value = ch;
        }
        public string getValue()
        {
            return value;
        }
        abstract public void findSubString();
    }
    class FindSubStringClass:StringValue
    {
        public override void findSubString()
        {
            Console.WriteLine("Write logic for sub string find  "+getValue());
        }
    }
    internal class StringAssignment
    {
    }
}
