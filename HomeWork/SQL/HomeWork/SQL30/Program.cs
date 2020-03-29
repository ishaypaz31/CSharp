using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30HW
{
    class Program
    {
        static void Main(string[] args)
        {
            IDAO dao = new DAO();


            var Res1 = dao.GetCountyAndItsCapitalCityDDetails(1);
            Console.WriteLine(Res1);


            var Res2 = dao.GetCountyAndItsCapitalCityName(2);
            Console.WriteLine(Res2);


            var Res3 = dao.GetCountyAndItsCapitalCityName(3);
            Console.WriteLine(Res3);

            var resultCCName = dao.GetCountyAndItsCapitalCityDDetails("Tel Aviv");
            Console.WriteLine(resultCCName);
        }
    }
}
