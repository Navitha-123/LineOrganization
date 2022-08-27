using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOrganization
{
    internal class CompareLength
    {
       
        public static void CompareTo(double line1length, double line2length)
        {

            if (line1length == line2length)
               {
                Console.WriteLine("Both lines are compare length equal");
                }
            else if (line1length >= line2length)
            {
                Console.WriteLine("line 1 length is greater than line2length");
            }
            else if(line1length <= line2length)
            {
                Console.WriteLine("line1 length is lesser than line2length");
            }
                

        }
    }
}

