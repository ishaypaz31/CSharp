using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_42
{
    class ThreadExecutor
    {
        Queue<Thread> ThreadsQueue = new Queue<Thread>();
        Thread _EverySecondThread;

        public void DoEverySecond()
        {
            while (true)
            {
                lock (this)
                {
                    if (ThreadsQueue.Count > 0)
                    {
                        Execute();
                    }
                }
                Thread.Sleep(1000);
            }
        }

        public ThreadExecutor()
        {

            //EverySecondThread = new Thread(DoEverySecond);

            //_EverySecondThread.IsBackground = true; // also a solution

            //_EverySecondThread.Start();

            // Thread pool solution
            //ThreadPool.QueueUserWorkItem(new WaitCallback((object obj) => { DoEverySecond(); })); 

            // Timer solution
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed; // ThreadPool
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (this)
            {
                if (ThreadsQueue.Count > 0)
                {
                    Execute();
                }
            }
        }

        public void ShutDown()
        {
            _EverySecondThread.Abort();
        }



        public void Add(Thread thread)
        {
            lock (this)
            {
                if (thread != null)
                {
                    Console.WriteLine($"New Thread Entered The Queue");
                    ThreadsQueue.Enqueue(thread);

                }
            }
        }

        public void Execute()
        {
            lock (this)
            {
                while (ThreadsQueue.Count > 0)
                {
                    Thread CurrentThread = ThreadsQueue.Dequeue();
                    CurrentThread.Start();
                }
            }
        }


    }
}
