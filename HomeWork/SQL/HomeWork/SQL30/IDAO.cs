using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30HW
{
    interface IDAO
    {
        object GetCountyAndItsCapitalCityName(int countryid);
        object GetCountyAndItsCapitalCityDDetails(int countryid);
        object GetCountyAndItsCapitalCityName(string countryName);
        object GetCountyAndItsCapitalCityDDetails(string countryName);

    }
}
