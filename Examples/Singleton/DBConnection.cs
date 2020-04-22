using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DBConnection
    {
        //Singleton
        private static object key = new object();
        public List<MyConnection> Connctions 
        {
            get; set;
        }

        //3. if instance not exist when requested -> create it!
        private static DBConnection _instance;


        //1. Cannot create more than 1 instance
        //2. Allow public access to the 1 instance
        //4. Thread Safe!
        public static DBConnection GetInstance()
        {
            // double check
            if (_instance == null)
            {
                lock (key)
                {
                    if (_instance == null)
                    {
                        _instance = new DBConnection();
                    }
                }
            }

            return _instance;
        }

        private DBConnection()
        {
            Connctions = new List<MyConnection>();
            Connctions.Add(new MyConnection());
            Connctions.Add(new MyConnection());
            Connctions.Add(new MyConnection());
            Connctions.Add(new MyConnection());
            Connctions.Add(new MyConnection());

        }
    }
}
