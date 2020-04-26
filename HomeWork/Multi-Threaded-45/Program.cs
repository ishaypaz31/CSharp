using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_45
{
    class Program
    {

        static void Main(string[] args)
        {

            CancellationToken Token = new CancellationToken();
            Token.Cancellation_Token();

            HandledException TaskHandled = new HandledException();
            TaskHandled.Handled_Exception();
            

        }
    }
}
