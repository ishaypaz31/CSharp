using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded__41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Threads Time Elapsed
            Set100Items S = new Set100Items();
            S.Threads();

            // Multiplication Calculation
            MultiPlan m = new MultiPlan();
            m.MathPlan();
        }
    }
}