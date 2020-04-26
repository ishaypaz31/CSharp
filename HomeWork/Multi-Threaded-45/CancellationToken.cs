using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_45
{
    class CancellationToken
    {
        static CancellationTokenSource TS = new CancellationTokenSource();

        public void Cancellation_Token()
        {
            Task<int> Numbers = new Task<int>(() =>
            {
                int x = 0;
                int result = 0;
                while (true && !TS.IsCancellationRequested)
                {
                    x++;
                    result = x;
                    Console.WriteLine($"Adding: {x}");
                    Thread.Sleep(500);
                }
                return result;
            });


            Task CancellationToken = new Task(() =>
            {
                Console.WriteLine("Press any key to call for Cancellation Token");
                Console.ReadLine();
                TS.Cancel();
                Console.WriteLine($"Final result is: {Numbers.Result}");
            });

            Numbers.Start();
            CancellationToken.Start();

            Numbers.Wait();
            CancellationToken.Wait();
        }


    }
}
