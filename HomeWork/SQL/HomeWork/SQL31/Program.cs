using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL31HW
{
    class Program
    {
        static void Main(string[] args)
        {
            ISchoolDAO School = new SchoolDAO();
            Dictionary<ClassRoom, List<Student>> mapClassToListStudents = School.GetMapClassToStudentsDictionary(1);
            List<Student> students1 = School.GetStudentsFromClass(1);
            List<Student> students2 = School.GetStudentsFromClass(2);


            Console.WriteLine(School);
        }
    }
}
