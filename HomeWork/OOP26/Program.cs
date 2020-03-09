using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP26
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProtectedUniqueList list = new MyProtectedUniqueList("12345");
            list.Add("hello");
            list.Add("pizza");
            list.Add(".com");

            try
            {
                list.Remove("Microsoft");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unknown" + e);
            }
            finally
            {
                Console.WriteLine("finally here");
            }

            Console.WriteLine(list);



            MyProtectedUniqueListT<int> numbers = new MyProtectedUniqueListT<int>("12345");
            numbers.Add(1);
            numbers.Add(13);
            numbers.Add(27);

            try
            {
                numbers.Add(27);//trying add exists number
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unknown" + e);
            }
            finally
            {
                Console.WriteLine("finally here");
            }
            Console.WriteLine(numbers);


        }
    }
}
