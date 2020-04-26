using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_45
{
    class HandledException
    {
        public void Handled_Exception()
        {

            Task Exce = new Task(() =>
            {
                int[] array = new int[1];
                Console.WriteLine(array[2]);
            });
            Exce.Start();

            Thread.Sleep(1000);
            if (Exce.IsFaulted)
            {
                Exce.Exception.Handle(exception =>
                {
                    Console.WriteLine($"The task failed due {exception}");
                    return true;
                });
            }
        }
    }
}
