using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded_43
{
    public class MyTimer
    {
        private static MyTimer instance;
        private static object key = new object();

        protected MyTimer()
        {

        }

        public string GetTime()
        {
            return $"Time in Israel: {DateTime.Now}";
        }
        
        public static MyTimer GetInstance()
        {
            if (instance == null)
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new MyTimer();
                    }
                }
            }
            return instance;
        }

    }
}
