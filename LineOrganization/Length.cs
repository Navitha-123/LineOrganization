﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOrganization
{
    internal class Length
    {
        public double length(double x1, double x2, double y1, double y2)
        {
            
            double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return Length;
        }
            
        
    }
}

