using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOrganization
{
    internal class EqualsLength
    {
      
        public static void IsEquals(double line1length, double line2length)
        {
            if (line1length.Equals(line2length))
                Console.WriteLine("Both lines are in equal lines");
            else
                Console.WriteLine("Both lines are not in same line");

        }
    }
}

