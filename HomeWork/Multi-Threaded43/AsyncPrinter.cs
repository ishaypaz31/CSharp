using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_43
{
    class AsyncPrinter
    {
        private Queue<string> Messages;
        static object key = new object();

        public AsyncPrinter()
        {
            Messages = new Queue<string>();
        }
        
        public void AddMessage(string Message)
        {
            lock (this)
            {

                Messages.Enqueue(Message);
                Console.WriteLine($"{Message}");
                Monitor.Pulse(this);
            }
        }

        public void CheckPrintMessage()
        {
            Console.WriteLine("CheckPrintMessage method called");
            lock (key)
            {
                while (Messages.Count == 0)
                {
                    Console.WriteLine("Waiting");
                    Monitor.Wait(key);
                }
                Console.WriteLine(Messages.Dequeue());
            }
        }
    }
}
