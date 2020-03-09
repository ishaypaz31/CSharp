using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace OOP21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car("BMW", "X8", 2020, "Dark Blue", 0, 4);

            XmlSerializer xmlSerializerCar = new XmlSerializer(typeof(Car));

            //using (Stream File = new FileStream(@"c:\XmlTest\xmlfile.xml", FileMode.Create)) //creating new file stream
            //{
            //    xmlSerializerCar.Serialize(File, c1);
            //}//close stream

            Car c2;

            using (Stream file = new FileStream(@"c:\XmlTest\xmlfile.xml", FileMode.Open)) //
            {
                c2 = xmlSerializerCar.Deserialize(file) as Car;
            } 

            Console.WriteLine(c2);
        }
    }
}
