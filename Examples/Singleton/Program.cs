using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection conn1 = DBConnection.GetInstance();
            DBConnection conn2 = DBConnection.GetInstance();


            //var conn = DBConnection.GetInstance().Connctions;

            if (conn1 != conn2)
            {
                Console.WriteLine("not a Singleton!!!");
            }
            else
            {
                Console.WriteLine("Singleton");
            }

            //DBConnection conn2 = new DBConnection();

        }
    }
}
